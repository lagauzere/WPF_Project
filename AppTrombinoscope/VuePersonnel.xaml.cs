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
using BddpersonnelContext;
using DllbddPersonnels;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour VuePersonnel.xaml
    /// </summary>
    public partial class VuePersonnel : Window
    {
        public VuePersonnel()
        {
            InitializeComponent();
            if (firstname.Text != "" && name.Text != "" && phoneNumber.Text != "")
            {
                save.IsEnabled = true;
            }
           firstname.TextChanged += new TextChangedEventHandler(TextChanged);
           name.TextChanged += new TextChangedEventHandler(TextChanged);
           phoneNumber.TextChanged += new TextChangedEventHandler(TextChanged);
        }

        private void TextChanged(object Sender, TextChangedEventArgs e)
        {
            if (firstname.Text != "" && name.Text != "" && phoneNumber.Text != "")
            {
                save.IsEnabled = true;
            }
            else
            {
                save.IsEnabled = false;
            }
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:");
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            bddpersonnels co = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress, Properties.Settings.Default.Port);
            Personnel p = new Personnel { Telephone = phoneNumber.Text, Prenom = firstname.Text , Nom = name.Text, IdFonction= 1 , IdService= 1};
            co.Bdd.Connection.Open();
            co.Bdd.Personnels.InsertOnSubmit(p);
            try{
                co.Bdd.SubmitChanges();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            co.Bdd.Connection.Close();
        }

        private void firstname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
