<?php
class Account {
    private $connection;
    private $errorArray = array();
    public function __construct($connection) {
        $this->connection = $connection;
    }
    public function register($firstname,$lastname,$email1,$email2,$password1,$password2,$username){
        //Calling to execute all functions of validating
        $this->validateFirstName($firstname);
        $this->validateLastName($lastname);
        $this->validateUserName($username);
        $this->validateEmail($email1,$email2);
        $this->validatePassword($password1,$password2);

        //Giving a conditional statement before calling a function that can insert data to db
        //So the conditional says if there is no any error into the errorArray the function can be executed and insert details to the db
        if(empty($this->errorArray)){
            return $this->insertUserIntoDb($firstname,$lastname,$email1,$password1,$username);
           

        }
        return false;
    }
    public function login($username, $password1) {
        $password1 = hash("sha512", $password1);

        $query = $this->connection->prepare("SELECT * FROM users WHERE userName=:username AND password=:password1");
        $query->bindValue(":username", $username);
        $query->bindValue(":password1", $password1);

        $query->execute();

        if($query->rowCount() == 1) {
            return true;
        }

        array_push($this->errorArray, Constants::$loginFailed);
        return false;
    }

    //Function to enter users into a db
    private function insertUserIntoDb($firstname,$lastname,$email1,$password1,$username){
        //Hashing password
        $password1 = hash("sha512",$password1);
        //The attribute must match like those from the db
        $query = $this->connection->prepare("INSERT INTO users(firstName,lastName,userName,email,password)
                                            VALUES (:firstname,:lastname,:username,:email1,:password1)");
        $query->bindValue(":firstname",$firstname);
        $query->bindValue(":lastname",$lastname);
        $query->bindValue(":email1",$email1);
        $query->bindValue(":password1",$password1);
        $query->bindValue(":username",$username);

        // $query->execute();
        // var_dump($query->errorInfo());
        return $query->execute();
        // return false;

    }
  
    public function validateFirstName($firstname){
        //Checking firsrname characters
        if(strlen($firstname)<2 ||strlen($firstname)>25 ){
            array_push($this->errorArray,Constants::$firstNameCharacters);
        }
    }
    public function validateLastName($lastname){
        //Checking  lastname characters 
        if(strlen($lastname)<2 ||strlen($lastname)>25 ){
            array_push($this->errorArray,Constants::$lastNameCharacters);
        }
    }
    public function validateUserName($username){
        //Checking  username characters 
        if(strlen($username)<2 ||strlen($username)>25 ){
            array_push($this->errorArray,Constants::$usernameCharacters);
        }
        //Checking if the entered value of username is already taken
        $query = $this->connection->prepare("SELECT * FROM users WHERE username=:username");
        $query->bindvalue(":username",$username);
        $query->execute();

        if($query->rowCount() != 0){
            array_push($this->errorArray,Constants::$usernameTaken);

        }
    }

    public function validateEmail($email1,$email2){
        //Checking if the two emails are the same
        if($email1 != $email2){
            array_push($this->errorArray,Constants::$emailMatch);
            return;
        }
        //Checking if the entered value of email is already taken
        $query = $this->connection->prepare("SELECT * FROM users WHERE email=:email");
        $query->bindvalue(":email",$email1);
        $query->execute();

        if($query->rowCount() != 0){
            array_push($this->errorArray,Constants::$emailTaken);
            return;

        }
        //Checking if email entered is in a correct format
        if(!filter_var($email1,FILTER_VALIDATE_EMAIL)){
            array_push($this->errorArray,Constants::$emailInvalid);

        }
    }
    private function validatePassword($password1,$password2){
        //Checking if the two passwords are the same
        if($password1 != $password2){
            array_push($this->errorArray,Constants::$passwordMatch);
            return;
        }
    }
    //Function to validate if there is any errors in the array and return and to the span html element
    public function getError($error){
        if(in_array($error,$this->errorArray)){
            return "<span class='errorMessage'>$error</span>";
        }

    }

}
?>