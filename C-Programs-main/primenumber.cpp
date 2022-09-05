#include <iostream>
using namespace std;

//To check a number if it is a prime number

bool isAprime(int number){
    bool isprimeyes = true;
     
     for(int i =2;i<number;i++){
         if(number % i == 0){
             return false;
         }
     }
    return isAprime;


}



int main(){
  
    int number,i;
    cout<<"Number "<<endl;
    cin>>number;
    bool yesaprime = isAprime(number);

    if (yesaprime)
    {
        cout<<number<<" Is a prime number";
    }else{
        cout<<"Not a prime number ";
    }
    

}

