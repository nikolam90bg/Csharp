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
    /// Interaction logic for Zahtev2.xaml
    /// </summary>
    public partial class Zahtev2 : Window
    {
        public int broj;
        public Zahtev2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            try
            {
                var podaciDC = from x in DC.ZahtevServs where x.brZahteva == broj select x;



                foreach (var podaci in podaciDC)
                {
                    lbl_vreme.Content = podaci.datum.ToString();
                    lbl_serviser.Content = podaci.serviser.ToString();
                    rtb_zahtev.AppendText(podaci.tekst.ToString());


                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_brisi_Click(object sender, RoutedEventArgs e)
        {
           
            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            ZahtevServ rc = (from x in DC.ZahtevServs where x.brZahteva == broj select x).SingleOrDefault();
            DC.ZahtevServs.DeleteOnSubmit(rc);
            DC.SubmitChanges();
            MessageBox.Show("Zahtev je uspesno obrisan!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
