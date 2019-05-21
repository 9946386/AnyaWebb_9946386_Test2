using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2 //Anya Webb 9946386
{
    class Program //Program to calculate what staff members will be paid during 2019
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the staff payroll system"); //Intro
            Console.WriteLine("Enter 1 to display Salary");
            Console.WriteLine("Enter 2 to display Wages");
            Console.Write("Enter option: "); //Asking person to select an option
            int option = int.Parse(Console.ReadLine()); //Creating option to store variable
            Console.Write("\n\n"); //Adding 2 clear lines

            if (option == 1) //If statement to display Salary if option 1 is selected
            {
                Salary salary1 = new Salary(); //Creating the salary object
                Console.WriteLine(salary1.DisplaySalary()); //Calling the method to display the weekly salary.
                Console.ReadLine();
            }
            
            else if(option == 2) //Else if to display Wages if 2 is selected
            {
                Wages wages1 = new Wages(); //Creating the wages object
                Console.Write("Enter the amount of hours worked: "); //Asking for hours worked
                int hours = int.Parse(Console.ReadLine()); //Setting the variable
                Console.WriteLine(wages1.DisplayWages(hours)); //Calling the method to display wages
                Console.ReadLine();
            }

            else //Else to display if anything other than 1 or 2 is entered
            {
                Console.WriteLine("Sorry, that was not an option");
                Console.ReadLine();
            }
            
        }
    }

    class Salary //To show annual and weekly salary
    {
        double annualSalary = 80000; //Setting annual salary at 80000
        double weeklySalary;
                              
        //Method to display weekly salary
        public string DisplaySalary()
        {
            return $"Your salary per week is: ${Math.Round(annualSalary / 52),2}";            
        }   //Math.Round used to round the amount to 2 decimal places

        //Constructor to display message and annual salary
        public Salary()
        {
            Console.WriteLine("Your salary is set at {0} per year",annualSalary);
        }
    }

    class Wages //To calculate weekly wages
    {
        double hourlyRate = 33.72; //Setting hourly rate to 33.72
        double weeklyWages;
        int numHours; //Changes colours because it has gone from public to private

        //Getters and setters to access and set number of hours
        public int NumHours { get { return numHours; } set { numHours = value; } }
        
        //Constructor to display message
        public Wages()
        {
            Console.WriteLine("I will calculate your wages");
        }

        //Method to calculate weekly wages
        public string DisplayWages(int _hours)
        {
            return $"Your wages per week is: ${Math.Round(hourlyRate * _hours),2}";
            //Math.Round used to round to 2 decimal places.
        }


    }
}
