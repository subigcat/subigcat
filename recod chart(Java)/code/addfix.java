package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
import java.util.Vector;

public class addfix extends AppCompatActivity
        implements View.OnClickListener, DatePickerDialog.OnDateSetListener, AdapterView.OnItemSelectedListener,AdapterView.OnItemLongClickListener
{
    Calendar c = Calendar.getInstance();
    String carfixtxv;
    String itemtxv;
    Spinner carfix;
    Spinner caritem;
    String carmodel,carnum;
    TextView txDate;
    EditText txkm;
    EditText note;
    ListView itemlv;
    Vector<String> itemlist  = new Vector<>();
    ArrayAdapter<String> l;
    carsample car = new carsample();
    File file = new File("/storage/emulated/0/Download/"+"car.txt");
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_addfix);
        Intent it = getIntent();
        carnum = it.getStringExtra("車牌");
        carmodel = it.getStringExtra("型號");
        carfix= (Spinner)findViewById(R.id.carfix);
        caritem = (Spinner)findViewById(R.id.item);
        txDate= (TextView)findViewById(R.id.settime);
        txkm= (EditText)findViewById(R.id.setkm);
        note = (EditText)findViewById(R.id.addeditText);
        itemlv= (ListView)findViewById(R.id.itemlist);
        txDate.setOnClickListener(this);
        carfix.setOnItemSelectedListener(this);
        caritem.setOnItemSelectedListener(this);
        itemlv.setOnItemLongClickListener(this);
        try {
            FileInputStream is = new FileInputStream(file);
            BufferedReader reader = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
            String line;
            try
            { reader.readLine();
                while ((line = reader.readLine()) != null) {
                    String[] tokens = line.split(",");
                    if(tokens[0].length()>0)
                    {
                        car.setCarnumber(tokens[0]);
                        car.setCarmodel(tokens[1]);
                        car.setCarfixitem(tokens[2]);
                        car.setKm(Integer.parseInt(tokens[3]));
                        car.setCartime(tokens[4]);
                        car.setCartext(tokens[5]);
                    }
                    cars.add(car);
                }
            }
            catch(IOException e)
            {
                e.printStackTrace();
            }
        } catch (FileNotFoundException e) { e.printStackTrace(); }
    }
    @Override
    public void onDateSet(DatePicker datePicker, int year, int month, int day) {
        txDate.setText(year+"/"+(month+1)+"/"+day);
    }

    @Override
    public void onClick(View v) {
        if(v==txDate)
        {
            new DatePickerDialog(this,this,c.get(Calendar.YEAR),c.get(Calendar.MONTH),c.get(Calendar.DAY_OF_MONTH)).show();
        }
    }
    public void additem(View v) {
        Boolean listch  = false;
        if(itemlist.size()>0) {
            for (int i = 0; i < itemlist.size(); i++) {
                if ((itemtxv+ "/" + carfixtxv ).compareToIgnoreCase(itemlist.get(i).toString()) == 0) {
                    listch = true;
                }
            }
            if (listch == false) {
                itemlist.add(itemtxv+ "/" + carfixtxv);
                l = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, itemlist);
                itemlv.setAdapter(l);
            }
        }else
        {
            itemlist.add(itemtxv+ "/" + carfixtxv);
            l = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, itemlist);
            itemlv.setAdapter(l);
        }
    }
    public void cancel (View v) {
        finish();
    }
    private List<carsample> cars = new ArrayList<>();
    public void save (View v) {
        Intent it = new Intent(this,set.class);
        it.putExtra("車牌",carnum);
        Boolean kmcheck = txkm.getText().toString().matches("[+-]?\\d*(\\.\\d+)?");
        setResult(RESULT_OK,it);
        int Result=0;
        if(txkm.getText().length()>0&&txDate.getText().length()>0&&kmcheck==true&&itemlist.size()>0)
        {
            try {
                FileOutputStream os = new FileOutputStream(file,true);
                    StringBuffer fixitemstr = new StringBuffer();
                    if (note.getText().length() == 0) {
                        note.setText("無");
                    }
                    for(int i = 0;i<itemlist.size();i++)
                    {
                        if(i==0)
                        {
                            fixitemstr.insert(0,itemlist.get(i).toString());
                        }else
                        {
                            fixitemstr.insert(0,itemlist.get(i).toString()+":");
                        }
                    }
                    os.write((carnum.toString() + "," + carmodel.toString() + "," + fixitemstr+ "," + txkm.getText().toString() + "," + txDate.getText().toString() + "," + note.getText().toString() + "," + "\n").getBytes(StandardCharsets.UTF_8));
                    os.close();
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        }
        finish();
    }
    @Override
    public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
        if(adapterView.getId()==R.id.carfix) {
            carfixtxv = adapterView.getItemAtPosition(i).toString();
        }
        if(adapterView.getId()==R.id.item)
        {
            itemtxv=adapterView.getItemAtPosition(i).toString();
        }
    }

    @Override
    public void onNothingSelected(AdapterView<?> adapterView) {

    }

    @Override
    public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long x) {
        itemlist.remove(i);
        l = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, itemlist);
        itemlv.setAdapter(l);
        return true;
    }
}