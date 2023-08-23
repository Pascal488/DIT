package com.example.groupwork;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    Button loginButton;
    EditText email,password;
    TextView gotoSignup;
    String emailValue,passwordValue;
    DatabaseHelper databaseHelper;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getSupportActionBar().hide();
        setContentView(R.layout.activity_main);

        loginButton = findViewById(R.id.loginButton);
        gotoSignup = findViewById(R.id.signupTextView);
        email = findViewById(R.id.emailEditText);
        password = findViewById(R.id.passwordEditText);
        databaseHelper = new DatabaseHelper(this);

        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                emailValue = email.getText().toString();
                passwordValue = password.getText().toString();
                if (emailValue.equals("") && passwordValue.equals("")) {
                    Toast.makeText(getApplicationContext(), "Enter the fields required", Toast.LENGTH_SHORT).show();

                } else {
                    Boolean checkemailandpassword = databaseHelper.checkEmailPassword(emailValue,passwordValue);
                    if (checkemailandpassword == true){
                        Toast.makeText(MainActivity.this, "Login Successfully!", Toast.LENGTH_SHORT).show();
                        Intent intent  = new Intent(MainActivity.this, home_page.class);
                        startActivity(intent);
                    }else{
                        Toast.makeText(MainActivity.this, "Invalid Credentials", Toast.LENGTH_SHORT).show();
                    }
                }
            }
        });

        gotoSignup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent  = new Intent(MainActivity.this,reigister_activity.class);
                startActivity(intent);
            }
        });
    }
}