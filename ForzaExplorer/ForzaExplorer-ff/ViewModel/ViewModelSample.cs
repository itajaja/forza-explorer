using ForzaExplorer.Framework;
using ForzaExplorer.Model;
using GalaSoft.MvvmLight;

namespace ForzaExplorer.ViewModel
{
  /// <summary>
  /// ViewModel Class Implementation Sample
  /// <para>
  /// See http://www.galasoft.ch/mvvm
  /// </para>
  /// </summary>
  public class MainVM : NotifyPropertyChanged
  {
    private readonly IDataService _dataService;

    private double _number;
    public double Number
    {
      get { return _number; }
      set { SetField(ref _number, value, "Number"); }
    }

    public MainVM(IDataService dataService)
    {
      _dataService = dataService;
      Number = 4;
    }

    ////public override void Cleanup()
    ////{
    ////    // Clean up if needed

    ////    base.Cleanup();
    ////}
  }
}