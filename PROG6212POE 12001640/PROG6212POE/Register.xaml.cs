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
using System.Data.SqlClient;

namespace PROG6212POE12001640
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class register : Window
    {


        private void begister(object sender, RoutedEventArgs e)
        {
            SqlConnection sq = new SqlConnection("");

            sq.Open();
            MainWindow menu = new MainWindow();
            if (pass.Password.Equals(pbPass2.Password))
            {
                if (rdbLecturer.IsChecked == true)
                {
                    SqlCommand ins = new SqlCommand("INSERT INTO LOGIN (USERN, PASS, USERTYPE) VALUES ('" + tbxUser.Text + "', '" + pass.Password + "', " + "'1')", sq);
                    ins.ExecuteNonQuery();
                    sq.Close();
                    menu.ShowDialog();
                    this.Hide();
                }
                else
                {
                    SqlCommand ins = new SqlCommand("INSERT INTO LOGIN (USERN, PASS, USERTYPE) VALUES ('" + tbxUser.Text + "', '" + pass.Password + "', " + "'0')", sq);
                    ins.ExecuteNonQuery();
                    sq.Close();
                    menu.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Passwords invalid");
            }
        }




        public register()
        {
            InitializeComponent();
        }

        private void lec(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
