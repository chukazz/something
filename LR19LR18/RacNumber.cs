using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19LR18
{
    internal class RacNumber : IComparable<RacNumber>
    {
        int n;
        int m;

        public int N
        {
            get => n;
            set => n = value;
        }

        public int M
        {
            get => m;
            set
            {
                if (value > 0)
                    m = value;
                else
                    throw new Exception("не натуральное");
            }
        }

        public RacNumber(int one, int two)
        {
            n = one;
            m = two;
        }


        public int CompareTo(RacNumber a)
        {
            return this.n.CompareTo(a.n);
        }

        public void Print() => Console.WriteLine($"{n} {m}");

    }
}
