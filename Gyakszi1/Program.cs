using System;

namespace Gyakszi1
{
    class Program
    {
        private static void f1(string label)
        {
            Console.Write(label);            
            Console.WriteLine("\n\n1.");
            int firstNumber = 5;
            int secondnumber = 5;
            if (firstNumber == secondnumber)
            {
                Console.WriteLine("firstNum is equals to secondnum");
            }

            
        }
        private static void f2(string label)
        {
            int num1, rem1;
            Console.WriteLine("\n\n2.");
            Console.WriteLine("Check whether a number is even or odd :\n");
            Console.WriteLine("Input an integer:");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine("{0} is an even integer.\n", num1);
            }
            else Console.WriteLine("{0} is an odd number.", num1);
        }
        
            private static void sortingF1(string label)
            {
                Console.WriteLine("\n\nsorting f1:");
                int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                int n;

                n = arr.Length;
                Console.WriteLine("Original Array Elements:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                for (int i = 0; i < arr.Length-1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            int tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                }
                Console.WriteLine("\nSorted array elements:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        private static void InputOutput(string lalbel)
        {
            Console.WriteLine("\n\n String 1. :");
            Console.Write("Input the string: ");
            string inString = Console.ReadLine();
            string outString=inString;

            Console.WriteLine(outString);
        }
        static void LengthOfString(string label)
        {
            Console.WriteLine("\n\n String 2. :");
            Console.Write("Input the string: ");
            string inString = Console.ReadLine();

            Console.WriteLine("Length of the string is: " + inString.Length);
        }
            
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n\n\n");
            f1("1. feladat");
            f2("2.f");
            sortingF1("ShellSort");
            InputOutput("String1.");
            LengthOfString("lengthofString");
            



            Console.ReadKey();
        }
        
    }
}
