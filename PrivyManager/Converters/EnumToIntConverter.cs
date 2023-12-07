using Avalonia.Data.Converters;
using PrivyManager.Enums;
using System;
using System.Globalization;

namespace PrivyManager.Converters
{
    public class EnumToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (MenuItems)value;
        }
    }
}
