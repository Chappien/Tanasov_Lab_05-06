using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string ourfName;
        public string ourfamili;
        public int ourfEge;
        public string ourfKor;
        public int Price;
        public string ourCountry;
        public bool Woter;

        public static void Flowers() {
            Console.WriteLine("Введіть назву рослини: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Введiть культуру рослини: ");
            string famili = Console.ReadLine();
            Console.WriteLine("Введiть середній період життя: ");
            string fEge = Console.ReadLine();
            Console.WriteLine("Введiть тип коріння: ");
            string fKor = Console.ReadLine();
            Console.WriteLine("Введiть ціну на продажі: ");
            string fPrice = Console.ReadLine();
            Console.WriteLine("Введiть країну походження: ");
            string fCountry = Console.ReadLine();
            Console.Write("Потрібно поливати кожен день ?(t - так , n - ні) ");
            ConsoleKeyInfo keyWoter = Console.ReadKey();

            Class1 OurFlowers = new Class1
            {
                ourfName = fName,
                ourfamili = famili,
                ourfEge = int.Parse(fEge),
                ourfKor = fKor,
                Price = int.Parse(fPrice),
                ourCountry = fCountry,
                Woter = keyWoter.Key == ConsoleKey.T,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва рослини : " + OurFlowers.ourfName);
            Console.WriteLine("Культура рослини: " + OurFlowers.ourfamili);
            Console.WriteLine("Середній період життя: " + OurFlowers.ourfEge);
            Console.WriteLine("Тип коріння: " + OurFlowers.ourfKor);
            Console.WriteLine("Ціна на продажу: " + OurFlowers.Price + "грн.");
            Console.WriteLine("Країна походження: " + OurFlowers.ourCountry);
            Console.WriteLine(OurFlowers.Woter ? "Цю рослину потрібно поливати кожен день" : "Цю рослину не потрібно поливати кожен день");
            Console.ReadKey();

        }
    }
}
