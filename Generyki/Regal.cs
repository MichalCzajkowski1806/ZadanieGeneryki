using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public class Regal<T>
    {
        public T Polka1 { get; set; } = default(T);
        public T Polka2 { get; set; } = default(T);
        public T Polka3 { get; set; } = default(T); 
        public T WolnaPolka 
        { 
            set 
            {
                if (object.Equals(Polka1, default(T)))
                {
                    Polka1 = value;
                }
                else if (object.Equals(Polka2, default(T)))
                {
                    Polka2 = value;
                }
                else
                {
                    Polka3 = value;
                }
            } 
        }

        public void WstawNawolnaPolke(T argument)
        {
            if (object.Equals(Polka1, default(T)))
            {
                Polka1 = argument;
            }
            else if (object.Equals(Polka2, default(T)))
            {
                Polka2 = argument;
            }
            else
            {
                Polka3 = argument;
            }
        }

        public override string ToString()
        {
            return $"Półka1: {Polka1}\nPółka2: {Polka2}\nPółka3: {Polka3}\n";
        }
    }
}
