using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace FinalsProgramming
{
    internal class Program
    {

        static char userChoice2;
        static int userChoice1;
        static string userChoice3;
        static double value, result = 0;


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("This system is programmed by:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Happy P. Enciso");
            Console.WriteLine("BSIT 2-1");
            Console.WriteLine("----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            MainMenu();
        }


        static void MainMenu()
        {
            Console.WriteLine("\nWELCOME TO MATH ESSENTIALS SYSTEM\n");

            Console.WriteLine("_____________MAIN MENU_____________");
            Console.WriteLine("Enter 1 for Calculator");
            Console.WriteLine("Enter 2 for Money Currency");
            Console.WriteLine("Enter 3 for Converstion Table");
            Console.WriteLine("Enter 4 for Percentage");
            Console.WriteLine("Enter 5 to exit");

            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Choose: ");
            userChoice1 = Convert.ToInt32(Console.ReadLine());


            switch (userChoice1)
            {
                case 1: //calculator
                    userCalculator();
                    break;

                case 2: //money currency
                    userMoneyCurrency();
                    break;

                case 3: //conversion table
                    userConversionUnit();
                    break;

                case 4:
                    userPercentage();
                    break;

                case 5: //exit
                        //Console.WriteLine("under construction..");
                    askUserToExit();
                    break;
            }

        }

        static void userCalculator()
        {
            List<string> History = new List<string>();

            double num1, num2, answer = 0;
            char operation;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("___________BASIC CALCULATOR_____________");
            do
            {
                Console.WriteLine("\nEnter First Number: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter Second Number: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter Operation (+, -, *, / )");
                Console.ForegroundColor = ConsoleColor.Yellow;
                operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        answer = num1 + num2;
                        break;

                    case '-':
                        answer = num1 - num2;
                        break;

                    case '*':
                        answer = num1 * num2;
                        break;

                    case '/':
                        answer = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Incorrect Operation");
                        break;
                }
                string result = $"{num1}{operation}{num2} = {answer}";
                History.Add(result);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Answer: " + result);

                askUsertoContinue();


            } while (userChoice3 != "no");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nHere's the history of your transaction");
            foreach (string calculation in History)
            {
                Console.WriteLine(calculation);
            }
            Console.WriteLine("\nThank you for using calculator..");
            askUserToReturn();
        }



        static string askUserToReturn()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDo you want to return?? (Yes or No)");
            Console.ForegroundColor = ConsoleColor.White;
            userChoice3 = Console.ReadLine();
            while (userChoice3 != "yes")
            {
                Console.WriteLine("The system stay here");
                break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            MainMenu();
            return userChoice3;
        }

        
        static string askUsertoContinue()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDo you want to continue?? (Yes or No)");
            Console.ForegroundColor = ConsoleColor.White;
            userChoice3 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            return userChoice3;
        }

        static string askUserToExit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDo you want to exit?? (Yes or No)");
            Console.ForegroundColor = ConsoleColor.White;
            userChoice3 = Console.ReadLine();
            while (userChoice3 != "yes")
            {
                Console.WriteLine("The system stay here");
                MainMenu();
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("System exit...");

            return userChoice3;
        }



        static void userMoneyCurrency()
        {
            double peso, usa, europe, japan, southkorea, canada, australia, china, hongkong, england, thailand;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------PESO CURRENCY CONVERTER----------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            usa = peso * 0.018;
            europe = peso * 0.017;
            japan = peso * 2.41;
            southkorea = peso * 23.17;
            canada = peso * 0.024;
            australia = peso * 0.026;
            china = peso * 0.12;
            hongkong = peso * 0.14;
            england = peso * 0.015;
            thailand = peso * 0.62;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHere's the currency of your peso to other countries....\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("United states of America: " + usa);
            Console.WriteLine("Europe: " + europe);
            Console.WriteLine("Japan: " + japan);
            Console.WriteLine("South Korea: " + southkorea);
            Console.WriteLine("Canda: " + canada);
            Console.WriteLine("Australia: " + australia);
            Console.WriteLine("China: " + china);
            Console.WriteLine("HongKong: " + hongkong);
            Console.WriteLine("England: " + england);
            Console.WriteLine("Thailand: " + thailand);

            askUserToReturn();

        }

        static void userConversionUnit()
        {
            int measurement, length, time, weight, temperature;

            List<string> MeasurementChoices = new List<string>() { "Enter 1 for Length", "Enter 2 for Temperature", "Enter 3 for Weight", "Enter 4 for Time" };
            Console.WriteLine("\nWelcome to Conversion Program.........please select a category of your desired CONVERSION UNIT\n");
            foreach (var viewChoices in MeasurementChoices)
            {
                Console.WriteLine(viewChoices);
            }
            userChoice1 = Convert.ToInt32(Console.ReadLine());

            switch (userChoice1)
            {
                case 1:
                    List<string> Meter = new List<string>() { "Enter 1 for Meter", "Enter 2 for Kilometer", "Enter 3 for Milimeter", "Enter 4 for Centimeter" };
                    Console.WriteLine("\nPlease enter your measurement...\n");
                    foreach (var viewChoices in Meter)
                    {
                        Console.WriteLine(viewChoices);
                    }
                    measurement = Convert.ToInt32(Console.ReadLine());
                    switch (measurement)
                    {
                        case 1:
                            Console.WriteLine("Enter 1 for Meter to Kilometer");
                            Console.WriteLine("Enter 2 for Meter to Millimeter");
                            Console.WriteLine("Enter 3 for Meter to Centimeter");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.001;
                                    Console.WriteLine("The value of " + value + " Meter to Kilometer is " + result + "km");
                                    break;
                                case 2:
                                    result = value * 1000;
                                    Console.WriteLine("The value of " + value + " Meter to Millimeter is " + result + "mm");
                                    break;
                                case 3:
                                    result = value * 100;
                                    Console.WriteLine("The value of " + value + " Meter to Centimeter is " + result + "cm");
                                    break;
                            }

                            break;

                        case 2:
                            Console.WriteLine("Enter 1 for Kilometer to Meter");
                            Console.WriteLine("Enter 2 for Kilomerer to Millimeter");
                            Console.WriteLine("Enter 3 for Kilometer to Centimeter");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 1000;
                                    Console.WriteLine("The value of " + value + " Kilometer to meter is " + result + "m");
                                    break;
                                case 2:
                                    result = value * 1000000;
                                    Console.WriteLine("The value of " + value + " Kilometer to Millimeter is " + result + "mm");
                                    break;
                                case 3:
                                    result = value * 100000;
                                    Console.WriteLine("The value of " + value + " Kilometer to Centimeter is " + result + "cm");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter 1 for Millimeter to Meter");
                            Console.WriteLine("Enter 2 for Millimeter to Kilometer");
                            Console.WriteLine("Enter 3 for Millimeter to Centimeter");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.001;
                                    Console.WriteLine("The value of " + value + " Millimeter to meter is " + result + "m");
                                    break;
                                case 2:
                                    result = value * 0;
                                    Console.WriteLine("The value of " + value + " Millimeter to Kilometer is " + result + "km");
                                    break;
                                case 3:
                                    result = value * 0.1;
                                    Console.WriteLine("The value of " + value + " Millimeter to Centimeter is " + result + "cm");
                                    break;
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter 1 for Centimeter to Meter");
                            Console.WriteLine("Enter 2 for Centimeter to Kilometer");
                            Console.WriteLine("Enter 3 for Centimeter to Millimeter");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.001;
                                    Console.WriteLine("The value of " + value + " Centimeter to meter is " + result + "m");
                                    break;
                                case 2:
                                    result = value * 0;
                                    Console.WriteLine("The value of " + value + " Centimeter to Kilometer is " + result + "km");
                                    break;
                                case 3:
                                    result = value * 10;
                                    Console.WriteLine("The value of " + value + " Centimeter to Millimeter is " + result + "mm");
                                    break;
                            }

                            break;

                    }
                    break;

                case 2:
                    List<string> Temperature = new List<string>() { "Enter 1 for Celsius", "Enter 2 for Kelvin", "Enter 3 for Fahrenheit" };
                    foreach (var viewChoices in Temperature)
                    {
                        Console.WriteLine(viewChoices);
                    }
                    temperature = Convert.ToInt32(Console.ReadLine());
                    switch (temperature)
                    {
                        case 1:
                            Console.WriteLine("Enter 1 for Celsius to Kelvin");
                            Console.WriteLine("Enter 2 for Celsius to Fahrenheit");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value + 273.15;
                                    Console.WriteLine("The value of " + value + " Celsius to Kelvin is " + result + "K");
                                    break;
                                case 2:
                                    result = (value * 9 / 5) + 32;
                                    Console.WriteLine("The value of " + value + "  Celsius to Fahrenheit is " + result + "F");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter 1 for Kelvin to Celsius");
                            Console.WriteLine("Enter 2 for Kelvin to Fahrenheit");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value - 273.15;
                                    Console.WriteLine("The value of " + value + " Kelvin to Celsius is " + result + "C");
                                    break;
                                case 2:
                                    result = (value - 273.15) * 9 / 5 + 32;
                                    Console.WriteLine("The value of " + value + "  Kelvin to Fahrenheit is " + result + "F");
                                    break;
                            }

                            break;

                        case 3:
                            Console.WriteLine("Enter 1 for Fahrenheit to Celcius");
                            Console.WriteLine("Enter 2 for Fahrenheit to Kelvin");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = (value - 32) * 5 / 9;
                                    Console.WriteLine("The value of " + value + " Fahreinheit to Celsius is " + result + "C");
                                    break;
                                case 2:
                                    result = (value - 32) * 5 / 9 + 273.15;
                                    Console.WriteLine("The value of " + value + "  Fahreinheit to Kelvin is " + result + "K");
                                    break;
                            }
                            break;
                    }
                    break;

                case 3:
                    List<string> Weight = new List<string>() { "Enter 1 for Kilogram", "Enter 2 for gram", "Enter 3 for Milligram", "Enter 4 for Pound", "Enter 5 for Ounce" };
                    foreach (var viewChoices in Weight)
                    {
                        Console.WriteLine(viewChoices);
                    }
                    weight = Convert.ToInt32(Console.ReadLine());
                    switch (weight)
                    {
                        case 1:
                            Console.WriteLine("Enter 1 for kilogram to Gram");
                            Console.WriteLine("Enter 2 for kilogram to Milligram");
                            Console.WriteLine("Enter 3 for kilogram to Pound");
                            Console.WriteLine("Enter 4 for kilogram to Ounce");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 1000;
                                    Console.WriteLine("The value of " + value + "  Kilogram to Gram is " + result + "g");
                                    break;

                                case 2:
                                    result = value * 1000000000;
                                    Console.WriteLine("The value of " + value + "  Kilogram to Milligram is " + result + "mg");
                                    break;

                                case 3:
                                    result = value * 2.20462;
                                    Console.WriteLine("The value of " + value + "  Kilogram to Pound is " + result + "lb");
                                    break;

                                case 4:
                                    result = value * 35.27396;
                                    Console.WriteLine("The value of " + value + "  Kilogram to Ounce is " + result + "oz");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter 1 for gram to Kilogram");
                            Console.WriteLine("Enter 2 for gram to Milligram");
                            Console.WriteLine("Enter 3 for gram to Pound");
                            Console.WriteLine("Enter 4 for gram to Ounce");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.001;
                                    Console.WriteLine("The value of " + value + " Gram to Kilogram is " + result + "kg");
                                    break;

                                case 2:
                                    result = value * 1000;
                                    Console.WriteLine("The value of " + value + " Gram to Milligram is " + result + "mg");
                                    break;

                                case 3:
                                    result = value * 0.0022;
                                    Console.WriteLine("The value of " + value + " Gram to Pound is " + result + "lb");
                                    break;

                                case 4:
                                    result = value * 0.03527;
                                    Console.WriteLine("The value of " + value + " Gram to Ounce is " + result + "oz");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter 1 for milligram to Kilogram");
                            Console.WriteLine("Enter 2 for milligram to gram");
                            Console.WriteLine("Enter 3 for milligram to Pound");
                            Console.WriteLine("Enter 4 for milligram to Ounce");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.01778;
                                    Console.WriteLine("The value of " + value + " Milligram to Kilogram is " + result + "kg");
                                    break;

                                case 2:
                                    result = value * 17.777;
                                    Console.WriteLine("The value of " + value + " Milligram to Gram is " + result + "g");
                                    break;

                                case 3:
                                    result = value * 0.03919;
                                    Console.WriteLine("The value of " + value + " Milligram to Pound is " + result + "lb");
                                    break;

                                case 4:
                                    result = value * 0.62707;
                                    Console.WriteLine("The value of " + value + " Milligram to Ounce is " + result + "oz");
                                    break;
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter 1 for pound to Kilogram");
                            Console.WriteLine("Enter 2 for pound to Gram");
                            Console.WriteLine("Enter 3 for pound to Milligram");
                            Console.WriteLine("Enter 4 for pound to Ounce");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.45359;
                                    Console.WriteLine("The value of " + value + " Pound to Kilogram is " + result + "kg");
                                    break;

                                case 2:
                                    result = value * 453.59237;
                                    Console.WriteLine("The value of " + value + " Pound to Gram is " + result + "g");
                                    break;

                                case 3:
                                    result = value * 453592.37;
                                    Console.WriteLine("The value of " + value + " Pound to Milligram is " + result + "mg");
                                    break;

                                case 4:
                                    result = value * 16;
                                    Console.WriteLine("The value of " + value + " Pound to Ounce is " + result + "oz");
                                    break;
                            }
                            break;

                        case 5:
                            Console.WriteLine("Enter 1 for ounce to Kilogram");
                            Console.WriteLine("Enter 2 for ounce to Gram");
                            Console.WriteLine("Enter 3 for ounce to Milligram");
                            Console.WriteLine("Enter 4 for ounce to pound");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.02835;
                                    Console.WriteLine("The value of " + value + " Ounce to Kilogram is " + result + "kg");
                                    break;

                                case 2:
                                    result = value * 28.34952;
                                    Console.WriteLine("The value of " + value + " Ounce to Gram is " + result + "g");
                                    break;

                                case 3:
                                    result = value * 28349.52312;
                                    Console.WriteLine("The value of " + value + " Ounce to Milligram is " + result + "mg");
                                    break;

                                case 4:
                                    result = value * 0.0625;
                                    Console.WriteLine("The value of " + value + " Ounce to Pound is " + result + "lb");
                                    break;
                            }
                            break;
                    }
                    break;

                case 4:

                    Console.WriteLine("\nPlease enter your time.....\n");
                    Console.WriteLine("Enter 1 for Second");
                    Console.WriteLine("Enter 2 for Minute");
                    Console.WriteLine("Enter 3 for Hour");
                    Console.WriteLine("Enter 4 for Day");
                    Console.WriteLine("Enter 5 for Week");
                    Console.WriteLine("Enter 6 for Month");
                    Console.WriteLine("Enter 7 for Year");
                    time = Convert.ToInt32(Console.ReadLine());
                    switch (time)
                    {
                        case 1:
                            Console.WriteLine("Enter 1 for second to Minute");
                            Console.WriteLine("Enter 2 for second to Hour");
                            Console.WriteLine("Enter 3 for second to Day");
                            Console.WriteLine("Enter 4 for second to Week");
                            Console.WriteLine("Enter 5 for second to Month");
                            Console.WriteLine("Enter 6 for second to Year");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 0.017;
                                    Console.WriteLine("The value of " + value + " Second to Minute is " + result + "min");
                                    break;

                                case 2:
                                    result = value * 0.000277778;
                                    Console.WriteLine("The value of " + value + " Second to Hour is " + result + "h");
                                    break;

                                case 3:
                                    result = value * 1.1574e-5;
                                    Console.WriteLine("The value of " + value + " Second to Day is " + result + "d");
                                    break;

                                case 4:
                                    result = value * 1.6534e-6;
                                    Console.WriteLine("The value of " + value + " Second to Week is " + result + "wk");
                                    break;

                                case 5:
                                    result = value * 3.8052e-7;
                                    Console.WriteLine("The value of " + value + " Second to Month is " + result + "mon");
                                    break;

                                case 6:
                                    result = value * 3.171e-8;
                                    Console.WriteLine("The value of " + value + " Second to Year is " + result + "y");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter 1 for minute to Second");
                            Console.WriteLine("Enter 2 for minute to Hour");
                            Console.WriteLine("Enter 3 for minute to Day");
                            Console.WriteLine("Enter 4 for minute to Week");
                            Console.WriteLine("Enter 5 for minute to Month");
                            Console.WriteLine("Enter 6 for minute to Year");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 60;
                                    Console.WriteLine("The value of " + value + " Minute to Second is " + result + " s");
                                    break;

                                case 2:
                                    result = value * 0.017;
                                    Console.WriteLine("The value of " + value + " Minute to Hour is " + result + "h");
                                    break;

                                case 3:
                                    result = value * 0.001;
                                    Console.WriteLine("The value of " + value + " Minute to Day is " + result + "d");
                                    break;

                                case 4:
                                    result = value * 9.9206e-5;
                                    Console.WriteLine("The value of " + value + " Minute to Week is " + result + "wk");
                                    break;

                                case 5:
                                    result = value * 2.2831e-5;
                                    Console.WriteLine("The value of " + value + " Minute to Month is " + result + "mon");
                                    break;

                                case 6:
                                    result = value * 1.9026e-6;
                                    Console.WriteLine("The value of " + value + " Minute to Year is " + result + "y");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter 1 for hour to Second");
                            Console.WriteLine("Enter 2 for hour to Minute");
                            Console.WriteLine("Enter 3 for hour to Day");
                            Console.WriteLine("Enter 4 for hour to Week");
                            Console.WriteLine("Enter 5 for hour to Month");
                            Console.WriteLine("Enter 6 for hour to Year");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 3600;
                                    Console.WriteLine("The value of " + value + " Hour to Second is " + result + "s");
                                    break;

                                case 2:
                                    result = value * 60;
                                    Console.WriteLine("The value of " + value + " Hour to Minute is " + result + "min");
                                    break;

                                case 3:
                                    result = value * 0.042;
                                    Console.WriteLine("The value of " + value + " Hour to Day is " + result + "d");
                                    break;

                                case 4:
                                    result = value * 0.006;
                                    Console.WriteLine("The value of " + value + " Hour to Week is " + result + "wk");
                                    break;

                                case 5:
                                    result = value * 0.001;
                                    Console.WriteLine("The value of " + value + " Hour to Month is " + result + "mon");
                                    break;

                                case 6:
                                    result = value * 0.000114155;
                                    Console.WriteLine("The value of " + value + " Hour to Year is " + result + "y");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter 1 for day to Second");
                            Console.WriteLine("Enter 2 for day to Minute");
                            Console.WriteLine("Enter 3 for day to Hour");
                            Console.WriteLine("Enter 4 for day to Week");
                            Console.WriteLine("Enter 5 for day to Month");
                            Console.WriteLine("Enter 6 for day to Year");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 86400;
                                    Console.WriteLine("The value of " + value + " Day to Second is " + result + "s");
                                    break;

                                case 2:
                                    result = value * 1440;
                                    Console.WriteLine("The value of " + value + " Day to Minute is " + result + "min");
                                    break;

                                case 3:
                                    result = value * 24;
                                    Console.WriteLine("The value of " + value + " Day to Hour is " + result + "h");
                                    break;

                                case 4:
                                    result = value * 0.143;
                                    Console.WriteLine("The value of " + value + " Day to Week is " + result + "wk");
                                    break;

                                case 5:
                                    result = value * 0.033;
                                    Console.WriteLine("The value of " + value + " Day to Month is " + result + "mon");
                                    break;

                                case 6:
                                    result = value * 0.003;
                                    Console.WriteLine("The value of " + value + " Day to Year is " + result + "y");
                                    break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter 1 for week to Second");
                            Console.WriteLine("Enter 2 for week to Minute");
                            Console.WriteLine("Enter 3 for week to Hour");
                            Console.WriteLine("Enter 4 for week to Day");
                            Console.WriteLine("Enter 5 for week to Month");
                            Console.WriteLine("Enter 6 for week to Year");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 604800;
                                    Console.WriteLine("The value of " + value + " Week to Second is " + result + "s");
                                    break;

                                case 2:
                                    result = value * 10080;
                                    Console.WriteLine("The value of " + value + " Week to Minute is " + result + "min");
                                    break;

                                case 3:
                                    result = value * 168;
                                    Console.WriteLine("The value of " + value + " Week to Hour is " + result + "h");
                                    break;

                                case 4:
                                    result = value * 7;
                                    Console.WriteLine("The value of " + value + " Week to Day is " + result + "d");
                                    break;

                                case 5:
                                    result = value * 0.23;
                                    Console.WriteLine("The value of " + value + " Week to Month is " + result + "mon");
                                    break;

                                case 6:
                                    result = value * 0.019;
                                    Console.WriteLine("The value of " + value + " Week to Year is " + result + "y");
                                    break;
                            }
                            break;
                        case 6:
                            Console.WriteLine("Enter 1 for month to Second");
                            Console.WriteLine("Enter 2 for month to Minute");
                            Console.WriteLine("Enter 3 for month to Hour");
                            Console.WriteLine("Enter 4 for month to Day");
                            Console.WriteLine("Enter 5 for month to Week");
                            Console.WriteLine("Enter 6 for month to Year");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 2628000;
                                    Console.WriteLine("The value of " + value + " Month to Second is " + result + "s");
                                    break;

                                case 2:
                                    result = value * 43800;
                                    Console.WriteLine("The value of " + value + " Month to Minute is " + result + "min");
                                    break;

                                case 3:
                                    result = value * 730;
                                    Console.WriteLine("The value of " + value + " Month to Hour is " + result + "h");
                                    break;

                                case 4:
                                    result = value * 30.417;
                                    Console.WriteLine("The value of " + value + " Month to Day is " + result + "d");
                                    break;

                                case 5:
                                    result = value * 4.345;
                                    Console.WriteLine("The value of " + value + " Month to Week is " + result + "wk");
                                    break;

                                case 6:
                                    result = value * 0.083;
                                    Console.WriteLine("The value of " + value + " Month to Year is " + result + "y");
                                    break;
                            }
                            break;
                        case 7:
                            Console.WriteLine("Enter 1 for year to Second");
                            Console.WriteLine("Enter 2 for year to Minute");
                            Console.WriteLine("Enter 3 for year to Hour");
                            Console.WriteLine("Enter 4 for year to Day");
                            Console.WriteLine("Enter 5 for year to Week");
                            Console.WriteLine("Enter 6 for year to Month");
                            GetFormula();
                            switch (userChoice1)
                            {
                                case 1:
                                    result = value * 31536000;
                                    Console.WriteLine("The value of " + value + " Year to Second is " + result + "s");
                                    break;

                                case 2:
                                    result = value * 525600;
                                    Console.WriteLine("The value of " + value + " Year to Minute is " + result + "min");
                                    break;

                                case 3:
                                    result = value * 8760;
                                    Console.WriteLine("The value of " + value + " Year to Hour is " + result + "h");
                                    break;

                                case 4:
                                    result = value * 365;
                                    Console.WriteLine("The value of " + value + " Year to Day is " + result + "d");
                                    break;

                                case 5:
                                    result = value * 52.143;
                                    Console.WriteLine("The value of " + value + " Year to Week is " + result + "wk");
                                    break;

                                case 6:
                                    result = value * 12;
                                    Console.WriteLine("The value of " + value + " Year to Month is " + result + "m");
                                    break;
                            }
                            break;


                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input.....please try again");
                    break;

            }

            askUserToReturn();
        }

        static void userPercentage()
        {
            List<string> history = new List<string>();
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n********** PERCENTAGE CALCULATOR **********\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter a number");
                Console.ForegroundColor = ConsoleColor.Red;
                double number = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter a percentage");
                Console.ForegroundColor = ConsoleColor.Red;
                double percentage = Convert.ToDouble(Console.ReadLine());

                double result = number * (percentage / 100);

                //Console.WriteLine(percentage + " % of " + number + " is " + result);
                Console.ForegroundColor = ConsoleColor.Yellow;
                string answer = $"{percentage}% of {number} is {result}";
                history.Add(answer);
                Console.WriteLine(answer);

                askUsertoContinue();
            } while (userChoice3 != "no");
            Console.WriteLine("\nHere's the history of your transaction");
            foreach (string percentage in history)
            {
                Console.WriteLine(percentage);
            }
            askUserToReturn();
        }

        static void GetFormula()
        {
            userChoice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your value: ");
            value = Convert.ToDouble(Console.ReadLine());

            //testing
        }
    }
}

