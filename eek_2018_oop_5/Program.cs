using System;
using System.Collections;
using System.Collections.Generic;

namespace eek_2018_oop_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Comparisons

            Country Estonia = new Country("Est", 1.3, 40);
            Country Latvia = new Country("Lat", 1.9, 65);
            Country Finland = new Country("Fin", 5.3, 90);
            Country Norway = new Country("Nor", 3.9, 85);

            Estonia.printMe();
            Latvia.printMe();

            if (Estonia < Latvia)
                Console.WriteLine("Estonia smaller pop than Latvia");

            List<Country> BalticAndNordicCountries = new List<Country>();
            BalticAndNordicCountries.Add(Estonia);
            BalticAndNordicCountries.Add(Latvia);
            BalticAndNordicCountries.Add(Finland);
            BalticAndNordicCountries.Add(Norway);

            Console.WriteLine("Print baltic and nordic");
            foreach(Country x in BalticAndNordicCountries)
            {
                x.printMe();
            }

            Console.WriteLine("Print baltic and nordic SORTED");
            BalticAndNordicCountries.Sort();
            foreach (Country x in BalticAndNordicCountries)
            {
                x.printMe();
            }

            // Date formatting

            Console.WriteLine();
            DateEst valentineDayEe = new DateEst("14.02.2018");
            valentineDayEe.printMe();
            DateUS valentineDayUS = valentineDayEe;
            valentineDayUS.printMe();

            Console.WriteLine();
            DateUS midsummersEveUS = new DateEst("24.06.2018");
            midsummersEveUS.printMe();
            DateEst midsummersEveEE = midsummersEveUS;
            midsummersEveEE.printMe();

            Console.Read();
        }
    }
}
