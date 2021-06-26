using System;  

  public class PrimeNumberExample {  
     public static void Main(string[] args) {  
        int i, flag = 0;    
        Console.Write("Enter a number to check if prime: ");
        int num = Convert.ToInt32(Console.ReadLine()); 

        int middle = num / 2;

        if (num == 0 || num == 1) {
          Console.Write("{0} is not prime.", num);
        }else {
          for(i = 2; i <= middle; i++) { 
            if (num % i == 0) {
              Console.Write("{0} is not prime.", num);
              flag = 1;    
              break;    
            }    
          }    
          if (flag == 0){
          Console.Write("{0} is prime.", num);
          }
        }
      }
    }