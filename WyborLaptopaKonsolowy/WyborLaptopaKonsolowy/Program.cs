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
        static string waga;
        static string wydajnoscProcesora;
        static string wydajnoscKartyGraficznej;
        static string SSD;
        static string RAM;
        static string HDD;
        static string czyZabiera;
        static string czymPodrozoje;
        static string czyKorzysta;
        static string czyGrafik;
        static string czyProjektant;
        static string czyGrafikZawod;
        static string czyProjektantZawod;
        static string czyGracz;
        static string stosunekDoGier;


        static void Main(string[] args)
        {
            /////////////////////WAGA I ROZMIAR POCZĄTEK//////////////////////////////////////////////////
            Console.WriteLine("Czy zabierasz swojego laptopa w podróże? (tak/nie):");
            czyZabiera=Console.ReadLine();
            if (czyZabiera=="tak")
            {
                Console.WriteLine("Czy podróżujesz autem, czy komunikacją publiczną? (auto/publiczna):");
                czymPodrozoje = Console.ReadLine();
                Console.WriteLine("Czy korzystasz z laptopa w podróży? (tak/nie):");
                czyKorzysta = Console.ReadLine();
            }
            
            if (czyZabiera=="nie")
            {
                rozmiar = "wszystkie";
                waga = "wszystkie";
            }
            if (czyZabiera == "tak" && czymPodrozoje == "publiczna")
            {
                waga = "do 2,5 kg";
            }
            if (czyZabiera == "tak" && czymPodrozoje == "auto")
            {
                waga = "wszystkie";
            }
            if (czyZabiera == "tak" && czyKorzysta == "tak")
            {
                rozmiar = "do 15,6 cala";
            }
            if (czyZabiera == "tak" && czyKorzysta == "nie")
            {
                rozmiar = "wszystkie";
            }
            /////////////////////WAGA I ROZMIAR KONIEC//////////////////////////////////////////////////

            Console.WriteLine("Czy zajmujesz się obróbką grafiki (hobbystycznie lub zawodowo)? (tak/nie)");
            czyGrafik = Console.ReadLine();
            if (czyGrafik == "tak")
            {
                Console.WriteLine("Czy to Twój zawód? (tak/nie):");
                czyGrafikZawod = Console.ReadLine();
            }

            Console.WriteLine("Czy zajmujesz się projektowaniem grafiki 2D/3D lub projektowaiem CAD/CAM? (tak/nie)");
            czyProjektant = Console.ReadLine();
            if (czyProjektant == "tak")
            {
                Console.WriteLine("Czy to Twój zawód? (tak/nie):");
                czyProjektantZawod = Console.ReadLine();
            }

            Console.WriteLine("Czy grasz w gry komputerowe? (tak/nie)");
            czyGracz = Console.ReadLine();
            if (czyGracz == "tak")
            {
                Console.WriteLine("Określ swój stosunek do gier komputerowych (niedzielny gracz/zwykły gracz/totalny maniak");
                stosunekDoGier = Console.ReadLine();
            }

            if (czyProjektant=="nie" && czyGrafik=="nie" && czyGracz=="nie" )
            {
                wydajnoscProcesora = "niska";
                wydajnoscKartyGraficznej = "niska";
                SSD = "nie";
                HDD = "do 500 GB";
                RAM = "do 8GB";     
            }
            if ((czyProjektant=="tak" && czyProjektantZawod=="nie") || (czyGracz=="tak" && stosunekDoGier=="niedzielny gracz"))
            {
                wydajnoscProcesora = "średnia";
                wydajnoscKartyGraficznej = "średnia";
                SSD = "nie";
                HDD = "do 500 GB";
                RAM = "do 8GB";
            }
            if (czyGrafik == "tak" && czyGrafikZawod == "nie")
            {
                wydajnoscProcesora = "średnia";
                wydajnoscKartyGraficznej = "średnia";
                SSD = "nie";
                HDD = "do 500 GB";
                RAM = "do 8GB";
            }
            if (czyGracz == "tak" && stosunekDoGier == "zwykły gracz")
            {
                wydajnoscProcesora = "średnia";
                wydajnoscKartyGraficznej = "wysoka";
                SSD = "nie";
                HDD = "do 500 GB";
                RAM = "powyżej 8GB";
            }
            if (czyGrafik == "tak" && czyGrafikZawod == "tak")
            {
                wydajnoscProcesora = "wysoka";
                if (wydajnoscKartyGraficznej != "wysoka") wydajnoscKartyGraficznej = "średnia";
                SSD = "tak";
                HDD = "do 500 GB";
                RAM = "powyżej 8GB";
            }
            if ((czyProjektant == "tak" && czyProjektantZawod == "tak") || (czyGracz == "tak" && stosunekDoGier == "totalny maniak"))
            {
                wydajnoscProcesora = "wysoka";
                wydajnoscKartyGraficznej = "wysoka";
                SSD = "tak";
                HDD = "powyżej 500 GB";
                RAM = "powyżej 8GB";
            }
            Console.WriteLine("Parametry dobranego laptopa:\nRozmiar: {0}\nWaga: {1}\nWydajność procesora: {2}\nWydajność karty graficznej: {3}\nDysk SSD: {4}\nPojemność HDD: {5}\nPamięć RAM: {6}", rozmiar, waga, wydajnoscProcesora, wydajnoscKartyGraficznej, SSD, HDD, RAM);
            Console.ReadLine();
        }
    }
}
