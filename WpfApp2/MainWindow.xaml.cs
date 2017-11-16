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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        #region MySqlConnection
        MySqlConnection conn = new MySqlConnection("Server=localhost;userid=root;password=;Database=yay");
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region Bind Data to DataGrid
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                ClientGrid.DataContext = ds;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO customer(name,lastName,Adress) VALUES(Ivan, DesSandwichs, 15 rue de la Guillotière)");
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                ClientGrid.DataContext = ds;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void TabablzControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
