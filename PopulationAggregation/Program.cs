using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopulationAggregation // from Programming Fundamentals Sample Exam I - June 2016 
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> citiesCount = new SortedDictionary<string, int>();
            Dictionary<string, long> citiesPopulation = new Dictionary<string, long>();
            string input = Console.ReadLine();
            string[] prohibbitedSymbols = new string[] { "@", "#", "$", "&", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            while (!input.Equals("stop"))
            {
                string[] inputSplitted = input.Split('\\').ToArray();
                for (int i = 0; i < prohibbitedSymbols.Length; i++)
                {
                    inputSplitted[0] = inputSplitted[0].Replace(prohibbitedSymbols[i], "");
                    inputSplitted[1] = inputSplitted[1].Replace(prohibbitedSymbols[i], "");
                }
                string city;
                string country;
                if (char.IsUpper(inputSplitted[0][0]))
                {
                    country = inputSplitted[0];
                    city = inputSplitted[1];
                }
                else
                {
                    country = inputSplitted[1];
                    city = inputSplitted[0];
                }
                long population = long.Parse(inputSplitted[2]);
                if (!citiesCount.ContainsKey(country))
                {
                    citiesCount[country] = 1;
                }
                else
                {
                    citiesCount[country] += 1;
                }
                citiesPopulation[city] = population;
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int>pair in citiesCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
            foreach (KeyValuePair<string, long> pair in citiesPopulation.OrderByDescending(a => a.Value).Take(3))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
