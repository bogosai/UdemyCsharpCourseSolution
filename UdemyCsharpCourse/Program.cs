using System;

namespace CSharpcourse
{
    class Program
    {
        static void Main(String[] args) {
            //BasicsCodingExcersise();
            //BasicsHomeworkA();
            BasicsHomeworkB();
        }
        static void CodingExcersise() {
            string name = "john snow";
            int age = 29;
            Console.WriteLine($"his name is {name} and he is {age} years old");
            string name2 = "alexey";
            int age2 = 45;
            int difference = age2 - age;
            Console.WriteLine($"...while his name is {name2}, he is {age2} year old, which is {difference} years older");

        }
        static void BasicsHomeworkA() {
            Console.WriteLine("What is his name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        static void BasicsHomeworkB()
        {
            Console.WriteLine("Give me any integer number");
            int IntegerNumber = int.Parse(Console.ReadLine());
            string IntegerNumberLength = IntegerNumber.ToString();
            Console.WriteLine($"The length of your number is {IntegerNumberLength.Length}");

        }
    }
}