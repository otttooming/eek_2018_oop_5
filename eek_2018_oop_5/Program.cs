using System;

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

            Estonia.printMe();
            Latvia.printMe();

            if (Estonia < Latvia)
                Console.WriteLine("Estonia smaller pop than Latvia");

            Console.Read();
        }
    }
}
