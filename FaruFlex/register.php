<?php
if(isset($_POST["submitButton"])){
    $firstname = sanitazingInputs($_POST["firstname"]);
    echo "$firstname";


}

function sanitazingInputs($inputText){
    //Removing any html tags
    $inputText = strip_tags($inputText);
    //Removing spaces in input text
    $inputText = trim($inputText);
    //Change a string to lowerCase
    $inputText = strtolower($inputText);
    //Captalizing a first latter of a string
    $inputText = ucfirst($inputText);

    return $inputText;

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