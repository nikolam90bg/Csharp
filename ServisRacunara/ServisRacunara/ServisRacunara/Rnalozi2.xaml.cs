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
    /// Interaction logic for Rnalozi2.xaml
    /// </summary>
    public partial class Rnalozi2 : Window
    {
        public Rnalozi2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ServisRacunara.ServisDataSet1 servisDataSet1 = ((ServisRacunara.ServisDataSet1)(this.FindResource("servisDataSet1")));
            // Load data into the table RadNalog. You can modify this code as needed.
            ServisRacunara.ServisDataSet1TableAdapters.RadNalogTableAdapter servisDataSet1RadNalogTableAdapter = new ServisRacunara.ServisDataSet1TableAdapters.RadNalogTableAdapter();
            servisDataSet1RadNalogTableAdapter.Fill(servisDataSet1.RadNalog);
            System.Windows.Data.CollectionViewSource radNalogViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("radNalogViewSource")));
            radNalogViewSource.View.MoveCurrentToFirst();
        }

        private void btn_otvori_Click(object sender, RoutedEventArgs e)
        {
            RNalog02 rn = new RNalog02();
            DataRowView row = (DataRowView)dataGrid.SelectedItems[0];

            rn.tb_sifNaloga.Text = row["sifraNaloga"].ToString();
            rn.Show();
        }
    }
}
