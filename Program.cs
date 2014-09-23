using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godtycklig_lönerevison
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                while (true)
                {
                    try
                    {
                        int Paychecks;
                        Paychecks = ReadInt("Ange antal löner som ska bearbetas: ");
                        if (Paychecks <= 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fel! antal löner måste vara fler än 1!");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tryck valfri tangent för ny beräkning, Esc avslutar");
                            Console.ResetColor();
                            if (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                            {

                            }
                            while (Console.ReadKey(true).Key == ConsoleKey.Escape) ;
                            {
                                return;
                            }


                        }
                        processSalaries(Paychecks);
                        break;
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! du har inte angivit ett heltal! Eller så är talet för stort!");
                        Console.ResetColor();
                    }
                }

            } while  (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
            
        static void processSalaries(int count)
        {
            int[] SalariesArray = new int[count];
            
            for (int i = 0; i < SalariesArray.Length; ++i)
            {
                SalariesArray[i] = ReadInt("Ange lön nummer " + (i+1) + ": ");
                
            }
            int[] PresentationSalaries = (int[])SalariesArray.Clone();
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Array.Sort(SalariesArray);
            if (SalariesArray.Length % 2 == 0)
            {
                int MedianNumber1 = SalariesArray.Length / 2 ;
                int MedianNumber2 = SalariesArray.Length / 2 - 1;
                int Median1 = (SalariesArray[MedianNumber1] + SalariesArray[MedianNumber2]) / 2;
                Console.WriteLine("Medianlön :      {0:c0} ", Median1);
            }
            if (SalariesArray.Length % 2 == 1)
            {
                int Median2 = SalariesArray.Length / 2;
                Console.WriteLine("Medianlön :      {0:c0} ", SalariesArray[Median2]);
            }
            Console.WriteLine("Medellön :       {0:c0}", SalariesArray.Average()); //Medellön
            int Differerence = SalariesArray.Max() - SalariesArray.Min(); // Räknar differensen
            Console.WriteLine("Lönespridning :  {0:c0}", Differerence); // Presenterar Differensen
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i <PresentationSalaries.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(" {0,6 }", PresentationSalaries[i]);
            }
        }
        static int ReadInt(string prompt)
        {
            int salaries;
            Console.Write(prompt);
            salaries = int.Parse(Console.ReadLine());
            return salaries;
        }
    }
}
