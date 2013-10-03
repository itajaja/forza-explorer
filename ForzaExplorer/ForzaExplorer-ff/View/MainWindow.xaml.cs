using System.Windows;
using ForzaExplorer.ViewModel;

namespace ForzaExplorer.View
{
    /// <summary>
    /// View Class Implementation Sample
    /// </summary>
    public partial class MainWindow
    {
        public ViewModelSample ViewModel
        {
            get
            {
                return DataContext as ViewModelSample;
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the ViewSample class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

    }
}