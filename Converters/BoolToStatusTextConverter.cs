using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace DairyFarm.Converters
{
    public class BoolToStatusTextConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool isBusy)
            {
                string role = parameter as string ?? "Работник";
                return isBusy ? $"{role}: Занят" : $"{role}: Свободен";
            }
            return "Статус: Неизвестен";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}