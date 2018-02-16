using System;
namespace eek_2018_oop_5
{
    class Country : Calculate
    {
        protected string name;
        protected double population;
        protected double area;

        public Country(string name = "---", double population = 0, double area = 0)
        {
            this.name = name;
            this.population = population;
            this.area = area;
        }

        public Country(Country ob)
        {
            this.name = ob.name;
            this.population = ob.population;
            this.area = ob.area;
        }

        public void printMe()
        {
            Console.WriteLine("{0,-15} {1,6:f1} {2:6:f1}", name, population, area);
        }

        public double calculatePopulationDensity()
        {
            return population / area;
        }

        public static bool operator > (Country a, Country b) { return a.population > b.population; }
        public static bool operator < (Country a, Country b) { return a.population < b.population; }
    }
}
