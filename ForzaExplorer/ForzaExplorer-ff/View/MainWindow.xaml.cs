using System.Windows;
using ForzaFramework.ViewModel;
using ForzaFramework.ViewModel;

namespace ForzaFramework
{
    /// <summary>
    /// View Class Implementation Sample
    /// </summary>
    public partial class ViewSample
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
        public ViewSample()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

    }
}