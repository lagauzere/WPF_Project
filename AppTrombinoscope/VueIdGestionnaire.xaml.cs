using DllbddPersonnels;
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

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour VueIdGestionnaire.xaml
    /// </summary>
    public partial class VueIdGestionnaire : Window
    {
        public VueIdGestionnaire()
        {
            InitializeComponent();

            this.MinWidth = 500;
            this.MinHeight = 300;
            this.MaxHeight = 300;
            this.MaxWidth = 500;
        }

        private void Connexion(object sender, RoutedEventArgs e)
        {
            if(login.Text== "GestionnaireBDD" && mdp.Password == "Password1234@but")
            {
                bddpersonnels.Gestionnaire = true;
                Properties.Settings.Default.UserName = login.Text;
                Properties.Settings.Default.Password = mdp.Password;
                MainWindow v = new MainWindow();
                v.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("erreur de mot de passe ou de login");
            }
        }

        private void Annulerk(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
