using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            //Max heart Rate//
            int heart_rate;
         
            age = 26;
            height = 153;
            heart_rate = 220 - age;
            Console.WriteLine("I am " + age + " old, my max heart rate is " + heart_rate + " and I am " + height + " cms tall.");


        }
    }
}
