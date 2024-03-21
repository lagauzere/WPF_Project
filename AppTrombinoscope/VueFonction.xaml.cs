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
using DllbddPersonnels;
using BddpersonnelContext;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour VueFonction.xaml
    /// </summary>
    public partial class VueFonction : Window
    {
        private bddpersonnels bdd;
        public VueFonction()
        {
            InitializeComponent();
            this.MinHeight = 500;
            this.MinWidth = 600;
            this.MaxHeight = 700;
            this.MaxWidth = 600;
            try
            {
                bdd = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress,
                    Properties.Settings.Default.Port);
                List<BddpersonnelContext.Fonction> list = bdd.fetchallfonction();
                this.ListFonctions.ItemsSource = list;
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

        private void TextBox_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            bdd.deleteFonction(this.nomFonctionSelectionner.Text);
            List<BddpersonnelContext.Fonction> list = bdd.fetchallfonction();
            this.ListFonctions.ItemsSource = list;
        }
    }
}
