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

namespace WpfDrivingSchool
{
    /// <summary>
    /// Logique d'interaction pour Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Moniteur(object sender, RoutedEventArgs e)
        {
            Main.Content = new Moniteur();
        }

        private void Client(object sender, RoutedEventArgs e)
        {
            Main.Content = new Client();
        }
    }
}
