<?php

//Importing a class from another folder
require_once("Classes/FormSanitize.php")
if(isset($_POST["submitButton"])){
    $firstname = FormSanitize::sanitazingInputs($_POST["firstname"]);
    $lastname = FormSanitize::sanitazingInputs($_POST["lastname"]);
    $username = FormSanitize::sanitazingUsername($_POST["username"]);
    $password = FormSanitize::sanitazingPassword($_POST["password"]);
    $password2 = FormSanitize::sanitazingPassword($_POST["comfirmpassword"]);
    $email1 = FormSanitize::sanitazingEmail($_POST["email1"]);
    $email2 = FormSanitize::sanitazingEmail($_POST["email2"]);



}




?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="styles/style.css">
</head>
<body>
    <div class="container">
        <div class="column">
            <h3>Register here</h3>
            <form action="" method="post">
                <input type="text" name="firstname" placeholder="Firstname" required>
                <input type="text" name="lastName" placeholder="Lastname" required>
                <input type="text" name="username" placeholder="Username" required>
                <input type="password" name="password" placeholder="Password" required>
                <input type="password" name="comfirmpassword" placeholder="ComfirmPassword" required>
                <input type="email" name="email1" placeholder="Email" required>
                <input type="email" name="email2" placeholder="Comfirm email" required>
                <input type="submit" value="SUBMIT" name="submitButton">

            </form>
            <a href="register.php" class="signInMessage">Need an account? Sign up here!</a>
            
        </div>
    </div>
</body>
</html>