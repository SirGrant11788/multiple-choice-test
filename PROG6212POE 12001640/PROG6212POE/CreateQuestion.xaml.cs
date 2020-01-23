using System;
using System.Collections.Generic;
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
using System.Threading;


namespace PROG6212POE12001640
{
    /// <summary>
    /// Interaction logic for CreateQuestion.xaml
    /// </summary>
    public partial class question : Window
    {
        int QNum = 1;
        public question()
        {
            InitializeComponent();
        }

        

        private void bommit_Click(object sender, RoutedEventArgs e)
        {
            string correctawns = "";
            try
            {
                if (A.IsChecked == true)
            {
                correctawns = a.Text;
            }
            if (B.IsChecked == true)
            {
                correctawns = b.Text;
            }
            if (C.IsChecked == true)
            {
                correctawns = c.Text;
            }
            if (D.IsChecked == true)
            {
                correctawns = d.Text;
            }
            SqlConnection sqlstrinmg = new SqlConnection("");
                sqlstrinmg.Open();
                SqlCommand @in = new SqlCommand("INSERT INTO QUESTIONNAIRE (MODCODE, TESTNUM, Q, QA, QB, QC, QD, QCORR, QNUM) VALUES ('" + textMod.Text.ToUpper() + "','" + int.Parse(testnumbers.Text) + "','" + Question.Text + "','" + a.Text + "','" + b.Text + "','" + c.Text + "','" + d.Text + "','" + correctawns + "'," + QNum++ + ")", sqlstrinmg);
                @in.ExecuteNonQuery();
                sqlstrinmg.Close();

                empty();
                Mod.Visibility = Visibility.Hidden;
                textMod.Visibility = Visibility.Hidden;
                testnumber.Visibility = Visibility.Hidden;
                testnumbers.Visibility = Visibility.Hidden;
                done.Visibility = Visibility.Visible;
        }
            catch (Exception)
            {
                MessageBox.Show("Error saving to the database!");
            }
}

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            Thread one = new Thread(empty);
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
            one.Start();
            this.Hide();
        }

        public void empty()
        {
            Question.Text = "";
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
            A.IsChecked = false;
            B.IsChecked = false;
            C.IsChecked = false;
            D.IsChecked = false;
        }
    }
}























//foreach (var A in As)
//{
//    SqlCommand AI = new SqlCommand("INSERT INTO QUESTIONNAIRE (MODCODE, TESTNUM, QA) VALUES ('" + tbxMod.Text.ToUpper() + "', '" + int.Parse(tbxTestN.Text) + "','" + A + "')", sq);
//    AI.ExecuteNonQuery();
//}
//foreach (var B in Bs)
//{
//    SqlCommand BI = new SqlCommand("INSERT INTO QUESTIONNAIRE (MODCODE, TESTNUM, QB) VALUES ('" + tbxMod.Text.ToUpper() + "', '" + int.Parse(tbxTestN.Text) + "','" + B + "')", sq);
//    BI.ExecuteNonQuery();
//}
//foreach (var C in Cs)
//{
//    SqlCommand CI = new SqlCommand("INSERT INTO QUESTIONNAIRE (MODCODE, TESTNUM, QC) VALUES ('" + tbxMod.Text.ToUpper() + "', '" + int.Parse(tbxTestN.Text) + "','" + C + "')", sq);
//    CI.ExecuteNonQuery();
//}
//foreach (var D in Ds)
//{
//    SqlCommand DI = new SqlCommand("INSERT INTO QUESTIONNAIRE (MODCODE, TESTNUM, QD) VALUES ('" + tbxMod.Text.ToUpper() + "', '" + int.Parse(tbxTestN.Text) + "','" + D + "')", sq);
//    DI.ExecuteNonQuery();
//}