namespace DemoMVVMAprendices.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using Xamarin.Forms;

    public class PromedioColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var promedio = (double)value;
            return promedio < 500 ? Color.Red : Color.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}