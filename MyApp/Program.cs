using System;

namespace MyApp
{
    public class LeapYearClass
    {

        public bool isDivisbleByFour(int year){
            if (year % 4 == 0){
                return true;
            }else{
                return false;
            }
        }

        public bool isDivisbleByHundred(int year){
            if(year % 100 == 0){
                return true;
            }else{
                return false;
            }

        }

        public bool isDivisbleByFourHundred(int year){
            if(year % 400 == 0){
                return true; 
            }else {
                return false;
            }
        }

        public bool isLeapYear(int year){
            if (isDivisbleByFour(year) && !isDivisbleByHundred(year)){
                return true;
            }else if (isDivisbleByFourHundred(year)){
                return true;
            }else{
                return false;
            }
        }

        
        public void readUserInput(int userInput){
            if (userInput > 1581){
                if (isLeapYear(userInput)){
                    Console.WriteLine("Yay");
                }else{
                    Console.WriteLine("Nay");
                }
            }else{
                Console.WriteLine("Type a year from 1582 and above");
            }
        }
   
    }

    public class Program{
        
        public static void Main(string[] args){
            LeapYearClass leapYearClass = new LeapYearClass();
            Console.WriteLine("Hello! Please type in a year, and hit Enter!");
            try{
                leapYearClass.readUserInput(Convert.ToInt32(Console.ReadLine()));
            }catch (System.FormatException){
                Console.WriteLine("please try again, and this time input a number!");
            }
            
        }        
    }
}
