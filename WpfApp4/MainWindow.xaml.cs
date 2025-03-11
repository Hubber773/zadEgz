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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_ginner_Click(object sender, RoutedEventArgs e)
        {
            int ileZnaków = TB_znaki.Text.Length;
            //char hasztag = '#'
            string[] tabliczka = new string[ileZnaków];
            string[] tabliczkaLiteralna = new string[ileZnaków];
            string[] tabliczkaCyfrowa = new string[ileZnaków];
            string[] tabliczkaSpecjalna = new string[ileZnaków];
            Random rnd = new Random();

            string litery = "qwertyuiopasdfghjklzxcvbnnnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string cyfry = "1234567890";
            string specjalne = "!@#$%^&*-=_+";
            string hasloLiter = "";
            string hasloCyfr = "";
            string hasloSpecjal = "";

            for (int i = 0; i < tabliczka.Length; i++)
            {
                if (CB_litery.IsChecked == true)
                {
                    //MessageBox.Show($"{ileZnaków}");
                    tabliczkaLiteralna[0] = litery[rnd.Next(0, litery.Length)].ToString();
                    hasloLiter += tabliczkaLiteralna[0];
                }
                if (CB_cyfry.IsChecked == true)
                {
                    tabliczkaCyfrowa[0] = cyfry[rnd.Next(0, cyfry.Length)].ToString();
                    hasloCyfr += tabliczkaCyfrowa[0];
                }
                if (CB_specjalnyJestes.IsChecked == true)
                {
                    tabliczkaSpecjalna[0] = specjalne[rnd.Next(0, specjalne.Length)].ToString();
                    hasloSpecjal += tabliczkaSpecjalna[0];
                }
            }
            // Mieszanie hasla
            string hasloMieszane = hasloLiter + hasloCyfr + hasloSpecjal;
            Random rndMieszane = new Random();

            while (hasloMieszane.Length > ileZnaków)
            {
                int index = rndMieszane.Next(0, hasloMieszane.Length);
                hasloMieszane = hasloMieszane.Remove(index, 1);
            }

            MessageBox.Show($"Wygenerowane hasło: {hasloMieszane}");
        }

        private void B_zatwardzenie_Click(object sender, RoutedEventArgs e)
        {
            string imie = TB_imie.Text;
            string nazwisko = TB_nazwisko.Text;
            //
        }
    }
}