using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Viewer4WSCAD.Controls
{
    public class PointsToPointCollectionConv : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            PointCollection points = new PointCollection();
            if (values.Length == 0)
                return points;
            foreach (var v in values)
            {
                if (v.GetType() != typeof(Point))
                    continue;
                var p = (Point)v;
                points.Add(p);
            }
            return points;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new object[] { new Point(), new Point(), new Point() };
        }
    }

    public class MarginConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null)
                return new Thickness();
            if (values.Length < 2)
                return new Thickness();
            if (values[0] == null)
                return new Thickness();
            if (values[1] == null)
                return new Thickness();
            try
            {
                Thickness margin = new Thickness
                {
                    Left = (double)values[0],
                    Right = 0,
                    Top = (double)values[1],
                    Bottom = 0
                };
                return margin;
            }
            catch
            {
                return new Thickness();
            }

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }



    public class MakeYReversed : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 0)
                return null;
            if (values[0].GetType() != typeof(double) || values[0].GetType() != typeof(double))
                return null;
            double x = (double)values[0];
            double height = (double)values[1];
            return height - x;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new object[] { 0, 0 };
        }
    }





    public class Color2BrushConv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            if (value.GetType() != typeof(Color))
                return value;
            var c = (Color)value;
            return new SolidColorBrush(c);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

}
