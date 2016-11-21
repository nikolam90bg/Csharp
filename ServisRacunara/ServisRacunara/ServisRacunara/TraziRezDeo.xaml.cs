using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TraziRezDeo.xaml
    /// </summary>
    public partial class TraziRezDeo : Window
    {
        public TraziRezDeo()
        {
            InitializeComponent();





        }

        private void btn_trazi_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();

       
           

            ServisRacunaraDataContext DC = new ServisRacunaraDataContext();

            Deo d = new Deo();
            
                try
                {
                String marka = ((ComboBoxItem)cb_marka.SelectedItem).Content.ToString();
                String vrsta = ((ComboBoxItem)cb_vrsta.SelectedItem).Content.ToString();


                var podaciDC = from x in DC.RezervniDeos where (x.marka == marka && x.vrsta==vrsta) select x;


                    foreach (var podaci in podaciDC)
                    {


                        listView.Items.Add(new Deo { Model = podaci.model.ToString(), Kolicina = podaci.kolicina.ToString(), Cena = podaci.cena.ToString() });

                    }

                if (listView.Items.Count == 0)
                {
                    MessageBox.Show("Ne postoji takav trazeni deo!", "OBAVESTENJE", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }


                }

                catch (Exception)
                {
                MessageBox.Show("Morate uneti MARKU i VRSTU!", "OBAVESTENJE", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            
        }
    }
}
