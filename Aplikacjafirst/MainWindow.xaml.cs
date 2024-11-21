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

namespace Aplikacjafirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Powitanie { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Powitanie = "Siemanko";
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            powitanie.Content = "witam";
            MessageBox.Show("czy podoba ci się zmiana?", "Zapytanie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            MessageBox.Show(Powitanie);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int liczba1,liczba2;
            if (int.TryParse(Liczba1.Text, out liczba1) && int.TryParse(Liczba2.Text, out liczba2))
            {
                int wynik = liczba1 + liczba2;
                MessageBox.Show(wynik.ToString());
            }
            else {
                MessageBox.Show("Niewłaściwe dane");
            }
        }
    }
}