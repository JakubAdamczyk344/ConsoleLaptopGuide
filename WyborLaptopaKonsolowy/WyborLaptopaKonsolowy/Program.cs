using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyborLaptopaKonsolowy
{
    class Program
    {
        static string rozmiar;
        static string wytrzymalosc;
        static string waga;
        static string czyZabiera;
        static string czymPodrozoje;
        static string czyKorzysta;

        static void Main(string[] args)
        {
            Console.WriteLine("Czy zabierasz swojego laptopa w podróże? (tak/nie):");
            czyZabiera=Console.ReadLine();
            if (czyZabiera=="tak")
            {
                Console.WriteLine("Czy podróżujesz autem, czy komunikacją publiczną? (auto/publiczna):");
                czymPodrozoje = Console.ReadLine();
                Console.WriteLine("Czy korzystasz z laptopa w podróży? (tak/nie):");
                czyKorzysta = Console.ReadLine();
            }
            
            Console.WriteLine("Czy zabiera: {0} Czym podróżuje: {1} Czy korzysta: {2}", czyZabiera, czymPodrozoje, czyKorzysta);
            
            if (czyZabiera=="nie" || czymPodrozoje=="auto")
            {
                rozmiar = "wszystkie";
            }
            if (czyZabiera == "tak" && czymPodrozoje == "publiczna")
            {
                waga = "do 2,5 kg";
            }
            else waga = "wszystkie";
            if (czyZabiera == "tak" && czyKorzysta == "tak")
            {
                rozmiar = "do 15,6 cala";
            }
            else rozmiar = "wszystkie";
            Console.WriteLine("Rozmiar: {0}\nWaga: {1},dupaaa", rozmiar, waga);
            Console.ReadLine();

        }
    }
}
