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

namespace ServisRacunara
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_odustani_Click(object sender, RoutedEventArgs e)
        {
            tb_korisnickoIme.Clear();
            tb_sifra.Clear();
            cb_osoba.SelectedIndex = -1;
        }

        private void btn_potvrdi_Click(object sender, RoutedEventArgs e)
        {
            String korisnik = "";
            String sifra = "";
            String osoba = "";
             String imeZaposlenog = "";

            bool pom = false;

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            try
            {
                var podaciDC = (from x in DC.Dosijes select new { x.korisnickoIme, x.sifra, x.osoba, x.ime});

                foreach (var podaci in podaciDC)
                {
                    korisnik = podaci.korisnickoIme;
                    sifra = podaci.sifra;
                    osoba = podaci.osoba;
                   imeZaposlenog = podaci.ime;

                    if (tb_korisnickoIme.Text == korisnik && tb_sifra.Password == sifra && ((ComboBoxItem)cb_osoba.SelectedItem).Content.ToString() == osoba)
                    {
                        pom = true;
                        break;
                    }
                   
                  
                }
                if (pom)
                {
                    if (osoba == "radnik")
                    {

                        MessageBoxResult odgovor = MessageBox.Show("Dobrodosli: " + imeZaposlenog.ToUpper(), "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);

                        if (odgovor == MessageBoxResult.OK)
                        {
                            Radnik radnik = new Radnik();
                            radnik.lbl_imeRadnika.Content = korisnik;
                            radnik.Show();
                            this.Close();
                        }

                    }
                    if (osoba == "serviser")
                    {
                        MessageBoxResult odgovor = MessageBox.Show("Dobrodosli: " + imeZaposlenog.ToUpper(), "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);

                        if (odgovor == MessageBoxResult.OK)
                        {
                            Serviser serviser = new Serviser();
                            serviser.lbl_imeServisera.Content = korisnik;
                            serviser.Show();
                            this.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske" + ex, "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
