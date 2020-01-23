using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace PROG6212POE12001640
{
    /// <summary>
    /// Interaction logic for TakeTest.xaml
    /// </summary>
    public partial class Test_Take : Window
    {
        List<int> markss = new List<int>();
        string core = "", awns = "";
        public Test_Take()
        {
            InitializeComponent();
        }
        int numberQ = 1;


        private void mark_Click(object sender, RoutedEventArgs e)
        {
            int mark = 0, totalMarks = 0;
            foreach (var marks in markss)
            {
                mark += marks;
                totalMarks++;
            }
            MessageBox.Show("You recieved: " + mark.ToString() + " out of " + totalMarks);
            Memo memorandom = new Memo();
            memorandom.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }


        private void load_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnection sqlvar = new SqlConnection("Data Source=VCSDSTDCR5PC-45;Initial Catalog=PROGPOE;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlvar.Open();
            //SqlCommand cmd = new SqlCommand(/*"SELECT * FROM QUESTIONNAIRE WHERE MODCODE = '" + tbxMod.Text.ToUpper() + "' AND TESTNUM = '" + tbxTestN.Text + "' AND QNUM = '" + numQ+ "'", sq*/);
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM QUESTIONNAIRE WHERE MODCODE = '" + tbxMod.Text.ToUpper() + "' AND TESTNUM = '" + tbxTestN.Text + "' AND QNUM = '" + numberQ + "'", sqlvar);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            lblQ.Content = dt.Rows[0][2]; 
            a.Content = dt.Rows[0][3];
            b.Content = dt.Rows[0][4];
            c.Content = dt.Rows[0][5];
            d.Content = dt.Rows[0][6];
            core = dt.Rows[0][7].ToString();
            numberQ++;

        }

       

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            
            try {

               
                if (a.IsChecked == true)
                {
                    awns = a.Content.ToString();
                }
                if (b.IsChecked == true)
                {
                    awns = b.Content.ToString();
                }
                if (c.IsChecked == true)
                {
                    awns = c.Content.ToString();
                }
                if (d.IsChecked == true)
                {
                    awns = d.Content.ToString();
                }
                if (awns.Equals(core))
                {
                    markss.Add(1);
                } else
                {
                    markss.Add(0);
                }
                SqlConnection sq = new SqlConnection("Data Source=VCSDSTDCR5PC-45;Initial Catalog=PROGPOE;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                sq.Open();
                //SqlCommand cmd = new SqlCommand(/*"SELECT * FROM QUESTIONNAIRE WHERE MODCODE = '" + tbxMod.Text.ToUpper() + "' AND TESTNUM = '" + tbxTestN.Text + "' AND QNUM = '" + numQ+ "'", sq*/);
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM QUESTIONNAIRE WHERE MODCODE = '" + tbxMod.Text.ToUpper() + "' AND TESTNUM = '" + tbxTestN.Text + "' AND QNUM = '" + numberQ + "'", sq);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                lblQ.Content = dt.Rows[0][2];
                a.Content = dt.Rows[0][3];
                b.Content = dt.Rows[0][4];
                c.Content = dt.Rows[0][5];
                d.Content = dt.Rows[0][6];
                core = dt.Rows[0][7].ToString();
                numberQ++;
            }
            catch (Exception)
            {
                MessageBox.Show("Complete!");
                btnMark.Visibility = Visibility.Visible;
            }
            
        }
    }
}
