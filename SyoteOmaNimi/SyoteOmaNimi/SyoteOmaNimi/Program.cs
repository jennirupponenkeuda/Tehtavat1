using System;

namespace SyoteOmaNimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä on nimesi?");
            string nimi = Console.ReadLine();
            Console.Write("Hei " + nimi);
        }
    }
}

//System.DateTime -luokan avulla määritellään aikaa päivämäärissä ja vuosissa. Sen lisäksi myös voidaan määritellä kellonaikoja.//
//System.Math -luokan avulla voidaan määritellä erilaisia matemaattisia toimintoja (esim funktioita yms.)//