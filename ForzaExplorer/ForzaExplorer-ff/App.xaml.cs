using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace ForzaExplorer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
