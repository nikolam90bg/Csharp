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
    /// Interaction logic for Rnalozi.xaml
    /// </summary>
    public partial class Rnalozi : Window
    {
        public Rnalozi()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            ServisRacunara.ServisDataSet servisDataSet = ((ServisRacunara.ServisDataSet)(this.FindResource("servisDataSet")));
            // Load data into the table RadNalog. You can modify this code as needed.
            ServisRacunara.ServisDataSetTableAdapters.RadNalogTableAdapter servisDataSetRadNalogTableAdapter = new ServisRacunara.ServisDataSetTableAdapters.RadNalogTableAdapter();
            servisDataSetRadNalogTableAdapter.Fill(servisDataSet.RadNalog);
            System.Windows.Data.CollectionViewSource radNalogViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("radNalogViewSource")));
            radNalogViewSource.View.MoveCurrentToFirst();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RNalog01 rn = new RNalog01();

            DataRowView row = (DataRowView)dataGrid.SelectedItems[0];

        
        
            rn.tb_sifNaloga.Text = row["sifraNaloga"].ToString();
            //rn.tb_imePrezime.Text = row["imePrezime"].ToString();
            //rn.tb_brLicne.Text = row["brLicne"].ToString();
            //rn.tb_telefon.Text = row["telefon"].ToString();
            //rn.tb_sifRacunara.Text = row["sifraRac"].ToString();
            rn.Show();
        }
    }
}
