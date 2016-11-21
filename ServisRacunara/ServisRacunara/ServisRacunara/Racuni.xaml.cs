using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Racuni.xaml
    /// </summary>
    public partial class Racuni : Window
    {
        public Racuni()
        {
            InitializeComponent();
        }

        private void btn_otvori_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.Items.Count <= 0)
            {
                MessageBox.Show("Nema naloga za otvaranje!", "Obavestenje!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Racun2 r2 = new Racun2();

                
                DataRowView row = (DataRowView)dataGrid.SelectedItems[0];

                r2.tb_sifraRacuna.Text = row["sifraRacuna"].ToString();

                r2.Show();


                
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ServisRacunara.ServisDataSet3 servisDataSet3 = ((ServisRacunara.ServisDataSet3)(this.FindResource("servisDataSet3")));
            // Load data into the table RacunVlasnika. You can modify this code as needed.
            ServisRacunara.ServisDataSet3TableAdapters.RacunVlasnikaTableAdapter servisDataSet3RacunVlasnikaTableAdapter = new ServisRacunara.ServisDataSet3TableAdapters.RacunVlasnikaTableAdapter();
            servisDataSet3RacunVlasnikaTableAdapter.Fill(servisDataSet3.RacunVlasnika);
            System.Windows.Data.CollectionViewSource racunVlasnikaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("racunVlasnikaViewSource")));
            racunVlasnikaViewSource.View.MoveCurrentToFirst();
        }
    }
}
