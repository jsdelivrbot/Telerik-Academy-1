﻿using System;

//A marketing company wants to keep record of its employees. 
//Each record would have the following characteristics:
//•First name
//•Last name
//•Age (0...100)
//•Gender (m or f)
//•Personal ID number (e.g. 8306112507)
//•Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. 
//Print the data at the console.


class EmployeeData
{
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte age = 50;
            char gender = 'm';
            string personalId = "8306112507";
            int employeeId = 27560020;

            Console.WriteLine("First name : " + firstName );
            Console.WriteLine("Last name : " + lastName);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Personal Id : " + personalId);
            Console.WriteLine("Employee Id : " + employeeId);
        }
}
