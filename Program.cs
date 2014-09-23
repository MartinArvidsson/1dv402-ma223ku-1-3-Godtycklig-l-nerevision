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
                        return;
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
        }
        static void processSalaries(int count)
        {
            int[] SalariesArray = new int[count];
            
            for (int i = 0; i < SalariesArray.Length; ++i)
            {
                SalariesArray[i] = ReadInt("Ange lön nummer " + (i+1) + ": ");
                
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
