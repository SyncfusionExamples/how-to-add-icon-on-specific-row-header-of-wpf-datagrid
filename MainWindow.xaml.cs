using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
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
//using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using System.ComponentModel;
using System.Collections;
using System.Globalization;
using Syncfusion.UI.Xaml.Grid.Helpers;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Lockedbutton_Click(object sender, RoutedEventArgs e)
        {
            foreach(var record in datagrid.View.Records)
            {
                var data = (record as RecordEntry).Data as OrderInfo;
                if (data.OrderID % 3 == 0)
                {
                    //To change the image at run time.
                    data.IsLocked = true;
                }
            }
        }
    }
}   

