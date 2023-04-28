using Generyki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_B
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Student> studenci = new Dictionary<int, Student>();

        Student s1 = new Student() { Nazwisko = "Kustera", Ocena = 2.5 };
        Student s2 = new Student() { Nazwisko = "Czmyt", Ocena = 2.0 };
        Student s3 = new Student() { Nazwisko = "Pryta", Ocena = 2.0 };
        Student s4 = new Student() { Nazwisko = "Blachak", Ocena = 5.0 };

        public MainWindow()
        {
            InitializeComponent();
            studenci.Add(43593, s1);
            studenci.Add(17547, s2);
            studenci.Add(14367, s3);
            studenci.Add(86523, s4);
        }

        private void btnSzukaj_Click(object sender, RoutedEventArgs e)
        {
            var nr_albumu = Convert.ToInt32(txtSzukaj.Text);
            Student student;

            if (studenci.TryGetValue(nr_albumu, out student))
            {
                MessageBox.Show($"Nazwisko: {student.Nazwisko}\nOcena: {student.Ocena}");
            }
            else
            {
                MessageBox.Show($"Nie znaleziono!");
            }
        }

        private void btnWiekszy_Click(object sender, RoutedEventArgs e)
        { 
            string jeden = "jeden";
            string dwa = "dwadzieścia osiem";
            MessageBox.Show(Wiekszy.ZnajdzWiekszy(jeden, dwa));
            double pierwsza = 5.0;
            double druga = 7.0;
            MessageBox.Show(Convert.ToString(Wiekszy.ZnajdzWiekszy(pierwsza, druga)));
            Student s1 = new Student();
            Student s2 = new Student();
            //MessageBox.Show(Convert.ToString(Wiekszy.ZnajdzWiekszy(s1, s2)));
        }

        private void btnRegal_Click(object sender, RoutedEventArgs e)
        {
            Student s1 = new Student() { Nazwisko = "Kowalski", Ocena = 5.0 };
            Student s2 = new Student() { Nazwisko = "Adamski", Ocena = 3.0 };
            Student s3 = new Student() { Nazwisko = "Marczewski", Ocena = 4.0 };

            double jeden = 50.1;
            double dwa = 26.6;
            double trzy = 33.3;

            Regal<double> r1 = new Regal<double>();
            Regal<Student> r2 = new Regal<Student>();

            r1.Polka1 = jeden;
            r1.WstawNawolnaPolke(dwa);
            r1.WolnaPolka = trzy;

            r2.Polka1 = s1;
            r2.WstawNawolnaPolke(s2);
            r2.WolnaPolka = s3;

            MessageBox.Show(r1.ToString());
            MessageBox.Show(r2.ToString());

        }
    }
}
