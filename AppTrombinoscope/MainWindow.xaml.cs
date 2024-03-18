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

        private bddpersonnels bdd;
        public MainWindow()
        {
            InitializeComponent();
            Gestion_Personnels.IsEnabled = true;
            this.MinHeight = 600;
            this.MinWidth = 850;
            this.MaxWidth = 850;
            try
            {
                bdd = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress,
                    Properties.Settings.Default.Port);
                List<BddpersonnelContext.Service> list = bdd.fetchallservice();
                this.ListService.ItemsSource = list;
                List<BddpersonnelContext.Personnel> listp = bdd.fetchallpersonnels();
                this.ListPersonnel.ItemsSource = listp;
                List<BddpersonnelContext.Fonction> listf = bdd.fetchallfonction();
                this.ListFonction.ItemsSource = listf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            bddpersonnels co = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress, Properties.Settings.Default.Port);
            if (co.ConnexionStatus == true)
            {
                Liste_du_Personnel.IsEnabled = true;
                Gestion_Fonctions.IsEnabled = true;
                Gestion_Services.IsEnabled = true;
                Gestionnaire.IsEnabled = true;
            }
            else
            {
                Liste_du_Personnel.IsEnabled = false;
                Gestion_Fonctions.IsEnabled = false;
                Gestion_Services.IsEnabled = false;
                Gestionnaire.IsEnabled = false;
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ParamBdd_Click(object sender, RoutedEventArgs e)
        {
            VueConfigParamBdd vueConfigbdd = new VueConfigParamBdd();

            vueConfigbdd.Show();
        }

        private void Gestionnaire_Click(object sender, RoutedEventArgs e)
        {
            VueIdGestionnaire vue = new VueIdGestionnaire();
            vue.Show();
        }

        private void Gestion_Personnels_Click(object sender, RoutedEventArgs e)
        {
            VuePersonnel vue = new VuePersonnel();
            vue.Show();
        }


        private void ListePersonnel(object sender, RoutedEventArgs e)
        {
            VueListePersonnels vueListePersonnels = new VueListePersonnels();
            vueListePersonnels.Show();
        }

        private void GestService_Click(object sender, RoutedEventArgs e)
        {
            VueServiceFonction vueService = new VueServiceFonction();
            vueService.Show();
        }

        private void Gestion_Fonctions_Click(object sender, RoutedEventArgs e)
        {
            VueFonction vue = new VueFonction();
            vue.Show();
        }
    }
}
