<?php
    class PreviewProvider{
        private $connection,$username;

        public function __construct($connection,$username){
            $this->connection= $connection;
            $this->username = $username;

        }

        public function creatPreviewVideo($entity){
            if($entity == null){
                $entity= $this->getRandomEntity();
            }
            $name = $entity->getName();
            echo $name;
        }

        private function getRandomEntity(){
           $query = $this->connection->prepare("SELECT * FROM entities ORDER BY RAND() LIMIT 1");
           $query->execute();

           $row = $query->fetch(PDO::FETCH_ASSOC);
           return new Entity($this->connection,$row);

        }
    }

?>