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
    /// Logique d'interaction pour VueListePersonnels.xaml
    /// </summary>
    public partial class VueListePersonnels : Window
    {
        public VueListePersonnels()
        {
            InitializeComponent();
            this.MinWidth = 850;
            this.MinHeight = 500;
            this.MaxHeight = 700;
            this.MaxWidth = 850;
        }
    }
}
