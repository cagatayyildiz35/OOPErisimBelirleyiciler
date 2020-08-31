using BoostDateExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPErisimBelirleyiciler
{
    class Program
    {
        static void Main(string[] args)
        {
            BilgeDate.GetYesterday();

            CounterStrike cs = new CounterStrike();

            Console.WriteLine(BilgeDate.GetYesterday());
            Console.ReadLine();
        }
    }
}
