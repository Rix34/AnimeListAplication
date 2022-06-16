using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace AnimeListApplication
{
    /// <summary>
    /// Logika interakcji dla klasy LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Msi\source\repos\AnimeListAplication\AnimeListApplication\AnimeListApplication\AnimeDataBase.mdf;Integrated Security=True");

            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                string query = "SELECT COUNT (1) From LoginData WHERE Nickname = @Nickname AND  Password=@Password";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nickname", UserName.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nickname or password  is incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
