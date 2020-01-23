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

namespace PROG6212POE12001640
{
    /// <summary>
    /// Interaction logic for Memo.xaml
    /// </summary>
    public partial class Memo : Window
    {
        public Memo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PROG6212POE12001640.PROGPOEDataSet pROGPOEDataSet = ((PROG6212POE12001640.PROGPOEDataSet)(this.FindResource("pROGPOEDataSet")));
            // Load data into the table MEMO. You can modify this code as needed.
            PROG6212POE12001640.PROGPOEDataSetTableAdapters.MEMOTableAdapter pROGPOEDataSetMEMOTableAdapter = new PROG6212POE12001640.PROGPOEDataSetTableAdapters.MEMOTableAdapter();
            pROGPOEDataSetMEMOTableAdapter.Fill(pROGPOEDataSet.MEMO);
            System.Windows.Data.CollectionViewSource mEMOViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("mEMOViewSource")));
            mEMOViewSource.View.MoveCurrentToFirst();
        }
    }
}
