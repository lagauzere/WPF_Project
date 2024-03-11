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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DllbddPersonnels;


namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MinWidth = 850;
            this.MaxWidth = 850;
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            bddpersonnels co = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress, Properties.Settings.Default.Port);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ParamBdd_Click(object sender, RoutedEventArgs e)
        {
            VueConfigParamBdd vueConfigbdd = new VueConfigParamBdd();

            vueConfigbdd.Show();
        }

        private void Personnels_Click(object sender, RoutedEventArgs e)
        {
            VuePersonnel vuePersonnel = new VuePersonnel();
            vuePersonnel.Show();
        }

        private void GestService_Click(object sender, RoutedEventArgs e)
        {
            VueServiceFonction vueService = new VueServiceFonction();
            vueService.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
