using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> sequence = Console.ReadLine().Split().Select(long.Parse).ToList();
            string command = Console.ReadLine();
            while (!command.Equals("end"))
            {
                string[] splitted = command.Split(' ').ToArray();
                string action = splitted[0];
                switch (action)
                {
                    case "swap":
                        string first = splitted[1]; string second = splitted[2]; Swap(sequence, first, second);break;
                    case "multiply": string firstM = splitted[1]; string secondM = splitted[2]; Multiply(sequence, firstM, secondM); break;
                    case "decrease": Decrease(sequence); break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", sequence));
        }
        static void Swap(List<long> sequence, string first, string second)
        {
            int firstIndex = int.Parse(first);
            int secondIndex = int.Parse(second);
            long firstNumber = sequence[secondIndex];
            long secondNumber = sequence[firstIndex];
            sequence.RemoveAt(firstIndex);
            sequence.Insert(firstIndex, firstNumber);
            sequence.RemoveAt(secondIndex);
            sequence.Insert(secondIndex, secondNumber);          
        }
        static void Multiply(List<long> sequence, string first, string second)
        {
            int firstIndex = int.Parse(first);
            int secondIndex = int.Parse(second);
            long firstNumber = sequence[secondIndex];
            long secondNumber = sequence[firstIndex];
            sequence.RemoveAt(firstIndex);
            sequence.Insert(firstIndex, firstNumber * secondNumber);
        }
        static void Decrease(List<long> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                long number = sequence[i];
                sequence[i] = number - 1;
            }
        }

    }
}
