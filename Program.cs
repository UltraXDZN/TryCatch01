using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch01
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.Write("Unesi broj: ");
            try
            {
                broj = int.Parse(Console.ReadLine());
                Console.WriteLine($"Broj je: {broj}.");
            }
            catch (Exception greska)
            {
                Console.WriteLine(greska.Message);
            }
            
            Console.ReadKey();
        }
    }
}
