using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalAmountWater = int.Parse(Console.ReadLine());
            List<double> bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int bottleCapacity = int.Parse(Console.ReadLine());
            double amountBeginning = totalAmountWater;

            List<int> remainingBottlesIndexes = new List<int>();
            double haveToFill = 0;
            double haveToFillTotal = 0;

            if (totalAmountWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {
                    haveToFill = bottleCapacity - bottles[i];
                    if (totalAmountWater == 0)
                    {
                        haveToFillTotal += haveToFill;
                    }

                    else if (haveToFill >= totalAmountWater)
                    {
                        bottles[i] += totalAmountWater;
                        haveToFillTotal += haveToFill;
                        totalAmountWater = 0;
                    }
                    else
                    {
                        bottles[i] += haveToFill;
                        haveToFillTotal += haveToFill;
                        totalAmountWater -= haveToFill;
                    }
                }
                for (int i = 0; i < bottles.Count; i++)
                {
                    if (bottles[i] < bottleCapacity)
                    {
                        remainingBottlesIndexes.Add(i);
                    }
                }
            }

            else
            {
                for (int i = bottles.Count-1; i > -1; i--)
                {
                    haveToFill = bottleCapacity - bottles[i];
                    if (totalAmountWater == 0)
                    {
                        haveToFillTotal += haveToFill;
                    }

                    else if (haveToFill >= totalAmountWater)
                    {
                        bottles[i] += totalAmountWater;
                        haveToFillTotal += haveToFill;
                        totalAmountWater = 0;
                    }
                    else
                    {
                        bottles[i] += haveToFill;
                        haveToFillTotal += haveToFill;
                        totalAmountWater -= haveToFill;
                    }
                }
                for (int i = bottles.Count - 1; i > -1; i--)
                {
                    if (bottles[i] < bottleCapacity)
                    {
                        remainingBottlesIndexes.Add(i);
                    }
                }

            }
            if (amountBeginning >= haveToFillTotal)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {amountBeginning - haveToFillTotal}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {remainingBottlesIndexes.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", remainingBottlesIndexes)}");
                Console.WriteLine($"We need {haveToFillTotal - amountBeginning} more liters!");
            }
        }
    }
}
