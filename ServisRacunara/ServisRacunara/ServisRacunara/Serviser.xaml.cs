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
using System.Windows.Shapes;

namespace ServisRacunara
{
    /// <summary>
    /// Interaction logic for Serviser.xaml
    /// </summary>
    public partial class Serviser : Window
    {
        public Serviser()
        {
            InitializeComponent();
            lbl_vreme.Content = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_rNalozi_Click(object sender, RoutedEventArgs e)
        {
            Rnalozi2 rn = new Rnalozi2();
            rn.Show();
        }

        private void btn_zahtev_Click(object sender, RoutedEventArgs e)
        {
            Zahtev z= new Zahtev();
            z.lbl_serviser.Content = lbl_imeServisera.Content.ToString();
            z.Show();

        }

        private void btn_odjavi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mail = new MainWindow();
            MessageBoxResult result = MessageBox.Show("Da li zelite da se odjavite?", "Obavestenje", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                mail.Show();
                this.Close();
            }
        }

        private void btn_rezDelovi_Click(object sender, RoutedEventArgs e)
        {
            TraziRezDeo trd = new TraziRezDeo();
            trd.Show();
        }
    }
}
