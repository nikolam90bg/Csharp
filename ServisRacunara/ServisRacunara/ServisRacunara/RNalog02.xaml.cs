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
    /// Interaction logic for RNalog02.xaml
    /// </summary>
    public partial class RNalog02 : Window
    {
        public RNalog02()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int broj = Convert.ToInt32(tb_sifNaloga.Text);

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
                    tb_adresa.Text = podaci.adresa.ToString();
                    tb_mail.Text = podaci.mail.ToString();
                    tb_sifRacunara.Text = podaci.sifraRac.ToString();
                    rtb_opisProb.AppendText(podaci.opisPro.ToString());
                    rtb_opisKvara.AppendText(podaci.opisKva.ToString());
                    rtb_spisakDelova.AppendText(podaci.rezDel.ToString());
                    rtb_spisakPoslova.AppendText(podaci.spisPoslova.ToString());
                  
                    comboBox.Items.Insert(0, podaci.status.ToString());
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_sacuvaj_Click(object sender, RoutedEventArgs e)
        {

            int broj = Convert.ToInt32(tb_sifNaloga.Text);
            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();

            
            try
            {
                var podaciDC = from x in DC.RadNalogs where x.sifraNaloga == broj select x;


                foreach ( RadNalog rn in podaciDC)
                {
                    rn.status = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
                    rn.opisKva = new TextRange(rtb_opisKvara.Document.ContentStart, rtb_opisKvara.Document.ContentEnd).Text;
                    rn.rezDel = new TextRange(rtb_spisakDelova.Document.ContentStart, rtb_spisakDelova.Document.ContentEnd).Text;
                    rn.spisPoslova = new TextRange(rtb_spisakPoslova.Document.ContentStart, rtb_spisakPoslova.Document.ContentEnd).Text;
                }

           

            DC.SubmitChanges();

                MessageBox.Show("Uspesno ste izvrsili izmene!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);



            }
            catch (Exception)
            {

                MessageBox.Show("errror", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
