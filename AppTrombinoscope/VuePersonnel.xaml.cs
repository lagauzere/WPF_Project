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

        }

        private void firstname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
