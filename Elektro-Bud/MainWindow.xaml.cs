using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Elektro_Bud
{
    public partial class MainWindow : Window
    {
        List<Produkt> produkty = new List<Produkt>();

        public MainWindow()
        {
            InitializeComponent();

            produkty.Add(new Produkt { Ean = "1892376124051", Nazwa = "Kable", Kategoria = "Elektryczne", Sektor = "A", Regal = 5, Polka = 6 });
            produkty.Add(new Produkt { Ean = "0905011812722", Nazwa = "Cement", Kategoria = "Budowlane", Sektor = "B", Regal = 6, Polka = 9 });
            produkty.Add(new Produkt { Ean = "2203010524111", Nazwa = "Wiertarka", Kategoria = "Narzędzia", Sektor = "C", Regal = 1, Polka = 2 });
            produkty.Add(new Produkt { Ean = "2411080105901", Nazwa = "Cegła", Kategoria = "Budowlane", Sektor = "D", Regal = 3, Polka = 8 });
        }

        private void Szukaj(object sender, RoutedEventArgs e)
        {
            String wypisz = wpisz.Text;
            wynik.Text = "";

            foreach (var p in produkty)
            {
                if (p.Ean == wypisz || p.Nazwa == wypisz)
                {
                    wynik.Text += p.Nazwa + "\n";
                    wynik.Text += "EAN:" + p.Ean + "\n";
                    wynik.Text += "Kategoria:" + p.Kategoria + "\n";
                    wynik.Text += "Lokalizacja:" + p.Sektor + p.Regal + p.Polka + "\n";

                }
            }
            if (wynik.Text == "")
            {
                wynik.Text = "Nie ma takiego produktu";
            }
        }
    }
}