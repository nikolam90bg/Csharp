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
    /// Interaction logic for RadniNalog.xaml
    /// </summary>
    public partial class RadniNalog : Window
    {
        public RadniNalog()
        {
            InitializeComponent();
            tb_vreme.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            
            bool pom = false;

            ServisRacunaraDataContext s = new ServisRacunaraDataContext();

            try
            {

                RadNalog rn = new RadNalog();
                
                    
                    rn.radnik = tb_imeRadnika.Text;
                    rn.vreme = tb_vreme.Text;
                    rn.sifraNaloga = Convert.ToInt32(tb_sifNaloga.Text);
                    rn.status = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
                    rn.imePrezime = tb_imePrezime.Text;
                    rn.brLicne = Convert.ToInt32(tb_brLicne.Text);
                    rn.adresa = tb_adresa.Text;
                    rn.mail = tb_mail.Text;
                    rn.telefon = tb_telefon.Text;
                    rn.sifraRac = tb_sifRacunara.Text;
                    rn.opisPro = new TextRange(rtb_opisProb.Document.ContentStart, rtb_opisProb.Document.ContentEnd).Text;
                
                    s.RadNalogs.InsertOnSubmit(rn);
                    s.SubmitChanges();
                    pom = true;

                    }
            catch (Exception)
            {
                
            MessageBox.Show("Sifra radnog naloga vec postoji, morate uzeti drugu!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }

            if (pom)
            {
                MessageBox.Show("Uspesno ste kreirali radni nalog!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
                tb_adresa.Clear();
                tb_brLicne.Clear();
                tb_imePrezime.Clear();
                tb_mail.Clear();
                tb_sifNaloga.Clear();
                tb_sifRacunara.Clear();
                tb_telefon.Clear();
                rtb_opisProb.Document.Blocks.Clear();
                comboBox.SelectedIndex = -1;

            }


        }
    }
}
