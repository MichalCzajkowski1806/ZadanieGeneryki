using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generyki
{
    public interface IPoprawialny<T>
    {
        T PobierzLepszWersje();
    }
    public class Student: IPoprawialny<Student>
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }

        public override string ToString()
        {
            return $"Nazwisko: {Nazwisko}\nOcena: {Ocena}";
        }

        public Student PobierzLepszWersje()
        {
            return new Student() { Nazwisko = "Poprawiony", Ocena = 50.50 };
        }
    }
}
