using System;
using Xunit;

namespace MyApp.Tests
{
    public class LeapYearTest
    {
    
    LeapYearClass leapYearClass = new LeapYearClass();

        [Fact]
        public void divisble_by_four()
        {

            //Arrange
            bool testFour, testSeven;

        
            //Act
            testFour = leapYearClass.isDivisbleByFour(4);
            testSeven = leapYearClass.isDivisbleByFour(7);


            //Assert
            Assert.Equal(true, testFour);
            Assert.Equal(false, testSeven);
        }

        public void divisble_by_hundred(){

            //Arrange
            bool testTwoHundred;


            //Act
            testTwoHundred = leapYearClass.isDivisbleByHundred(200);

            //Assert
            Assert.Equal(true, testTwoHundred);
        }

        public void divisble_by_fourHundred(){

            //Arrange
            bool testSixteenHundred, testSeventeenHundred;

            //Act
            testSixteenHundred = leapYearClass.isDivisbleByFourHundred(1600);
            testSeventeenHundred = leapYearClass.isDivisbleByFourHundred(1700);

            //Assert
            Assert.Equal(true, testSixteenHundred);
            Assert.Equal(false, testSeventeenHundred);

        }

        public void is_leap_year(){
            
            //Arrange
            bool year2021, year2024, year1600, year1700;

            //Act
            year2021 = leapYearClass.isLeapYear(2021);
            year2024 = leapYearClass.isLeapYear(2024);
            year1600 = leapYearClass.isLeapYear(1600);
            year1700 = leapYearClass.isLeapYear(1700);

            //Assert
            Assert.Equal(false, year2021);
            Assert.Equal(true, year2024);
            Assert.Equal(true, year1600);
            Assert.Equal(false, year1700);

        }
    }
}
