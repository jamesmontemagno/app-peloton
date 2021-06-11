using System;
using System.Globalization;
using Xamarin.Forms;

namespace FitnessApp.Converters
{
    public class IsBookmarkedConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (bool)value ? "FASolid" : "FARegular";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
