using System;

namespace CSharpcourse
{
    class Program
    {
        static void Main(String[] args) {
            //BasicsCodingExcersise();
            //BasicsHomeworkA();
            //BasicsHomeworkB();
            //BasicsHomeworkGeronFormula();
            //BasicsHomeworkProfile();
            //FlowHomeworkFindMaximum();            
            //FibonachiHomework();
            //averagehomework();
            //factorialhomework();
            authenticationhomework()

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
        static void BasicsHomeworkGeronFormula()
        {
            Console.WriteLine("SizeA");
            int sizeA = int.Parse(Console.ReadLine());
            Console.WriteLine("SizeB");
            int sizeB = int.Parse(Console.ReadLine());
            Console.WriteLine("SizeC");
            int sizeC = int.Parse(Console.ReadLine());

            if (sizeA < sizeB + sizeC && sizeB < sizeA + sizeC && sizeC < sizeA + sizeB)
            {
                double p;
                p = (double) 1 / (double) 2 * ((double) sizeA + (double) sizeB + (double) sizeC);
                Console.WriteLine(p);
                Double TriangleSize = (double) Math.Sqrt(p * (p - (double) sizeA) * (p - (double) sizeB) * (p - (double) sizeC));
            }
            else
            {
                Console.WriteLine("wrong sizes - one side cannot be longer than sum of two others");
            }

        }
        static void BasicsHomeworkProfile()
        {
            Console.WriteLine("First Name");
            string Fname = Console.ReadLine();
            Console.WriteLine("Last Name");
            string Lname = Console.ReadLine();
            Console.WriteLine("Age");
            string Age = Console.ReadLine();
            Console.WriteLine("Weight");
            double Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Height in sentimeters");
            double Height = double.Parse(Console.ReadLine()) / 100;
            double imt = (double) Weight / (double) Math.Pow(Height, 2);            
            Console.WriteLine($"Your profile\nFull Name: {Lname + ',' + Fname}\nAge: {Age}\nWeight: {Weight}\nHeight: {Height}\nBody Mass Index: {imt}");

        }
        static void FlowHomeworkFindMaximum()
        {
            Console.WriteLine("Value 1");
            int Value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value 2");
            int Value2 = int.Parse(Console.ReadLine());

            bool BoolValue1 = Value1 > Value2;
            bool BoolValue2 = Value1 < Value2; 
            bool BoolEqual = Value1 == Value2;

            if (BoolValue1) 
            {
                Console.WriteLine("Value1");
            }
            else if (BoolValue2)
            {
                Console.WriteLine("Value2");
            }
            else if (BoolEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("fuck off");
            }
        }
        static void FibonachiHomework()
        {
            Console.WriteLine("how many?");
            int FibonachiNumbers = int.Parse(Console.ReadLine());            
            int previous = 0;
            int current = 1;
            int newest = 0;
            for (int i = 0; i < FibonachiNumbers; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{current} ");
                }
                newest = current + previous;
                previous = current;
                current = newest;
                Console.Write($"{newest} ");
            }
        }
        static void averagehomework()
        {
            int intno = 0;
            bool enough = intno == 0;
            int count = 0;
            double total = 0;
            while (true)
            {
                
                Console.WriteLine("give me some integer");
                intno = int.Parse(Console.ReadLine());
                if (intno == 0)
                {
                    break;
                }                    
                total = (double) total + (double) intno;                
                count += 1;
            }
            Console.WriteLine($"Average is: {total = (double) total / (double) count}");

        }
        static void factorialhomework()
        {
            int intno = 0;
            int fact = 1;
            string check;
            
            while (true)
            {
                fact = 1;
                Console.WriteLine("give me some integer");
                check = Console.ReadLine();
                if (check == "bye")
                {
                    break;
                }
                intno = int.Parse(check);
                
                for (int i = intno; i > 0; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"Factorial is: {fact}");
            }
            
        }
        static void authenticationhomework()
        {

        }


    }
    
}