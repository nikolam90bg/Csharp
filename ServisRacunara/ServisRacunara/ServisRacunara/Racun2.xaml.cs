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
    /// Interaction logic for Racun2.xaml
    /// </summary>
    public partial class Racun2 : Window
    {

        
        public Racun2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int broj = Convert.ToInt32(tb_sifraRacuna.Text);

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            try
            {


                var podaciDC = from x in DC.RacunVlasnikas where x.sifraRacuna == broj select x;

                foreach (var podaci in podaciDC)
                {
                    tb_brLicne.Text = podaci.brLicne.ToString();
                    tb_imeRadnika.Text = podaci.radnik.ToString();
                    tb_vreme.Text = podaci.vreme.ToString();
                    tb_imePrezime.Text = podaci.imePrezime.ToString();
                    tb_mail.Text = podaci.mail.ToString();
                    tb_telefon.Text = podaci.telefon.ToString();
                    tb_sifRacunara.Text = podaci.sifraRac.ToString();

                    rtb_opisKvara.AppendText(podaci.opisKva.ToString());
                    rtb_SpisakPoslova.AppendText(podaci.spisPoslova.ToString());
                    rtb_SpisakRezDel.AppendText(podaci.rezDel.ToString());

                    tb_cenaUsluga.Text = podaci.cenaUsluga.ToString();
                    tb_cenaDelova.Text = podaci.cenaDelova.ToString();
                    tb_ukupnaCena.Text = podaci.cenaUkupna.ToString();

                }
            }
            catch (Exception)
            {

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int broj = Convert.ToInt32(tb_sifraRacuna.Text);
            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            RacunVlasnika rc = (from x in DC.RacunVlasnikas where x.sifraRacuna == broj select x).SingleOrDefault();

            DC.RacunVlasnikas.DeleteOnSubmit(rc);
            DC.SubmitChanges();

            MessageBox.Show("Racuna je uspesno obrisan!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();

            
         
        }
    }

}
