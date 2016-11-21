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
    /// Interaction logic for NoviRacun.xaml
    /// </summary>
    public partial class NoviRacun : Window
    {
        public NoviRacun()
        {
            InitializeComponent();
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int broj = Convert.ToInt32(cb.SelectedItem);

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            try
            {
                var podaciDC = from x in DC.RadNalogs where x.sifraNaloga == broj select x;


                foreach (var podaci in podaciDC)
                {
                    tb_imeRadnika.Text = podaci.radnik.ToString();
                    tb_vreme.Text = podaci.vreme.ToString();
                    tb_imePrezime.Text = podaci.imePrezime.ToString();
                    tb_brLicne.Text = podaci.brLicne.ToString();
                    tb_telefon.Text = podaci.telefon.ToString();
                    tb_mail.Text = podaci.mail.ToString();
                    tb_sifRacunara.Text = podaci.sifraRac.ToString();
                    rtb_opisKvara.AppendText(podaci.opisKva.ToString());
                    rtb_SpisakPoslova.AppendText(podaci.spisPoslova.ToString());
                    rtb_SpisakRezDel.AppendText(podaci.rezDel.ToString());


                }
            }
            catch (Exception)
            {

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ServisRacunaraDataContext dt = new ServisRacunaraDataContext();
            var ID = from x in dt.RadNalogs select x.sifraNaloga;
            foreach (var sifra in ID)
            {
                cb.Items.Add(sifra.ToString());
            }
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            int suma = 0;
            if (cb_dijagnostika.IsChecked == true) suma = suma + 1000;
            if (cb_popravka.IsChecked == true) suma = suma + 1500;
            if (cb_deo.IsChecked == true) suma = suma + 500;
            tb_cenaUsluga.Text = suma.ToString();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_cenaDelova.Text))
                tb_cenaDelova.Text = "0";
            tb_ukupnaCena.Text = (Convert.ToInt32(tb_cenaDelova.Text) + Convert.ToInt32(tb_cenaUsluga.Text)).ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool pom = false;

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();

            try
            {
                RacunVlasnika rv = new RacunVlasnika();

                rv.sifraNaloga = Convert.ToInt32(cb.SelectedValue.ToString());
                rv.radnik = tb_imeRadnika.Text;
                rv.vreme = tb_vreme.Text;

                rv.imePrezime = tb_imePrezime.Text;
                rv.brLicne = Convert.ToInt32(tb_brLicne.Text);
                rv.telefon = tb_telefon.Text;
                rv.mail = tb_mail.Text;
                rv.sifraRac = tb_sifRacunara.Text;

                rv.opisKva = new TextRange(rtb_opisKvara.Document.ContentStart, rtb_opisKvara.Document.ContentEnd).Text;
                rv.spisPoslova = new TextRange(rtb_SpisakPoslova.Document.ContentStart, rtb_SpisakPoslova.Document.ContentEnd).Text;
                rv.rezDel = new TextRange(rtb_SpisakRezDel.Document.ContentStart, rtb_SpisakRezDel.Document.ContentEnd).Text;


                rv.cenaDelova = tb_cenaDelova.Text;
                rv.cenaUsluga = tb_cenaUsluga.Text;
                rv.cenaUkupna = tb_ukupnaCena.Text;

                DC.RacunVlasnikas.InsertOnSubmit(rv);
                DC.SubmitChanges();
                pom = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Doslo je do greskee!");
            }
            if (pom)
            {
                MessageBox.Show("Uspesno ste kreirali racun!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
