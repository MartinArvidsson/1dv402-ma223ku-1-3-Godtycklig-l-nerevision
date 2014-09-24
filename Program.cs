using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godtycklig_lönerevison
{
    class Program
    {
        static void Main(string[] args) //Main
        {
            do 
            {
                while (true)
                {
                    try
                    {
                        int Paychecks;
                        Paychecks = ReadInt("Ange antal löner som ska bearbetas: "); //Läser in variablen som blir antalet löner
                        if (Paychecks <= 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fel! antal löner måste vara fler än 1!"); //Felmeddelande som visas om variablen är <1
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else
                        processSalaries(Paychecks);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tryck valfri tangent för ny beräkning, Esc avslutar"); //Startar om applikatonen om variablen var <1 eller när programmet var klart.
                        Console.ResetColor();
                        break;
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! du måste mata in tal, bokstäver går inte, talet får inte vara större än 2 miljader."); //Felmeddelande om man har bokstäver eller ett tal över 1 miljard.
                        Console.ResetColor();
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape); //Alla knappar utom esc. startar om programmet.
        }
            
        static void processSalaries(int count) // Här sker beräkningar och uträkningar
        {
            int[] SalariesArray = new int[count];
            
            for (int i = 0; i < SalariesArray.Length; ++i)
            {
                SalariesArray[i] = ReadInt("Ange lön nummer " + (i+1) + ": "); //Beräknar hur många "lådor" arrayen ska ha
                
            }
            int[] PresentationSalaries = (int[])SalariesArray.Clone();
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Array.Sort(SalariesArray);
            if (SalariesArray.Length % 2 == 0)
            {
                int MedianNumber1 = SalariesArray.Length / 2 ;
                int MedianNumber2 = SalariesArray.Length / 2 - 1;
                int Median1 = (SalariesArray[MedianNumber1] + SalariesArray[MedianNumber2]) / 2; // Räknar ut medianen
                Console.WriteLine("Medianlön :      {0:c0} ", Median1);
            }
            if (SalariesArray.Length % 2 == 1)
            {
                int Median2 = SalariesArray.Length / 2;
                Console.WriteLine("Medianlön :      {0:c0} ", SalariesArray[Median2]); //Median
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
                Console.Write(" {0,6 }", PresentationSalaries[i]); // Presenterar lönerna i ordningen
            }
        }
        static int ReadInt(string prompt) //Här anges variablen salaries
        {
            int salaries;
            Console.Write(prompt);
            salaries = int.Parse(Console.ReadLine()); 
            return salaries;
        }
    }
}
