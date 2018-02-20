using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFTest.Converters
{
    class PropertyMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            object selectedItem = values[0];
            string displayMemberPath = values[1] as string;

            if (selectedItem != null)
            {
                ParameterExpression param = Expression.Parameter(selectedItem.GetType(), "x");
                MemberExpression body = Expression.Property(param, displayMemberPath);
                LambdaExpression lambda = Expression.Lambda(body, param);
                Delegate expression = lambda.Compile();

                var val = expression.DynamicInvoke(selectedItem);
                return val;
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
