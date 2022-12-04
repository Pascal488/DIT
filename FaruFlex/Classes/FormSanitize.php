<?php
    class FormSanitize{
        public static function sanitazingInputs($inputText){
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
        public static function sanitazingUsername($inputText){
            $inputText = strip_tags($inputText);
            $inputText = trim($inputText);
            return $inputText;
        
        }
        public static function sanitazingPassword($inputText){
            $inputText = strip_tags($inputText);
            return $inputText;        
        }
        public static function sanitazingEmail($inputText){
            $inputText = strip_tags($inputText);
            $inputText = trim($inputText);
            return $inputText;
        
        }
        
    }
?>