using System;
namespace eek_2018_oop_5
{
    class DateEst
    {
        public string date { get; }

        public DateEst(string date = "pp.kk.aaaa") { this.date = date; }
        public void printMe() { Console.WriteLine("{0,10}", date); }

        public static implicit operator DateEst(DateUS x)
        {
            string s = x.date;

            string day = s.Substring(3, 2);
            string month = s.Substring(0, 2);
            string year = s.Substring(6, 4);

            return new DateEst(day + "." + month + "." + year);
        }
    }
}
