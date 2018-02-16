using System;
namespace eek_2018_oop_5
{
    class DateUS
    {
        public string date { get; }

        public DateUS(string date = "kk.pp.aaaa") { this.date = date; }
        public void printMe() { Console.WriteLine("{0,10}", date); }

        public static implicit operator DateUS(DateEst x)
        {
            string s = x.date;

            string day = s.Substring(0, 2);
            string month = s.Substring(3, 2);
            string year = s.Substring(6, 4);

            string t = month + "." + day + "." + year;

            return new DateUS(t);
        }
    }
}
