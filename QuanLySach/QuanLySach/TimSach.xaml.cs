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
//
using System.Data;
using System.Data.SqlClient;
using QuanLySach.Books;
using System.Configuration;
namespace QuanLySach
{
    /// <summary>
    /// Interaction logic for TimSach.xaml
    /// </summary>
    public partial class TimSach : Window
    {
        public TimSach()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DbBook.openConnection();

            DbBook.sql = "SELECT * FROM Sach;";
            DbBook.cmd.CommandType = CommandType.Text;
            DbBook.cmd.CommandText = DbBook.sql;

            DbBook.da = new SqlDataAdapter(DbBook.cmd);
            DbBook.dt = new DataTable();
            DbBook.da.Fill(DbBook.dt);

            ListView.ItemsSource = DbBook.dt.DefaultView;

            DbBook.closeConnection();
        }
    }
}
