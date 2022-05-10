using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Extensions;

public static class EnumExtension
{
    public static string DescriptionAttr<T>(this T source)
    {
        var fi = source.GetType().GetField(source.ToString() ?? string.Empty);

        if (fi is null)
            return source.ToString();

        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
            typeof(DescriptionAttribute), false);

        return attributes.Length > 0 ? attributes[0].Description : source.ToString();
    }
    public static string DisplayAttr<T>(this T source)
    {
        var fi = source.GetType().GetField(source.ToString() ?? string.Empty);

        if (fi is null)
            return source.ToString();

        var attributes = (DisplayAttribute[])fi.GetCustomAttributes(
            typeof(DisplayAttribute), false);

        return attributes.Length > 0 ? attributes[0].Name : source.ToString();
    }
}