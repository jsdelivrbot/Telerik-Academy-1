﻿using System;
/*
Write a program that prints to the console which day of the week is today. Use  System.DateTime .
 */
class DayOfWeek
{
   static void Main()
    {
        DateTime today = DateTime.Today;
        string dayToday = today.DayOfWeek.ToString();
        Console.WriteLine(dayToday);
    }
}
