package com.example.myapplication;

import androidx.activity.result.ActivityResult;
import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.text.Spannable;
import android.text.SpannableString;
import android.text.SpannableStringBuilder;
import android.text.style.ForegroundColorSpan;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Vector;

public class set extends AppCompatActivity
        implements DialogInterface.OnClickListener, AdapterView.OnItemClickListener, AdapterView.OnItemLongClickListener {
    ListView lv;
    ArrayAdapter<String> l;
    TextView txv;
    TextView soldtime,factorytime;
    String str;
    String carmodel;
    String carfixitemch;
    String cartimech;
    String carkmch;
    String carmodelch;
    AlertDialog.Builder check;
    List<HashMap<String,Object>> data ;
    File file = new File("/storage/emulated/0/Download/"+"car.txt");
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_set);
        Intent it = getIntent();
        String item;
        item = it.getStringExtra("車牌");
        str = item;
        txv = (TextView) findViewById(R.id.carnumshow);
        soldtime = (TextView)findViewById(R.id.soldouttxv);
        factorytime = (TextView)findViewById(R.id.factorytxv);
        txv.setText(item);
        lv = (ListView) findViewById(R.id.list);
        try {
            readcsv();
        } catch (IOException e) {
            e.printStackTrace();
        }
        lv.setOnItemClickListener(this);
        lv.setOnItemLongClickListener(this);
        check = new AlertDialog.Builder(this);
        check.setTitle("刪除");
        check.setMessage("請為是否要刪除");
        check.setCancelable(true);
        check.setNegativeButton("取消",this);
        check.setPositiveButton("確定",this);
    }
    ActivityResultLauncher<Intent> someActivityResultLauncher = registerForActivityResult(
            new ActivityResultContracts.StartActivityForResult(),
            new ActivityResultCallback<ActivityResult>() {
                @Override
                public void onActivityResult(ActivityResult result) {
                    if (result.getResultCode() == RESULT_OK) {

                        Intent data = result.getData();
                        int requestCode=data.getIntExtra("NO",0);
                        try {
                            readcsv();
                        } catch (IOException e) {
                            e.printStackTrace();
                        }
                    }
                }
            });
    private List<carsample> cars;
    private List<carsample> carswr;
    private void readcsv() throws IOException {
        try {
            data  = new ArrayList<HashMap<String,Object>>();
            cars = new ArrayList<>();
            FileInputStream is = new FileInputStream(file);
            BufferedReader reader = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
            String line;
            reader.readLine();
            while ((line = reader.readLine()) != null) {
                String[] tokens = line.split(",");
                carsample car = new carsample();
                HashMap<String, Object> exa = new HashMap<String, Object>();
                if (tokens[0].compareToIgnoreCase(str) == 0) {
                    if (Integer.parseInt(tokens[3]) == 0) {
                        factorytime.setText(tokens[2]);
                        soldtime.setText(tokens[4]);
                        carmodel = tokens[1];
                    } else {
                        car.setCarnumber(tokens[0]);
                        car.setCarmodel(tokens[1]);
                        car.setCarfixitem(tokens[2]);
                        car.setKm(Integer.parseInt(tokens[3]));
                        car.setCartime(tokens[4]);
                        car.setCartext(tokens[5]);
                        cars.add(car);
                        exa.put("setitem", tokens[2]);
                        exa.put("setitemkm", tokens[3]);
                        exa.put("setitemdate", tokens[4]);
                        data.add(exa);
                    }
                }
            }
            madaper adapter = new madaper(set.this,data,R.layout.setitem,new String[]{"setitem","setitemkm","setitemdate"},new int[]{R.id.setitem,R.id.setitemkm,R.id.setitemdate});
            lv.setAdapter(adapter);
             } catch (IOException e) {
                  e.printStackTrace();
             }
    }
    public class madaper extends SimpleAdapter{
        public madaper(Context context, List<HashMap<String, Object>> items, int resource, String[] from, int[] to) {
            super(context, items, resource, from, to);

        }
        public View getView(int position, View convertView, ViewGroup parent){
            convertView=super.getView(position, convertView, parent);
            TextView num=(TextView)convertView.findViewById(R.id.setitem);
            //判断收支类型并设置数字颜色
            SpannableStringBuilder spannable = new SpannableStringBuilder(num.getText().toString());
            String[] ser = num.getText().toString().split(":");
            for(int i = 0 ;i<ser.length;i++) {
                if(ser[i].indexOf("更換")!=-1)
                {
                    int nu=num.getText().toString().indexOf("更換");
                    int x = ser[i].length();
                    spannable.setSpan(new ForegroundColorSpan(Color.RED),nu-x+2,nu+2, Spannable.SPAN_EXCLUSIVE_EXCLUSIVE);
                    num.setText(spannable);
                }
            }
       /*     if(num.getText().toString().indexOf("更換")!=-1)num.setTextColor(Color.RED);
            else num.setTextColor(Color.BLACK);*/



            return convertView;
        }

    }
    public void add(View v)
    {
        Intent it = new Intent(this,addfix.class);
        it.putExtra("車牌",str);
        it.putExtra("型號",carmodel);
        someActivityResultLauncher.launch(it);
    }
    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {

    }
    @Override
    public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
        check.show();
        carmodelch= cars.get(i).getCarmodel();
        cartimech = cars.get(i).getCartime();
        carfixitemch = cars.get(i).getCarfixitem();
        carkmch = cars.get(i).getKm().toString();
        return true;
    }

    @Override
    public void onClick(DialogInterface dialogInterface, int i) {
        if (i == DialogInterface.BUTTON_POSITIVE) {
            try {
                carswr = new ArrayList<>();
                FileInputStream is = new FileInputStream(file);
                BufferedReader reader = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
                String line;
                reader.readLine();
                while ((line = reader.readLine()) != null) {
                    String[] tokens = line.split(",");
                    carsample car = new carsample();
                    int ch=0;
                    if(tokens[0].compareToIgnoreCase(str)==0&&
                       tokens[2].compareToIgnoreCase(carfixitemch)==0&&
                       tokens[4].compareToIgnoreCase(cartimech)==0&&
                       tokens[3].compareToIgnoreCase(carkmch)==0
                    ) { ch++; }
                    if(ch==0){
                        car.setCarnumber(tokens[0]);
                        car.setCarmodel(tokens[1]);
                        car.setCarfixitem(tokens[2]);
                        car.setKm(Integer.parseInt(tokens[3]));
                        car.setCartime(tokens[4]);
                        car.setCartext(tokens[5]);
                        carswr.add(car);
                    }
                }
                FileOutputStream os = new FileOutputStream(file,false);
                os.write(("carnumber"+","+"carmodel"+","+"carfixitem"+","+"carkm"+","+"cartime"+","+"cartext"+"\n").getBytes(StandardCharsets.UTF_8));
                os.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
            try {
                FileOutputStream os = new FileOutputStream(file,true);
                for(int x = 0 ; x<carswr.size();x++)
                {
                    os.write((carswr.get(x).getCarnumber()+","+carswr.get(x).getCarmodel()+","+carswr.get(x).getCarfixitem()+","+carswr.get(x).getKm()+","+carswr.get(x).getCartime()+","+carswr.get(x).getCartext() +","+"\n").getBytes(StandardCharsets.UTF_8));
                }
                os.close();
            }catch (IOException e) { e.printStackTrace(); }
            try {
                readcsv();
            } catch (IOException e) { e.printStackTrace();  }
        }
    }
}