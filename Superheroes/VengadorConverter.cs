
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Superheroes
{
    class VengadorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage bi3 = new BitmapImage();
            
            if ((bool)value)
            {
                bi3.BeginInit();
                bi3.UriSource = new Uri("assets/avengers.png", UriKind.Relative);
                bi3.EndInit();
                return bi3;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
