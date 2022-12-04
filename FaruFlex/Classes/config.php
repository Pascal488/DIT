<?php
    ob_start();
    session_start();

    date_default_timezone_set("Africa/Dar_es_Salaam");


try{
        //Conneting to database database name = netfleClone host localhost
        $connection = new PDO("mysql:dbname=netflixClone;host=localhost","root","");
        $connection->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_WARNING);
    }
    catch(PDOException $e){
        exit("Connection failed: ".$e->getMessage());
    }

?>