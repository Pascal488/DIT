#include <iostream>
using namespace std;
  //Required to find a sum of numbers ranging from m to n

int main(){
    int k,sum = 0,m=2,n=6;
  
  
    for(k = m; k <=n;k++){
      sum = sum + k;
    }
  
  cout<<"The sum of numbers ranging from 2 to 6 is "<<sum<<endl;
  
  //for first iteration
  // k will be equal to m and m = 2,so k = 2 so the iteration will start from 2
  //So in the loop (k = 2 k<=6)? the statement is true so the block of code {sum = sum + k }will be executed
  //where values of sum is sum = 0,so it will be 0 = 0 + 2 
  
  //for second iteration
  //So in the loop (k = 3 ;k<=6)? the statement is true so the block of code {sum = sum + k }will be executed
  //where value of sum is sum = 0,so it will be 0 = 0 + 3 
  
   //for third iteration
  //So in the loop (k = 4 ;k<=6)? the statement is true so the block of code {sum = sum + k }will be executed
  //where value of sum is sum = 0,so it will be 0 = 0 + 4
  
   //for fouth iteration
  // k will be equal to m and m = 2,so k = 2 so the iteration will start from 2
  //So in the loop (k = 5; k<=6)? the statement is true so the block of code {sum = sum + k }will be executed
  //where value of sum is sum = 0,so it will be 0 = 0 + 5 
  
   //for fifth iteration
  // k will be equal to m and m = 2,so k = 2 so the iteration will start from 2
  //So in the loop (k = 6;k<=6)? the statement is true so the block of code {sum = sum + k }will be executed
  //where value of sum is sum = 0,so it will be 0 = 0 + 6
  
  
  
  
  
  
    
  
}
