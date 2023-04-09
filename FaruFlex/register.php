<?php
//Importing a class from another folder
require_once("Classes/FormSanitize.php");
require_once("Classes/config.php");
require_once("Classes/Account.php");
require_once("Classes/Constant.php");

$Account = new Account($connection);

if(isset($_POST["submitButton"])){
    //FormSanitize::.-> represent a static function
    $firstname = FormSanitize::sanitazingInputs($_POST["firstname"]);
    $lastname = FormSanitize::sanitazingInputs($_POST["lastname"]);
    $username = FormSanitize::sanitazingUsername($_POST["username"]);
    $password1 = FormSanitize::sanitazingPassword($_POST["password1"]);
    $password2 = FormSanitize::sanitazingPassword($_POST["password2"]);
    $email1 = FormSanitize::sanitazingEmail($_POST["email1"]);
    $email2 = FormSanitize::sanitazingEmail($_POST["email2"]);

  $success =  $Account->register($firstname,$lastname,$email1,$email2,$password1,$password2,$username);

    if($success){
        header("Location: index.php");
    }


    

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
                <br/><?php echo $Account->getError(Constants::$firstNameCharacters); ?>
                <input type="text" name="firstname" placeholder="Firstname" >
                <?php echo $Account->getError(Constants::$lastNameCharacters); ?>
                <input type="text" name="lastname" placeholder="Lastname" >
                <?php echo $Account->getError(Constants::$usernameCharacters); ?>
                <?php echo $Account->getError(Constants::$usernameTaken); ?>
                <input type="text" name="username" placeholder="Username" >
                <?php echo $Account->getError(Constants::$emailMatch); ?>
                <?php echo $Account->getError(Constants::$emailTaken); ?>
                <input type="email" name="email1" placeholder="Email" >
                <input type="email" name="email2" placeholder="Comfirm email" >
                <?php echo $Account->getError(Constants::$passwordMatch); ?>
                <input type="password" name="password1" placeholder="Password" >
                <input type="password" name="password2" placeholder="ComfirmPassword" >
                <input type="submit" value="SUBMIT" name="submitButton"id="submitButton" >
            </form>
            <a href="login.php" class="signInMessage">Already have an account? Sign in here!</a>
        </div>
    </div>

</body>
</html>