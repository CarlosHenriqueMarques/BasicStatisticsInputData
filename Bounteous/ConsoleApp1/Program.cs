using BounteousApp;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome to Bounteous assignment, please enter a list of number split by,\n For instance, 5,8,6\n");
            string line = Console.ReadLine();
            List<string> inputList = new(line.Split(','));
            
            // setup
            List<int> listToCalculate = new();
            int erros = 0;
            Calculator calc = new();

            // functions
            CheckInputEmptyOrNull(line);
            (erros, listToCalculate) = calc.ValuesValidation(inputList, listToCalculate, erros);
            double median = calc.GetMedian(listToCalculate);
            (int min, int max) = calc.GetMinMaxValue(listToCalculate);
            double average = calc.GetAverage(listToCalculate);

            // print
            Console.WriteLine($"Count : {inputList.Count}");
            Console.WriteLine($"Minimum : {min}");
            Console.WriteLine($"Maximum : {max}");
            Console.WriteLine($"Mean : {string.Format("{0:0.00}", average)}");
            Console.WriteLine($"Median : {string.Format("{0:0.00}", median)}");
            Console.WriteLine($"Erros : {erros}");
        }

        // Checking if the value can be computed.
        private static void CheckInputEmptyOrNull(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                Console.WriteLine("n/a");
                Environment.Exit(0);
            }
        }
    }
}
