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

    public partial class Radnik : Window
    {

       
        public Radnik()
        {
            InitializeComponent();
            lbl_vreme.Content = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void btn_radniNalog_Click(object sender, RoutedEventArgs e)
        {
            RadniNalog rn = new RadniNalog();
            rn.tb_imeRadnika.Text = lbl_imeRadnika.Content.ToString();
            rn.Show();

        }

        private void btn_rNalozi_Click(object sender, RoutedEventArgs e)
        {
            Rnalozi r = new Rnalozi();
            r.Show();
        }

        private void btn_zahtevi_Click(object sender, RoutedEventArgs e)
        {
            Zahtevi z = new Zahtevi();
            z.Show();
        }

        private void btn_traziDeo_Click(object sender, RoutedEventArgs e)
        {
            TraziRezDeo td = new TraziRezDeo();
            td.Show();
        }

        private void btn_izmeniDeo_Click(object sender, RoutedEventArgs e)
        {
            IzmeniDeo id = new IzmeniDeo();
            id.Show();
        }

        private void btn_dodajDeo_Click(object sender, RoutedEventArgs e)
        {
            DodajRezDeo drd = new DodajRezDeo();
            drd.Show();
        }

        private void btn_racuni_Click(object sender, RoutedEventArgs e)
        {
            Racuni r = new Racuni();
            r.Show();
        }

        private void btn_odjava_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mail = new MainWindow();
            MessageBoxResult result =  MessageBox.Show("Da li zelite da se odjavite?", "Obavestenje", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                mail.Show();
                this.Close();
            }
            
            

        }

        private void btn_racun_Click(object sender, RoutedEventArgs e)
        {
            NoviRacun nr = new NoviRacun();
            nr.Show();
        }
    }
}
