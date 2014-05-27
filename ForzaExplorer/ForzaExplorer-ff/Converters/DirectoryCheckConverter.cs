using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace ForzaExplorer.Converters
{
  public class DirectoryCheckConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (!(value is FileAttributes))
        return null;
      var attributes = (FileAttributes) value;
      if (attributes.HasFlag(FileAttributes.Directory))
        return parameter;
      return "Black";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}