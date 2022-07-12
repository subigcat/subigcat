package com.example.myapplication;

import androidx.activity.result.ActivityResult;
import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import android.app.Activity;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.HashMap;
import java.util.List;
import java.util.Vector;
public class MainActivity extends AppCompatActivity
implements AdapterView.OnItemClickListener, AdapterView.OnItemLongClickListener,DialogInterface.OnClickListener {
    ListView lv;
    ArrayAdapter<String> l;
    Vector v ;
    String checkcarnum;
    Vector <String> carlist1;
    List<HashMap<String,Object>> data ;
    AlertDialog.Builder check;
    File file = new File("/storage/emulated/0/Download/"+"car.txt");
    Calendar mCal = Calendar.getInstance();
    String dateformat = "yyyyMMdd";
    SimpleDateFormat df = new SimpleDateFormat(dateformat);
    String today = df.format(mCal.getTime());
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Intent it = getIntent();
        lv= (ListView)findViewById(R.id.list);
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
    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
        Intent it = new Intent(this,set.class);
        String[] ser= carlist1.get(i).toString().split(":");
        it.putExtra("車牌",ser[1]);
        startActivity(it);
    }
    public void addclick(View v) {
        Intent it = new Intent(this,newadd.class);
        someActivityResultLauncher.launch(it);
    }
    private void readcsv() throws IOException {
        try
        {  carlist1 =new Vector();
            v =new Vector();
            data  = new ArrayList<HashMap<String,Object>>();
            FileInputStream is = new FileInputStream(file);
            BufferedReader reader = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
            String line;
            int i=0;
            reader.readLine();
            while ((line = reader.readLine()) != null) {
                String[] tokens = line.split(",");
                carsample car = new carsample();
                if(tokens[0].length()>0)
                {
                    car.setCarnumber(tokens[0]);
                    v.add(new String( tokens[1])+":"+tokens[0]);
                }
            }
            for(int x=0;x<v.size();x++)
            {
                HashMap<String,Object> exa = new HashMap<String,Object>();
                if(!carlist1.contains(v.get(x)))
                {
                    carlist1.add(v.get(x).toString());
                    String[] sp = v.get(x).toString().split(":");
                    exa.put("setfactory",sp[0]);
                    exa.put("setnum",sp[1]);
                    data.add(exa);
                }

            }
            SimpleAdapter adapter = new SimpleAdapter(MainActivity.this,data,R.layout.carset,new String[]{"setfactory","setnum"},new int[]{R.id.setfactory,R.id.setnum});
            lv.setAdapter(adapter);
        }

        catch(IOException e)
        {
            e.printStackTrace();
        }
    }
    private List<carsample> carswr;
    @Override
    public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
        String[] ch = v.get(i).toString().split(":");
        checkcarnum = ch[1];
        check.setMessage("請為是否要刪除"+ch[1]);
        check.show();
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
                    if(tokens[0].compareToIgnoreCase(checkcarnum)!=0
                    ) { car.setCarnumber(tokens[0]);
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