using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq.Expressions;
namespace inlämning4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int tal;
                int störst = 0;


                string svar = null;
                do
                {
                    Console.WriteLine("Skriv in ett heltal");
                    tal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vill du fortsätta? j/n.");
                    svar = Console.ReadLine().ToLower();

                    if (tal >= störst)
                    {
                        störst = tal;
                    }

                } while (svar == "j");
                {
                    Console.WriteLine($"Det största talet du gav var: {störst}.");
                    Console.WriteLine("Avslutar programmet");
                }
            }
            catch
            {
                Console.WriteLine("OBS! Fel vid inmatning.");
            }
        }   
    }
}