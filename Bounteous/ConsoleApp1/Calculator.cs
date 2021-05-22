using System;
using System.Collections.Generic;
using System.Linq;

namespace BounteousApp
{
    public class Calculator
    {
        // Check if the values is integer AND positive if not should be add Erros 
        public (int erros, List<int> listToCalculate) ValuesValidation(List<string> inputList, List<int> listToCalculate, int erros)
        {
            int operatorNum = -1;
            foreach (var item in inputList)
            {
                // Checking if is not a integer
                if (!int.TryParse(item, out operatorNum))
                {
                    erros++;
                }
                else
                {
                    // Convert and check if it is positive
                    var number = Convert.ToInt32(item);
                    if (number < 0)
                    {
                        erros++;
                    }
                    else
                    {
                        listToCalculate.Add(number);
                    }

                }
            }
            return (erros, listToCalculate);
        }

        // Calculate the median value
        public double GetMedian(List<int> listToCalculate)
        {
            double median = 0;
            if (listToCalculate.Count > 0)
            {
                //sort array
                listToCalculate.Sort();
                //get the median
                int size = listToCalculate.Count;
                int mid = size / 2;
                // formula: (size % 2 != 0) ? listToCalculate[mid] : (listToCalculate[mid] + (double)listToCalculate[mid - 1]) / 2
                median = Math.Round(size % 2 != 0 ? listToCalculate[mid] : (listToCalculate[mid] + (double)listToCalculate[mid - 1]) / 2, 2, MidpointRounding.AwayFromZero);
            }

            return median;
        }

        public (int min, int max) GetMinMaxValue(List<int> listToCalculate)
        {
            int min = 0;
            int max = 0;
            if (listToCalculate.Count > 0)
            {
                min = listToCalculate.Min();
                max = listToCalculate.Max();
            }
            return (min, max);
        }

        public double GetAverage(List<int> listToCalculate)
        {
            double average = 0;
            if (listToCalculate.Count > 0)
            {
                average = listToCalculate.Average();
            }
            return average;
        }
    }
}
