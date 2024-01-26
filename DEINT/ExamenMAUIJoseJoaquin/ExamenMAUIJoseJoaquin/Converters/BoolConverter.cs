using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMAUIJoseJoaquin.Converters
{
    internal class BoolConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var answer = value.ToString();
            if (answer == "Justo a tiempo")
                return true;
            else
                return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var answer = value.ToString();
            if (answer == "Queda poco")
                return true;
            else
                return false;
        }
    }
}