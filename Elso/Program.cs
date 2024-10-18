using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                Console.Write("Kérem, adja meg a vásárlási összeget (Ft): ");
                decimal osszeg;

                
                while (!decimal.TryParse(Console.ReadLine(), out osszeg) || osszeg < 0)
                {
                    Console.Write("Kérem, érvényes pozitív számot adjon meg: ");
                }

                
                Console.Write("Rendelkezik-e törzsvásárlói kártyával? (igen/nem): ");
                string valasz = Console.ReadLine().ToLower();

                decimal fizetendoOsszeg;

                
                if (osszeg < 10000)
                {
                    fizetendoOsszeg = osszeg;
                }
                else if (osszeg >= 10000 && osszeg <= 50000)
                {
                    if (valasz == "igen")
                    {
                        fizetendoOsszeg = osszeg * 0.95m; 
                    }
                    else
                    {
                        fizetendoOsszeg = osszeg;
                    }
                }
                else
                {
                    if (valasz == "igen")
                    {
                        fizetendoOsszeg = osszeg * 0.90m; 
                    }
                    else
                    {
                        fizetendoOsszeg = osszeg * 0.95m;
                    }
                }


                
                Console.WriteLine($"Fizetendő összeg: {fizetendoOsszeg:F0} Ft");

                
                Console.ReadKey();

            }
        }
    }
}