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
    /// Logique d'interaction pour VueConfigParamBdd.xaml
    /// </summary>
    public partial class VueConfigParamBdd : Window
    {
        public VueConfigParamBdd()
        {
            InitializeComponent();
            user.Text = Properties.Settings.Default.UserName;
            port.Text = Properties.Settings.Default.Port;
            pwd.Password = Properties.Settings.Default.Password;
            ip.Text = Properties.Settings.Default.Ipaddress;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.UserName = user.Text; 
            Properties.Settings.Default.Password=pwd.Password;
            Properties.Settings.Default.Port=port.Text;
            Properties.Settings.Default.Ipaddress = ip.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
