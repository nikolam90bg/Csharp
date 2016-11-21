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
    /// Interaction logic for DodajRezDeo.xaml
    /// </summary>
    public partial class DodajRezDeo : Window
    {
        public DodajRezDeo()
        {
            InitializeComponent();

           tb_model.Visibility = Visibility.Hidden;
            tb_kolicina.Visibility = Visibility.Hidden;
            tb_cena.Visibility = Visibility.Hidden;
            cb_marka.Visibility = Visibility.Hidden;
            cb_vrsta.Visibility = Visibility.Hidden;
        }

        private void btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            bool pom = false;

            ServisRacunaraDataContext s = new ServisRacunaraDataContext();

            try
            {
                RezervniDeo rd = new RezervniDeo();

                rd.barkod = Convert.ToInt32(tb_barkod.Text);
                rd.marka = ((ComboBoxItem)cb_marka.SelectedItem).Content.ToString();
                rd.vrsta = ((ComboBoxItem)cb_vrsta.SelectedItem).Content.ToString();
                rd.model = tb_model.Text;
                rd.kolicina = Convert.ToInt32(tb_kolicina.Text);
                rd.cena = Convert.ToInt32(tb_cena.Text);


                s.RezervniDeos.InsertOnSubmit(rd);
                s.SubmitChanges();
                pom = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Barkod vec postoji u bazi!", "Obavestenje!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (pom)
            {
                MessageBox.Show("Uspesno ste ubacili novi rezervni deo u bazu!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void btn_provera_Click(object sender, RoutedEventArgs e)
        {
            bool pom = false;
            int barkod = Convert.ToInt32(tb_barkod.Text);

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();

            try
            {


                var podaciDC = from x in DC.RezervniDeos where x.barkod == barkod select x;

                foreach (var podaci in podaciDC)
                {
                    if (podaci.barkod == barkod) pom = true;
                    break;
                }

                if (pom)
                {
                    MessageBox.Show("Rezervni deo sa unetim barkodom vec postoji u bazi!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rezervni deo sa unetim barkodom ne postoji u bazi!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    tb_model.Visibility = Visibility.Visible;
                    tb_kolicina.Visibility = Visibility.Visible;
                    tb_cena.Visibility = Visibility.Visible;
                    cb_marka.Visibility = Visibility.Visible;
                    cb_vrsta.Visibility = Visibility.Visible;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
