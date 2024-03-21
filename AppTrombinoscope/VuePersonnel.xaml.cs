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
using BddpersonnelContext;
using DllbddPersonnels;
using Microsoft.Win32;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour VuePersonnel.xaml
    /// </summary>
    public partial class VuePersonnel : Window
    {
        private bddpersonnels bdd;
        Byte[] img = null;
        public VuePersonnel()
        {
            InitializeComponent();
            this.MinWidth = 800;
            this.MinHeight = 500;
            this.MaxWidth = 800;
            this.MaxHeight = 700;
            if (firstname.Text != "" && name.Text != "" && phoneNumber.Text != "")
            {
                save.IsEnabled = true;
            }
           firstname.TextChanged += new TextChangedEventHandler(TextChanged);
           name.TextChanged += new TextChangedEventHandler(TextChanged);
           phoneNumber.TextChanged += new TextChangedEventHandler(TextChanged);
            try
            {
                bdd = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress,
                    Properties.Settings.Default.Port);
                List<BddpersonnelContext.Service> lists = bdd.fetchallservice();
                this.ListService.ItemsSource = lists;
                List<BddpersonnelContext.Fonction> listf = bdd.fetchallfonction();
                this.ListFonction.ItemsSource = listf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextChanged(object Sender, TextChangedEventArgs e)
        {
            if (firstname.Text != "" && name.Text != "" && phoneNumber.Text != "" && ListFonction.SelectedItem!=null && ListService!= null )
            {
                save.IsEnabled = true;
            }
            else
            {
                save.IsEnabled = false;
            }
        }


        private void Image_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:");
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            bddpersonnels co = new bddpersonnels(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Ipaddress, Properties.Settings.Default.Port);
            Personnel p = new Personnel();
            if (PhotoPersonnel.Source == null)
            {
                p = new Personnel { Telephone = phoneNumber.Text, Prenom = firstname.Text, Nom = name.Text, IdFonction = ((Fonction)ListFonction.SelectedItem).Id, IdService = ((Service)ListService.SelectedItem).Id };
            }
            else {
                p = new Personnel { Telephone = phoneNumber.Text, Prenom = firstname.Text, Nom = name.Text, IdFonction = ((Fonction)ListFonction.SelectedItem).Id, IdService = ((Service)ListService.SelectedItem).Id, Photo= img };
            }


            co.Bdd.Connection.Open();
            co.Bdd.Personnels.InsertOnSubmit(p);
            
            try{
                co.Bdd.SubmitChanges();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            co.Bdd.Connection.Close();
            MainWindow main = new MainWindow();
            main.Show();

            this.Close();
        }

        private void firstname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void ChoixPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                string file = openFileDialog.FileName;
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(file);
                image.EndInit();
                byte[] data;
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                using(MemoryStream ms = new MemoryStream())
                {
                    encoder.Save(ms);
                    data = ms.ToArray();
                }
                img = data;
                this.PhotoPersonnel.Source = image;
            }

        }

        private void ListService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (firstname.Text != "" && name.Text != "" && phoneNumber.Text != "" && ListFonction.SelectedItem != null && ListService != null)
            {
                save.IsEnabled = true;
            }
            else
            {
                save.IsEnabled = false;
            }

        }

        private void ListFonction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (firstname.Text != "" && name.Text != "" && phoneNumber.Text != "" && ListFonction.SelectedItem != null && ListService != null)
            {
                save.IsEnabled = true;
            }
            else
            {
                save.IsEnabled = false;
            }
        }
    }
}
