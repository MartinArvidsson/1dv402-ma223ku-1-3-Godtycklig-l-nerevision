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
         int Paychecks;
         Paychecks = ReadInt("Ange antal löner som ska bearbetas: ");
        }
        static void processSalaries(int count)
        {
            int[] SalariesArray = new int[];
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
