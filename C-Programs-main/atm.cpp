#include <iostream>
using namespace std;

//Check balance 
//Deposit money
//Withdraw money
void balanceChecker(int balance);
void menuDisplay();
void depositer(int depositAmount,int balance);
void withdrawer(int withdrawAmount,int balance,int remaining);




int main(){
    int option,balance,depositAmount,withdrawAmount,remaining;
   do{
    menuDisplay();
    cout<<"Choose option ";
    cin>>option;
    
    switch (option)
    {
    case 1:
        balanceChecker(balance);
        break;
    
    case 2:
        depositer(depositAmount, balance);
        break;
    case 3:
       withdrawer(withdrawAmount, balance, remaining);

    }
    }while(option!=4);


}

void menuDisplay(){
    cout<<"1: "<<"Check balance "<<endl;
    cout<<"2: "<<"Deposit money "<<endl;
    cout<<"3: "<<"Withdraw money "<<endl;
    cout<<"4: "<<"Exit "<<endl;

    
}
void balanceChecker(int balance=500){
    cout<<"The balance of an account is "<<balance<<endl;
}
void depositer(int depositAmount,int balance){
    cout<<"Enter amount to deposit "<<endl;
        cin>>depositAmount;
        balance += depositAmount;
        cout<<"You have deposit  "<<depositAmount<<endl;
        cout<<"Now your balance is   "<<balance<<endl;
}
void withdrawer(int withdrawAmount,int balance,int remaining){

     cout<<"Enter a withdraw amount "<<endl;
        cin>>withdrawAmount;
        if(withdrawAmount > balance){
            cout<<"Insuficient balance "<<endl;}
        else {
            remaining = balance - withdrawAmount;
            }
        cout<<"You have withdraw this amount "<<withdrawAmount<<" Your remaing balance is "<<remaining<<endl;
}