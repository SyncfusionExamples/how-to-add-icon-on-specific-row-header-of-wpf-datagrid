using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SfDataGridDemo
{
    public class RowHeaderConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //var orderInfo = value as OrderInfo;
            if ((bool)value)
            {
                return "Images/no.png";
               // return "Images/yes.png";
            }
            else
            {
                //return "Images/yes.png";
                return null;
            }           
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
