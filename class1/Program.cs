using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    class money
    {
        public money(double bath) { this.amount = bath; } // constructor
        public double amount; // field
        public double bathToDollar() { return amount * 1d / 33d; }
        public double dollar  // properties
        {
            get { return amount * 1d / 33d; }
            set {; }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            money mymoney = new money(50);
            Console.WriteLine(mymoney.dollar);
        }
    }


}
