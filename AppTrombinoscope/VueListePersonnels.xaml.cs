using System;
using System.Collections.Generic;
using System.IO;
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
using DllbddPersonnels;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour VueListePersonnels.xaml
    /// </summary>
    public partial class VueListePersonnels : Window
    {

        private bddpersonnels bdd;

        public VueListePersonnels()
        {
            InitializeComponent();
            this.MinWidth = 850;
            this.MinHeight = 500;
            this.MaxHeight = 700;
            this.MaxWidth = 850;

            try
            {
                bdd = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress,
                    Properties.Settings.Default.Port);
                List<BddpersonnelContext.Personnel> listp = bdd.fetchallpersonnels();
                this.ListPersonne.ItemsSource = listp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        public static ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.BeginInit();
            biImg.StreamSource = ms;
            biImg.EndInit();

            ImageSource imgSrc = biImg as ImageSource;

            return imgSrc;
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            this.nomfilter.IsEnabled = true;
            this.prenomfilter.IsEnabled = true;
        }

        private void FilterRecherche_Click(object sender, RoutedEventArgs e)
        {
            this.ListPersonne.ItemsSource = bdd.fetchallpersonnelsfiltrer(this.nomfilter.Text, this.prenomfilter.Text);
        }
    }

}
