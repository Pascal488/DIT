<?php
class Account {

    private $connection;
    private $errorArray = array();
    public function __construct($connection) {
        $this->connection = $connection;
    }
    public function register($firstname,$lastname,$email1,$email2,$password,$password2,$username){
        //Calling to execute all functions of validating
        $this->validateFirstName($firstname);
        $this->validateLastName($lastname);
        $this->validateUserName($username);
        $this->validateEmail($email1,$email2);
        $this->validatePassword($password,$password2);
        $this->validateEmptyInputs($firstname,$lastname,$email1,$email2,$password,$password2,$username);


    }
    public function validateEmptyInputs($firstname,$lastname,$email1,$email2,$password,$password2,$username){
        if($firstname||$lastname||$email1||$email2||$password||$password2||$username == ""){
            array_push($this->errorArray,Constants::$emptyInputs);
            return;

        }
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
    private function validatePassword($password,$password2){
        //Checking if the two passwords are the same
        if($password != $password2){
            array_push($this->errorArray,Constants::$passwordMatch);
            return;
        }
    }

    public function getError($error){
        if(in_array($error,$this->errorArray)){
            return $error;
        }

    }

}
?>