using System;

namespace Varpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age = 21; 
            int year = 1997;
            string myHighSchool = "Ivanna Eudora Kean";
            int yearGraduated = 2016;
            string myMother = "Gracia";
            string myFather = "Kelvin";
            int credits = 13;
            string program = "ICS";
            string myFirstName = "Kiarra";
            string myLastName = "Vanterpool";
            //Purpose is to introduce myself and tell a little bit about myself.//
            Console.WriteLine("Hi! My name is "+ myFirstName + " " + myLastName +".");
            Console.WriteLine("I'm " + age + " years old. \n");
            Console.WriteLine("I went to "+ myHighSchool +  " and graduted "+ yearGraduated +".");
            Console.WriteLine("After that, I decided to come to NTID for college.");
            Console.WriteLine("Both my Mom "+ myMother + " and Dad "+ myFather + " thought NTID woudld be a great choice for me. ");
            Console.WriteLine("So, now I'm a student here at NTID/RIT. I'm in the " +  program + " taking " + credits + " credits. \n");
            Console.WriteLine("That's pretty crazy for someone who was born in " + year + ".");

        }
    }
}
