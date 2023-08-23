package com.example.groupwork;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class reigister_activity extends AppCompatActivity {
        EditText email,fname,lname,password;
        Button registerbuton;
        DatabaseHelper dbhelper;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        // hide app bar
        getSupportActionBar().hide();
        setContentView(R.layout.activity_reigister);
        registerbuton = findViewById(R.id.registerButton);
        email = findViewById(R.id.registeredEmail);
        fname = findViewById(R.id.firstname);
        lname  = findViewById(R.id.lastName);
        password = findViewById(R.id.passwordEditText);
        dbhelper = new DatabaseHelper(this);

        registerbuton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                    String emailValue,passwordValue,fnameValue,lastnameValue;
                    emailValue = email.getText().toString();
                    passwordValue = password.getText().toString();
                    fnameValue = fname.getText().toString();
                    lastnameValue = lname.getText().toString();

                    if (emailValue.equals("") || passwordValue.equals("") || fnameValue.equals("") || lastnameValue.equals("")){
                        Toast.makeText(reigister_activity.this, "Enter all the values requires", Toast.LENGTH_SHORT).show();
                    }else{
                        Boolean insert = dbhelper.insertUserData(emailValue,passwordValue,fnameValue,lastnameValue);
                            if (insert == true){
                                Toast.makeText(reigister_activity.this, "Restister sucess", Toast.LENGTH_SHORT).show();
                                Intent intent = new Intent(reigister_activity.this,MainActivity.class);
                                startActivity(intent);
                            }else{
                                Toast.makeText(reigister_activity.this, "Register Failed", Toast.LENGTH_SHORT).show();
                            }
                        }
                    }


        });

    }
}