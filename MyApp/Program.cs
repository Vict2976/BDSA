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
            }else if (isDivisbleByFourHundred(year) && !isDivisbleByHundred(year)){
                return true;
            }else{
                return false;
            }
        }
   
    }

    public class Program{
        
        public static void Main(string[] args){
            LeapYearClass leapYearClass = new LeapYearClass();

            
        }        
    }
}
