<?php
require_once("Classes/FormSanitize.php");
require_once("Classes/config.php");
require_once("Classes/Account.php");
require_once("Classes/Constant.php");

$account = new Account($connection);

    if(isset($_POST["submitButton"])) {

        $username = FormSanitize::sanitazingUsername($_POST["username"]);
        $password1 = FormSanitize::sanitazingPassword($_POST["password1"]);

        $success = $account->login($username, $password1);

        if($success) {
            // Store session
            header("Location: index.php");
        }
    }
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Welcome to Reeceflix</title>
        <link rel="stylesheet" type="text/css" href="styles/style.css" />
    </head>
    <body>
        
        <div class="container">
            
            <div class="column">
            <h1>
                Login Here
            </h1>
                <form method="POST">
                <?php echo $account->getError(Constants::$loginFailed); ?>
                    <input type="text" name="username" placeholder="Username" required>

                    <input type="password" name="password1" placeholder="Password" required>

                    <input type="submit" name="submitButton" value="SUBMIT">

                </form>

                <a href="register.php" class="signInMessage">Need an account? Sign up here!</a>

            </div>

        </div>

    </body>
</html>