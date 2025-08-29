using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RubricaClientiConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il tuo Nome  :  ");
            string inputNome = Console.ReadLine();
            //int eta = Convert.ToInt32(inputEta);
            
            Console.WriteLine($"Hello {inputNome}");
            
            // waiting console read of vieew previous outut
            string end = Console.ReadLine();
        }
    }
}
