<?php
class Account {

    private $connection;
    private $errorArray = array();

    public function __construct($connection) {
        $this->connection = $connection;
    }
    public function register($firstname,$lastname,$email1,$email2,$password,$password2,$username){
        $this->validateFirstName($firstname);
        $this->validateLastName($lastname);
        $this->validateUserName($username);
        $this->validateEmail($email1,$email2);


    }
    public function validateFirstName($firstname){
        if(strlen($firstname)<2 ||strlen($firstname)>25 ){
            array_push($this->errorArray,Constants::$firstNameCharacters);
        }
    }
    public function validateLastName($lastname){
        if(strlen($lastname)<2 ||strlen($lastname)>25 ){
            array_push($this->errorArray,Constants::$lastNameCharacters);
        }
    }
    public function validateUserName($username){
        if(strlen($username)<2 ||strlen($username)>25 ){
            array_push($this->errorArray,Constants::$usernameCharacters);
        }

        $query = $this->connection->prepare("SELECT * FROM users WHERE username=:username");
        $query->bindvalue(":username",$username);
        $query->execute();

        if($query->rowCount() != 0){
            array_push($this->errorArray,Constants::$usernameTaken);

        }
    }

    public function validateEmail($email1,$email2){
        if($email1 != $email2){
            array_push($this->errorArray,Constants::$emailMatch);

        }
    }

    public function getError($error){
        if(in_array($error,$this->errorArray)){
            return $error;
        }

    }

}
?>