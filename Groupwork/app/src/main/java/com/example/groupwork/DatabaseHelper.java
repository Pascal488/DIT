package com.example.groupwork;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DatabaseHelper extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "kibamba_db";
    private static final int DATABASE_VERSION = 1;

    private static final String  TABLE_NAME_ROUTE = "routes";
    private static final String TABLE_NAME_USERS = "users";

    private static final String KEY_ID = "id";
    private static final String KEY_TITLE = "title";
    private static final String KEY_BODY = "body";

    private static final String KEY_EMAIL = "email";
    private static final String KEY_PASSWORD = "password";
    private static final String KEY_FIRSTNAME = "firstname";
    private static final String KEY_LASTNAME = "lastname";

    private static final String COLUMN_ROAD = "road";
    private static final String COLUMN_LINK = "link";
    private static final String COLUMN_SUBLINK = "sublink";
    private static final String COLUMN_START = "start";
    private static final String COLUMN_ENDER = "ender";
    private static final String COLUMN_CORRIDOR = "corridor";
    private static final String COLUMN_REGION = "region";

    public DatabaseHelper(Context context){
        super(context,DATABASE_NAME,null,DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {


        String queryUsers = "CREATE TABLE " + TABLE_NAME_USERS + " ( " + KEY_ID + " INTEGER PRIMARY KEY, " + KEY_EMAIL + " TEXT, " + KEY_PASSWORD + " TEXT, " + KEY_FIRSTNAME + " TEXT, " + KEY_LASTNAME + " TEXT )";
        db.execSQL(queryUsers);

        String queryRoute = "CREATE TABLE " + TABLE_NAME_ROUTE + " ( " +
                COLUMN_ROAD + " INTEGER, " +
                COLUMN_LINK + " INTEGER, " +
                COLUMN_SUBLINK + " INTEGER, " +
                COLUMN_START + " TEXT, " +
                COLUMN_ENDER + " TEXT, " +
                COLUMN_CORRIDOR + " TEXT, " +
                COLUMN_REGION + " TEXT )";
        db.execSQL(queryRoute);

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int i, int i1) {


        String queryUsers = "DROP TABLE IF EXISTS " + TABLE_NAME_USERS;
        db.execSQL(queryUsers);

        onCreate(db);
    }



    public boolean insertUserData(String email, String password, String firstname, String lastname) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put("email", email);
        contentValues.put("password", password);
        contentValues.put("firstname", firstname);
        contentValues.put("lastname", lastname);
        long result = db.insert("users", null, contentValues);
        return result != -1;
    }



    public boolean checkEmailPassword(String email, String password) {
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery("SELECT * FROM users WHERE email = ? AND password = ?", new String[]{email, password});
        boolean emailPasswordMatch = cursor.getCount() > 0;
        cursor.close();
        return emailPasswordMatch;
    }


    public boolean insertRouteData(int road, int link, int sublink, String start, String ender  , String corridor, String region) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put("Road", road);
        contentValues.put("Link", link);
        contentValues.put("Sublink", sublink);
        contentValues.put("Start", start);
        contentValues.put("Ender", ender);
        contentValues.put("Corridor", corridor);
        contentValues.put("Region", region);
        long result = db.insert(TABLE_NAME_ROUTE, null, contentValues);
        return result != -1;
    }



}
