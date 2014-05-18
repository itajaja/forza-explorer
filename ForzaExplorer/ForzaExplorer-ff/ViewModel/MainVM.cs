using System.Collections.Generic;
using System.IO;
using System.Linq;
using ForzaExplorer.Framework;
using ForzaExplorer.Services;

namespace ForzaExplorer.ViewModel
{
  public class MainVM : NotifyPropertyChanged
  {
    private readonly IConfigurationService _configurationService;

    public string SearchText
    {
      get { return _searchText; }
      set { SetField(ref _searchText, value, "SearchText"); }
    }

    public string CurrentPath
    {
      get { return _currentPath; }
      set { SetField(ref _currentPath, value, "CurrentPath", "FilesList"); }
    }

    public IEnumerable<FileSystemInfo> FileList
    {
      get
      {
        var dir = new DirectoryInfo(CurrentPath);
        return dir.EnumerateFileSystemInfos();
      }
    }

    public MainVM(IConfigurationService configurationService)
    {
      _configurationService = configurationService;
      InitializeData();
    }

    private void InitializeData()
    {
      CurrentPath = _configurationService.HomePath;
    }

    ////public override void Cleanup()
    ////{
    ////    // Clean up if needed

    ////    base.Cleanup();
    ////}

    private string _currentPath;
    private string _searchText;
    private IList<string> _fileList;
  }
}