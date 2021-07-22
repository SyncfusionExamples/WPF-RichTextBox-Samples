using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Sample
{
    /// <summary>
    /// Specifies the List value to Toggle converter.
    /// </summary>
    /// <remarks></remarks>
    internal class ListToggleConverter : IValueConverter
    {
        /// <summary>
        /// Converts the List value to Toggle.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && parameter != null && value.ToString() == parameter.ToString())
                return true;
            return false;
        }
        /// <summary>
        /// Converts the Toggle value to List.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (parameter == null)
                return null;
            return parameter.ToString();
        }
    }

    /// <summary>
    /// Specifies the Double value to Percentage converter
    /// </summary>
    public class DoublePercentageConverter : IValueConverter
    {
        /// <summary>
        /// Converts the percentage value to double.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double factor = (double)value;
            return (int)(factor / 100);
        }
        /// <summary>
        /// Converts the double value to percentage.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)value * 100;
        }
    }

    /// <summary>
    /// Specifies the Double value to String converter
    /// </summary>
    public class DoubleStringConverter : IValueConverter
    {
        /// <summary>
        /// Converts the double value to string.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double factor = (double)value;
            if (factor > 0)
                return Math.Round((double)value, 2).ToString();
            return " ";
        }
        /// <summary>
        /// Converts the string value to double.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double size = 0d;
            if (value != null)
                double.TryParse(value.ToString(), out size);
            return size;
        }
    }

    /// <summary>
    /// Specifies the Line spacing value to Toggle converter
    /// </summary>
    public class LineSpacingToggleConverter : IValueConverter
    {
        /// <summary>
        /// Converts the Line spacing value to Toggle.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double lineSpacing = Math.Round((double)value, 2);
            if (lineSpacing.ToString() == parameter.ToString())
                return true;
            return false;
        }
        /// <summary>
        /// Converts the Toggle value to Line spacing.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double lineSpacing = double.Parse(parameter.ToString());
            return lineSpacing;
        }
    }

    /// <summary>
    /// Specifies the HighlightColor value to Toggle converter
    /// </summary>
    /// <remarks></remarks>
    internal class HighlightColorToggleConverter : IValueConverter
    {
        /// <summary>
        /// Converts the specified Highlight color value to selected value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="parameter">The parameter.</param>
        /// <param name="language">The language.</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            if (value == null || !(value is HighlightColor?))
                return false;
            HighlightColor color = (HighlightColor)value;
            switch (int.Parse((string)parameter))
            {
                case 0: return (color == HighlightColor.Yellow) ? true : false;
                case 1: return (color == HighlightColor.BrightGreen) ? true : false;
                case 2: return (color == HighlightColor.Turquoise) ? true : false;
                case 3: return (color == HighlightColor.Pink) ? true : false;
                case 4: return (color == HighlightColor.Blue) ? true : false;
                case 5: return (color == HighlightColor.Red) ? true : false;
                case 6: return (color == HighlightColor.DarkBlue) ? true : false;
                case 7: return (color == HighlightColor.Teal) ? true : false;
                case 8: return (color == HighlightColor.Green) ? true : false;
                case 9: return (color == HighlightColor.Violet) ? true : false;
                case 10: return (color == HighlightColor.DarkRed) ? true : false;
                case 11: return (color == HighlightColor.DarkYellow) ? true : false;
                case 12: return (color == HighlightColor.Gray50) ? true : false;
                case 13: return (color == HighlightColor.Gray25) ? true : false;
                case 14: return (color == HighlightColor.Black) ? true : false;
                case 15: return (color == HighlightColor.NoColor) ? true : false;
            }
            return false;
        }
        /// <summary>
        /// Converts the selected parameter to Highlight color.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="parameter">The parameter.</param>
        /// <param name="language">The language.</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            switch (int.Parse((string)parameter))
            {
                case 0: return HighlightColor.Yellow;
                case 1: return HighlightColor.BrightGreen;
                case 2: return HighlightColor.Turquoise;
                case 3: return HighlightColor.Pink;
                case 4: return HighlightColor.Blue;
                case 5: return HighlightColor.Red;
                case 6: return HighlightColor.DarkBlue;
                case 7: return HighlightColor.Teal;
                case 8: return HighlightColor.Green;
                case 9: return HighlightColor.Violet;
                case 10: return HighlightColor.DarkRed;
                case 11: return HighlightColor.DarkYellow;
                case 12: return HighlightColor.Gray50;
                case 13: return HighlightColor.Gray25;
                case 14: return HighlightColor.Black;
                default: return HighlightColor.NoColor;
            }
        }
    }
}
