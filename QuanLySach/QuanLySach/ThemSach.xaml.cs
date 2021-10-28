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
using System.Configuration;
using QuanLySach.Books;

namespace QuanLySach
{
    /// <summary>
    /// Interaction logic for ThemSach.xaml
    /// </summary>
    public partial class ThemSach : Window
    {
        public ThemSach()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bindlistview()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * From [Sach]";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Books");
            da.Fill(dt);
        }

        private void AddButton_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into [Sach] (MaSach,TênSach ,TacGia,TheLoai,NXB)"
                   + "values(@MaSach,@TênSach ,@TacGia,@TheLoai,@NXB)";
            cmd.Parameters.AddWithValue("@MaSach", textbox1.Text);
            cmd.Parameters.AddWithValue("@TênSach", textbox2.Text);
            cmd.Parameters.AddWithValue("@TacGia", textbox3.Text);
            cmd.Parameters.AddWithValue("@TheLoai", textbox4.Text);
            cmd.Parameters.AddWithValue("@NXB", textbox5.Text);
            cmd.Connection = con;
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("Data add Sucessfully");
                bindlistview();

            }
        }

        private void DeleteButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListView1.SelectedItems.Count > 0) ;
            {
                DataRowView dtr = (DataRowView)ListView1.SelectedItem;

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NP4Q38C;Initial Catalog=QuanLySach;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM [Sach] WHERE (MaSach) = @MaSach";
                cmd.Parameters.AddWithValue("@MaSach", textbox1.Text);
                cmd.Connection = con;
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete data add Sucessfully");
                    bindlistview();

                }
            }
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

            ListView1.ItemsSource = DbBook.dt.DefaultView;

            DbBook.closeConnection();
        }
    }
}
