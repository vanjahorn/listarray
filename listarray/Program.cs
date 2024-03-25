using System;
using System.Diagnostics.CodeAnalysis;

namespace listarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testTal = { 1, 2, 3 };

            string[] names = { "Anna", "Bertil", "Cesar" };
            Console.WriteLine("Demonstration av Contains:");
            Console.WriteLine("Contains(Bertil): " + Contains(names, "Bertil"));
            Console.WriteLine("Contains(David): " + Contains(names, "David"));

            // Summan
            Console.WriteLine("Demonstration av Summan:");
            Console.WriteLine("Summan av " + string.Join(", ", testTal) + " är: " + Summan(testTal));

            // Största talet
            Console.WriteLine();
            Console.WriteLine("Demonstration av Största talet:");
            Console.WriteLine("Största talet av 1, 2, 3 är: " + Störst(testTal));

            // Swap

            // Demonstration av Swap

            int[] swapTestData = { 8, 4, 6, 9, 2, 7, 3 };
            Console.WriteLine();
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: element på index 2: " + swapTestData[2]); // 6
            Console.WriteLine("Före: element på index 5: " + swapTestData[5]); // 7
            Swap(2, 5, swapTestData); // ska fungera med olika index
            Console.WriteLine("Efter: element på index 2: " + swapTestData[2]); // 7
            Console.WriteLine("Efter: element på index 5: " + swapTestData[5]); // 6


            // Concatenate
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));

            // Reverse
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
            Console.WriteLine();


        }

        public static int Summan(int[] listOfNumbers)
        {
            int sum = 0;
            foreach (int num in listOfNumbers)
            {
                sum += num;
            }
            return sum;
        }

        public static int Störst(int[] listOfNumbers)
        {
            int störst = listOfNumbers[0];

            foreach (int num in listOfNumbers)
            {
                if (num > störst)
                {
                    störst = num;
                }
            }

            return störst;
        }

        public static bool Contains(string[] names, string name)
        {
            foreach (string i in names)
            {
                if (i == name) return true;
            }
            return false;
        }

        public static void Swap(int index1, int index2, int[] intArray)
        {
            // Byt plats på elementen
            int swap = intArray[index1];
            intArray[index1] = intArray[index2];
            intArray[index2] = swap;
        }

        public static string[] Concatenate(string[] part1, string[] part2)
        {
            string[] blah = new string[part1.Length + part2.Length];

            for (int i = 0; i < part1.Length; i++)
            {
                blah[i] = part1[i];
            }
            for (int i = 0; i < part2.Length; i++)
            {
                blah[part1.Length + i] = part2[i];
            }

            return blah;
        }

        public static void Reverse(int[] numbers)
        {

        }






    }
}
