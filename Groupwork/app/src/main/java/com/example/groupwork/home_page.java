package com.example.groupwork;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class home_page extends AppCompatActivity {
    EditText road, link, sub_link, start, ender, corridor, region;
    Button next_to_save;
    DatabaseHelper dbhelper;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getSupportActionBar().hide();
        setContentView(R.layout.activity_home_page);

        road = findViewById(R.id.road);
        link = findViewById(R.id.link);
        sub_link = findViewById(R.id.sublink);

        start = findViewById(R.id.starter);
        ender = findViewById(R.id.ender);

        corridor = findViewById(R.id.corridor);
        region = findViewById(R.id.region);
        next_to_save = findViewById(R.id.next_save);
        dbhelper = new DatabaseHelper(this);

        next_to_save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String startValue, endValue, regionValue, corridorValue;
                int roadValue = 0, linkValue = 0, sub_linkValue = 0;
                boolean isEmptyInput = false;

                // Check if input fields are empty
                if (TextUtils.isEmpty(road.getText())) {
                    road.setError("Required");
                    isEmptyInput = true;
                } else {
                    roadValue = Integer.parseInt(road.getText().toString());
                }

                if (TextUtils.isEmpty(link.getText())) {
                    link.setError("Required");
                    isEmptyInput = true;
                } else {
                    linkValue = Integer.parseInt(link.getText().toString());
                }

                if (TextUtils.isEmpty(sub_link.getText())) {
                    sub_link.setError("Required");
                    isEmptyInput = true;
                } else {
                    sub_linkValue = Integer.parseInt(sub_link.getText().toString());
                }
                startValue = start.getText().toString();
                endValue = ender.getText().toString();
                regionValue = region.getText().toString();
                corridorValue = corridor.getText().toString();

                if (startValue.equals("") || endValue.equals("") || corridorValue.equals("") || regionValue.equals("")) {
                    Toast.makeText(home_page.this, "Enter all required values", Toast.LENGTH_SHORT).show();
                } else {
                    Boolean insert = dbhelper.insertRouteData(roadValue,linkValue,sub_linkValue,startValue,endValue,corridorValue,regionValue);
                    if (insert == true){
                        Toast.makeText(home_page.this, "Restister sucess", Toast.LENGTH_SHORT).show();
                        Intent intent = new Intent(home_page.this,reigister_activity.class);
                        startActivity(intent);
                    }else{
                        Toast.makeText(home_page.this, "Register Failed", Toast.LENGTH_SHORT).show();
                    }
                }
            }
        });
    }
}
