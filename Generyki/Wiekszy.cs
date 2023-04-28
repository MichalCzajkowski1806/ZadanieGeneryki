using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public static class Wiekszy
    {
        public static T ZnajdzWiekszy<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) == 1)
            {
                return a;
            }
            else if (a.CompareTo(b) == 0)
            {
                return b;
            }
            else
                return b;
        }
    }
}
