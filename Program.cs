using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doga
{
    class Program
    {
        public static List<Elemek> CSVDataList = new List<Elemek>();
        static void Main(string[] args)
        {
            ReadCSVList();

            //3.feladat:
            Console.WriteLine($"3. feladat: Elemek száma: {CSVDataList.Select(x => x.Elem).Count()}");

            //4.feladat:
            //TODO hiba
            Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {CSVDataList.Count(x => x.Ev == "Ókor")}");

            //5.feladat:
            string userData;
            do
            {
                Console.WriteLine("5. feladat: Kérek egy vegyjelet: ");
                userData = Console.ReadLine();

                if (CharacterCorrector(userData))
                {
                    break;
                }
            } while (true);

            //6. feladat:
            List<Elemek> datasByUserdata = CSVDataList.Where(x => x.Vegyjel == userData).ToList();
            Console.WriteLine(
                $"6. feladat Keresés \n \t Az elem vegyjele: {datasByUserdata.Select(x => x.Vegyjel)} \n \t Az elem neve: {datasByUserdata.Select(x => x.Elem)} \n \t Rendszáma: {datasByUserdata.Select(x => x.Rendszam)} \n \t Felfedezés éve: {datasByUserdata.Select(x => x.Ev)} \n \t Felfedezős: {datasByUserdata.Select(x => x.Felfedezo)}");

            //7.feladat:
            Console.WriteLine($"7. feladat: év volt a leghosszabb időszak két elem felfedezéseközött.");


            //8.feladat:
            Console.WriteLine($"8. feladat: {CSVDataList.Where(x => x.Elem.Count() > 3).Select(x => x.Ev).ToString()}");

        }

        static void ReadCSVList()
        {
             CSVDataList = File.ReadLines("felfedezesek.csv").Skip(1).Select(x => new Elemek(x)).ToList();
        }

        static bool CharacterCorrector(string data)
        {
            char[] characters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            foreach (var item in data.ToLower())
            {
                if (!characters.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
