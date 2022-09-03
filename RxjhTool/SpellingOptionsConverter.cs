namespace RxjhTool
{
    using System;
    using System.ComponentModel;
    using System.Globalization;

    public class SpellingOptionsConverter : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return ((sourceType == typeof(string)) || base.CanConvertFrom(context, sourceType));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return ((destinationType == typeof(坐标类)) || base.CanConvertTo(context, destinationType));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                object obj2;
                try
                {
                    string str = (string) value;
                    int index = str.IndexOf(':');
                    int num2 = str.IndexOf(',');
                    if ((index != -1) && (num2 != -1))
                    {
                        str.Substring(index + 1, (num2 - index) - 1);
                        index = str.IndexOf(':', num2 + 1);
                        num2 = str.IndexOf(',', num2 + 1);
                        str.Substring(index + 1, (num2 - index) - 1);
                        index = str.IndexOf(':', num2 + 1);
                        str.Substring(index + 1);
                        坐标类 坐标类 = new 坐标类();
                        obj2 = 坐标类;
                    }
                    else
                    {
                        goto Label_00A5;
                    }
                }
                catch
                {
                    throw new ArgumentException("无法将“" + ((string) value) + "”转换为 SpellingOptions 类型");
                }
                return obj2;
            }
        Label_00A5:
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if ((destinationType == typeof(string)) && (value is 坐标类))
            {
                坐标类 坐标类 = (坐标类) value;
                return string.Concat(new object[] { "地图ID:", 坐标类.地图ID, "，坐标X: ", 坐标类.坐标X, "，坐标Y: ", 坐标类.坐标Y });
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}

