using System.Collections.Generic;
using System.ComponentModel;
using GalaSoft.MvvmLight;

namespace ForzaExplorer.Framework
{
  /// <summary>
  /// Abstract base class that implements the INotifyPropertyChanged interface with some utility methods to write properties
  /// </summary>
  public abstract class NotifyPropertyChanged :ViewModelBase, INotifyPropertyChanged
  {
    public new event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }
    protected bool SetField<T>(ref T field, T value, params string[] propertyNames)
    {
      if (EqualityComparer<T>.Default.Equals(field, value)) return false;
      field = value;
      foreach (var s in propertyNames)
      {
        OnPropertyChanged(s);        
      }
      return true;
    }
  }
}