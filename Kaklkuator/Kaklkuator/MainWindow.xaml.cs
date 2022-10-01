using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Kaklkuator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String Tresc;
        public MainWindow()
        {
            InitializeComponent();
            Wynik.Text = string.Empty;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var wcisniety = ((Button) sender).Content;
            
            Wynik.Text += wcisniety;

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = string.Empty;
        }

        private void wynik_Click(object sender, RoutedEventArgs e)
        {
            var wynik = Wynik.Text;

            Wynik.Text = liczenie(wynik).ToString();

        }

        private void Button_mnozenie(object sender, RoutedEventArgs e)
        {
            var wynik = Wynik.Text;

            if(sprawdzenie(wynik))
            {
                Wynik.Text = liczenie(wynik).ToString();
            }

            Wynik.Text += "*";
        }

        private void Button_dzielenie(object sender, RoutedEventArgs e)
        {
            var wynik = Wynik.Text;

            if (sprawdzenie(wynik))
            {
                
                Wynik.Text = liczenie(wynik).ToString();
            }
            Wynik.Text += "/";
        }

        private void Button_dodawanie(object sender, RoutedEventArgs e)
        {
            var wynik = Wynik.Text;

            if (sprawdzenie(wynik))
            {
                Wynik.Text = liczenie(wynik).ToString();
            }
            Wynik.Text += "+";
        }

        private void Button_odejmowanie(object sender, RoutedEventArgs e)
        {
            var wynik = Wynik.Text;

            if (sprawdzenie(wynik))
            {
                Wynik.Text = liczenie(wynik).ToString();
            }
            Wynik.Text += "-";
        }

        private bool sprawdzenie(string wynik)
        {
            return wynik.Contains('+') || wynik.Contains('-') || wynik.Contains('*') || wynik.Contains('/') ;
        }
        private int liczenie(string wynik)
        {
            if (wynik.Contains('+'))
            {
                var x = wynik.Split('+');

                return int.Parse(x[0]) + int.Parse(x[1]);

            }
            if (wynik.Contains('-'))
            {
                var x = wynik.Split('-');

                return int.Parse(x[0]) - int.Parse(x[1]);

            }
            if (wynik.Contains('*'))
            {
                var x = wynik.Split('*');

                return int.Parse(x[0]) * int.Parse(x[1]);

            }
            if (wynik.Contains('/'))
            {
                var x = wynik.Split('/');
                
                
                return int.Parse(x[0]) / int.Parse(x[1]);

            }

            return default;
        }

    }
}
