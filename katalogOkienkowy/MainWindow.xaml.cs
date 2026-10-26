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

namespace katalogOkienkowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //stwórz listę kilku produktów


            List<Product> listaProduktow = new List<Product>
            {
              new Product("Chleb", 2.50, "Pieczywo" , 5 , 1),
              new Product("Ser", 10, "Nabiał" , 14 , 1),
              new Product("Kiełbasa", 6, "wędliny" , 9 , 1),
              new Product("Herbata Lipton", 11.99 , "Napoje" , 20 , 1),
              new Product("babka", 7, "Pieczywo" , 10 , 1),
              new Product("kajzerka", 0.99, "Pieczywo" , 67 , 1),
              new Product("Ciastka", 19.99, "Pieczywo" , 10 , 1),

            };

            EtykietaLiczbaProduktow.Text = $"Liczba produktów: {listaProduktow.Count}";
            EtykietaWartoscProduktow.Text = $"Wartosc magazynu: {Product.ObliczWartoscMagazynu(listaProduktow):C}";

            TextBlock dopisek = new TextBlock();
            dopisek.Text = "to zostanie dodane";
            dopisek.FontSize = 14;
            GlownyStackPanel.Children.Add(dopisek);
        }
    }
}