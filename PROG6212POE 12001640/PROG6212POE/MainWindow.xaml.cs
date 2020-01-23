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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace PROG6212POE12001640
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void lblRegister_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            register register = new register();
            register.ShowDialog();
            this.Hide();
        }

        public MainWindow()
        {
            InitializeComponent();
        }



        private void login_Click(object sender, RoutedEventArgs e)
        {
            try {
                SqlConnection sql = new SqlConnection("");
                sql.Open();
                SqlDataAdapter selen = new SqlDataAdapter("SELECT * FROM LOGIN WHERE USERN = '" + user.Text + "' AND PASS = '" + ppass.Password + "'", sql);
                DataTable dt = new DataTable();
                selen.Fill(dt);
                //Class1.login();
                if (dt.Rows[0][2].Equals("1"))
                {
                    question create = new question();
                    create.ShowDialog();
                    this.Close();
                }
                else if (dt.Rows[0][2].Equals("0"))
                {
                    Test_Take t = new Test_Take();
                    t.ShowDialog();
                    this.Close();
                }
            } catch
            {
                MessageBox.Show("Does not exist!");
                register r = new register();
                r.ShowDialog();
                this.Hide();
            }
        }


   
       
    }
}
