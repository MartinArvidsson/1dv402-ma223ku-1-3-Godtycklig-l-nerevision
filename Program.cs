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
            int Salaries;
            {
                Console.Write("Ange antal löner att mata in: "); //Frågar om hur många löner som ska bearbetas
                Salaries = int.Parse(Console.ReadLine()); // Läser in vad användaren skriver och omvandlar till heltal
                {
                    int[] SalariesArray = new int[Salaries]; //Skapar en array
                    {
                        Console.WriteLine("Ange {0} lönen",SalariesArray.Length);
                        for (int i = 0; i < SalariesArray.Length; i++)
                        {
                        }
                    }
                }
            }
        }
    }
}
