package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import android.Manifest;
import android.app.DatePickerDialog;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.io.BufferedReader;
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

public class newadd extends AppCompatActivity
implements View.OnClickListener, DatePickerDialog.OnDateSetListener
{

    Calendar c = Calendar.getInstance();
    TextView txDate;
    TextView factorydate;
    EditText carnumtxv;
    EditText carmodtxv;
    EditText edit;
    int datePickerInput;
    Vector v = new Vector();
    carsample car = new carsample();
    File file = new File("/storage/emulated/0/Download/"+"car.txt");
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_newadd);
        txDate= (TextView)findViewById(R.id.handtime);
        factorydate = (TextView)findViewById(R.id.factroytime);
        carnumtxv = (EditText)findViewById(R.id.carnumber);
        carmodtxv = (EditText)findViewById(R.id.carmodel);
        edit = (EditText)findViewById(R.id.Edit);
        txDate.setOnClickListener(this);
        factorydate.setOnClickListener(this);
        if(ActivityCompat.checkSelfPermission(this,Manifest.permission.WRITE_EXTERNAL_STORAGE)!=PackageManager.PERMISSION_GRANTED) {
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.WRITE_EXTERNAL_STORAGE}, 200);
        }
        try {
            if (!file.exists()) {
                File dir = new File(file.getParent());
                dir.mkdirs();
                file.createNewFile();
                FileOutputStream os = new FileOutputStream(file);
                String str= "carnumber"+","+"carmodel"+","+"carfixitem"+","+"carkm"+","+"cartime"+","+"cartext"+"\n";
                os.write(str.getBytes());
                os.close();
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        try {
            FileInputStream  is = new FileInputStream(file);
            BufferedReader reader = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
            String line;
            try
            { reader.readLine();
                while ((line = reader.readLine()) != null) {
                    String[] tokens = line.split(",");
                    if(tokens[0].length()>0)
                    {
                        car.setCarnumber(tokens[0]);
                        v.add(new String(tokens[0]));
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
    private List<carsample>  cars = new ArrayList<>();
    @Override
    public void onDateSet(DatePicker datePicker, int year, int month, int day) {
            if(datePickerInput ==R.id.factroytime)
            {
                factorydate.setText(year+"/"+(month+1)+"/"+day);
            }
            if(datePickerInput ==R.id.handtime) {
                txDate.setText(year + "/" + (month + 1) + "/" + day);
            }

    }
    @Override
    public void onClick(View v) {
        datePickerInput=v.getId();
        new DatePickerDialog(this,this,c.get(Calendar.YEAR),c.get(Calendar.MONTH),c.get(Calendar.DAY_OF_MONTH)).show();
    }
    public void cancel (View v) {
        Intent it = new Intent();
        setResult(RESULT_CANCELED,it);
        finish();
    }
    public void save (View e) throws IOException {
        int Result=0;
        Intent it = new Intent();
        setResult(RESULT_OK,it);
        if(carnumtxv.getText().length()>0&&cars.toArray().length>0&&txDate.getText().length()>0&&factorydate.getText().length()>0)
        {
            try {
                FileOutputStream os = new FileOutputStream(file,true);
                for(int i =0;i<cars.toArray().length;i++)
                {
                    if(carnumtxv.getText().toString().compareToIgnoreCase(cars.get(i).getCarnumber().toString())==0)
                    {
                        Result++;
                    }
                }
                if( carnumtxv.getText().length()>0&&Result==0) {
                    if(carmodtxv.getText().length()==0)
                    {
                        carmodtxv.setText("無");
                    }
                    if(edit.getText().length()==0)
                    {
                        edit.setText("無");
                    }
                    os.write((carnumtxv.getText().toString()+","+carmodtxv.getText().toString()+","+factorydate.getText().toString()+","+"0"+","+txDate.getText().toString()+","+edit.getText().toString()+","+"\n").getBytes(StandardCharsets.UTF_8));
                    os.close();
                }
            } catch (Exception ex) {
                ex.printStackTrace();
                Toast.makeText(this,"",Toast.LENGTH_LONG);
            }
        }else
        {
            if(carnumtxv.getText().length()>0&&txDate.getText().length()>0&&factorydate.getText().length()>0) {
                FileOutputStream os = new FileOutputStream(file, true);
                if(carmodtxv.getText().length()==0)
                {
                    carmodtxv.setText("無");
                }
                if(edit.getText().length()==0)
                {
                    edit.setText("無");
                }
                os.write((carnumtxv.getText().toString()+","+carmodtxv.getText().toString()+","+factorydate.getText().toString()+","+"0"+","+txDate.getText().toString()+","+edit.getText().toString()+","+"\n").getBytes(StandardCharsets.UTF_8));
                os.close();
            }
        }
        finish();
    }
}