using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfCash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggSinglePrice = double.Parse(Console.ReadLine());
            double berriesKiloPrice = double.Parse(Console.ReadLine());
            double berriesPriceForOneSet = berriesKiloPrice * 0.2;

            double neededSets = Math.Ceiling((double)guests / 6);
            double neededCash = (neededSets * (2 * bananasPrice)) +
                (neededSets * (4 * eggSinglePrice)) + (neededSets * berriesPriceForOneSet);

            if (neededCash <= amountOfCash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", neededCash);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededCash - amountOfCash);
            }
        }
    }
}
