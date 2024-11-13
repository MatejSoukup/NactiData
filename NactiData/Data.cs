using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NactiData
{
    public class Data
    {
        public double Number1 { get; private set; }
        public double Number2 { get; private set; }
        public double Number3 { get; private set; }

        public Data()
        {
            // Načtení tří hodnot z konzole
            Console.Write("Zadejte první číslo: ");
            Number1 = ReadConsoleDouble();

            Console.Write("Zadejte druhé číslo: ");
            Number2 = ReadConsoleDouble();

            Console.Write("Zadejte třetí číslo: ");
            Number3 = ReadConsoleDouble();

            Console.WriteLine(Add());
            Console.WriteLine(Product());
            Console.WriteLine(Operation());

        }

        public double Add()
        {
            return Number1 + Number2 + Number3; 
        }

        public double Product()
        {
            return Number1 * Number2 * Number3;
        }

        public double Operation()
        {
            if (Number3 != 0)
            {
                return (Number1 + Number2) / Number3;
            }
            WriteError("Dělení nulou");
            return double.NaN;
        }

        private double ReadConsoleDouble()
        {
            while (true)
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    WriteError("Neplatný formát čísla.");
                    Console.WriteLine("Zadejte prosím platné číslo:");
                }
            }
        }

        private void WriteError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        


    }
}
