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
    /// Interaction logic for Zahtev.xaml
    /// </summary>
    public partial class Zahtev : Window
    {

        
        public Zahtev()
        {
            InitializeComponent();
            lbl_vreme.Content = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_kreirajZahtev_Click(object sender, RoutedEventArgs e)
        {
            
            bool pom = false;
            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();

            try
            {
                ZahtevServ zs = new ZahtevServ();

                zs.serviser = lbl_serviser.Content.ToString();
                zs.datum = lbl_vreme.Content.ToString();
                zs.tekst = new TextRange(rtb_zahtev.Document.ContentStart, rtb_zahtev.Document.ContentEnd).Text;

                DC.ZahtevServs.InsertOnSubmit(zs);
                DC.SubmitChanges();
                pom = true;

            }
            catch(Exception)
            {

            }

            if (pom)
            {
                MessageBox.Show("Uspesno ste kreirali zahtev!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
        }
    }
}
