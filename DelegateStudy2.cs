using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate int FuncDelegate(int Num1, int Num2);
    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if(total>=threshold)
            {
                ThresholdReached?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler ThresholdReached;
    }

    class DelegateStudy2
    {
        static void c_ThresholdReadhed(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached");
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReadhed;

            while(Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }

            Console.ReadLine();
        }
    }
}
