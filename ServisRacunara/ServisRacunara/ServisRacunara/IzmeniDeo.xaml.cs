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
    /// Interaction logic for IzmeniDeo.xaml
    /// </summary>
    public partial class IzmeniDeo : Window
    {
        public IzmeniDeo()
        {
            InitializeComponent();
        }

        private void btn_trazi_Click(object sender, RoutedEventArgs e)
        {
            int broj = Convert.ToInt32(tb_barkod.Text);

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();
            try
            {
                var podaciDC = from x in DC.RezervniDeos where x.barkod == broj select x;


                foreach (var podaci in podaciDC)
                {
                    cb_marka.Items.Insert(0, podaci.marka.ToString());
                    cb_marka.SelectedIndex = 0;
                    cb_vrsta.Items.Insert(0, podaci.vrsta.ToString());
                    cb_vrsta.SelectedIndex = 0;
                    tb_model.Text = podaci.model;
                    tb_kolicina.Text = podaci.kolicina.ToString();
                    tb_cena.Text = podaci.cena.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ne postoji takav deo sa unetim barkodom!", "Obavestenje!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            int broj = Convert.ToInt32(tb_barkod.Text);
            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();

            try
            {
                var podaciDC = from x in DC.RezervniDeos where x.barkod == broj select x;


                foreach (RezervniDeo rd in podaciDC)
                {
                    rd.cena = Convert.ToInt32(tb_cena.Text);
                    rd.kolicina = Convert.ToInt32(tb_kolicina.Text);
                    rd.model = tb_model.Text;
                    rd.marka = ((ComboBoxItem)cb_marka.SelectedItem).Content.ToString();
                    rd.vrsta = ((ComboBoxItem)cb_vrsta.SelectedItem).Content.ToString();

                }

                DC.SubmitChanges();
                MessageBox.Show("Uspesno ste izvrsili izmene!", "Obavestenje!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Dosle je do greske prilikom snimanja!", "Obavestenje!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}
