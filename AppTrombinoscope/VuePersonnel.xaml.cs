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
    /// Logique d'interaction pour VuePersonnel.xaml
    /// </summary>
    public partial class VuePersonnel : Window
    {
        public VuePersonnel()
        {
            InitializeComponent();
            this.MinWidth = 800;
            this.MinHeight = 500;
            this.MaxWidth =  800;
            this.MaxHeight = 700;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
