using ForzaExplorer.ViewModel;

namespace ForzaExplorer.View
{
  /// <summary>
  /// View Class Implementation Sample
  /// </summary>
  public partial class MainWindow
  {
    public MainVM ViewModel
    {
      get
      {
        return DataContext as MainVM;
      }
    }

    /// <summary>
    /// Initializes a new instance of the ViewSample class.
    /// </summary>
    public MainWindow()
    {
      InitializeComponent();
      SearchBox.Focus();
      Closing += (s, e) => ViewModelLocator.Cleanup();
    }

  }
}