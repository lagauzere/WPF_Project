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
        }

        private void Connexion(object sender, RoutedEventArgs e)
        {
            if(login.Text== "UtilisateurBDD" && mdp.Text == "Password1234@")
            {
                bddpersonnels.Gestionnaire = true;
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
    }
}
