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
    /// Interaction logic for Zahtevi.xaml
    /// </summary>
    public partial class Zahtevi : Window
    {
        public Zahtevi()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            ServisRacunara.ServisDataSet2 servisDataSet2 = ((ServisRacunara.ServisDataSet2)(this.FindResource("servisDataSet2")));
            // Load data into the table ZahtevServ. You can modify this code as needed.
            ServisRacunara.ServisDataSet2TableAdapters.ZahtevServTableAdapter servisDataSet2ZahtevServTableAdapter = new ServisRacunara.ServisDataSet2TableAdapters.ZahtevServTableAdapter();
            servisDataSet2ZahtevServTableAdapter.Fill(servisDataSet2.ZahtevServ);
            System.Windows.Data.CollectionViewSource zahtevServViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("zahtevServViewSource")));
            zahtevServViewSource.View.MoveCurrentToFirst();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Zahtev2 z = new Zahtev2();
            DataRowView row = (DataRowView)dataGrid.SelectedItems[0];

            z.broj = Convert.ToInt32(row["brZahteva"].ToString());

            z.Show();
        }
    }
}
