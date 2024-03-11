﻿using System;
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
    /// Logique d'interaction pour VueServiceFonction.xaml
    /// </summary>
    public partial class VueServiceFonction : Window
    {
        public VueServiceFonction()
        {
            InitializeComponent();
            this.MinHeight = 500;
            this.MinWidth = 800;
            this.MaxHeight = 700;
            this.MaxWidth = 800;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
