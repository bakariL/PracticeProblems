using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            fullName = "Bakari Lewis";
            string car;
            car = "s550";
            string book;
            book = "Batman";

            //Console.WriteLine("My name is " + fullName);
            //Console.WriteLine("My favorite car is " + car);
            //Console.WriteLine("My favorite comic book is " + book);

            double valueOne;
            double valueTwo;
            //7 total cups. She has 2. How many more cups does she need to put in?
            valueOne = 7;
            valueTwo = 2;
            Console.WriteLine(valueOne - valueTwo);

            //Mike and his 3 friends divide the bill evenly. Each person paid $3. What was total bill?
            valueOne = 4;
            valueTwo= 3;
            Console.WriteLine(valueOne - valueTwo);
            //How many packages of diapers can you biu w/$40 if one package cose $8? 
            valueOne = 40;
            valueTwo = 8;
            Console.WriteLine(valueOne / valueTwo);
            //Trevon had $20. Now has $41.How much money did he recieve?
            valueOne = 41;
            valueTwo = 20;
            Console.WriteLine(valueOne - valueTwo);
            //Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            valueOne = 47;
            valueTwo = 30;
            Console.WriteLine(valueOne - valueTwo);
            //how many boxes of envelopes can you buy with $12 if one costs
            valueOne = 12;
            valueTwo = 3;
            Console.WriteLine(valueOne / valueTwo);
            //After paying $5.12, noracach has $27.10. How much money did he have before buying the salad?
            valueOne = 27.10;
            valueTwo = 5.12;
            Console.WriteLine(valueOne + valueTwo);


        }
    }
}
