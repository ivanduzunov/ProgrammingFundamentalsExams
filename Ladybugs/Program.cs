using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexesWithBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (indexesWithBugs.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }

            string command = Console.ReadLine();
            while (!command.Equals("end"))
            {
                string[] commandSp = command.Split(' ').ToArray();

                int index = int.Parse(commandSp[0]);
                string direction = commandSp[1];
                int flyLenght = int.Parse(commandSp[2]);

                if (direction.Equals("right"))
                {
                    if (flyLenght > 0)
                    {

                        if ( index > field.Length - 1 || index < 0||field[index]==0)
                        {
                            goto End;
                        }
                        else
                        {
                            field[index] = 0;
                            for (int i = index + flyLenght; i < field.Length; i += flyLenght)
                            {
                                if (field[i] == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (index>field.Length-1 || index < 0 || field[index] == 0)
                        {
                            
                            goto End;
                        }
                        else
                        {
                            field[index] = 0;
                            for (int i = index - Math.Abs(flyLenght); i > -1; i -= Math.Abs(flyLenght))
                            {
                                if (field[i] == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                    }


                }
                else
                {
                    if (flyLenght < 0)
                    {

                        if (index > field.Length - 1 || index < 0 || field[index] == 0)
                        {
                            goto End;
                        }
                        else
                        {
                            field[index] = 0;
                            for (int i = index + Math.Abs(flyLenght); i < field.Length; i += Math.Abs(flyLenght))
                            {
                                if (field[i] == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (index > field.Length - 1 || index < 0 || field[index] == 0)
                        {
                            
                            goto End;
                        }
                        else
                        {
                            field[index] = 0;
                            for (int i = index - Math.Abs(flyLenght); i > -1; i -= Math.Abs(flyLenght))
                            {
                                if (field[i] == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                    }

                }

                End: command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
