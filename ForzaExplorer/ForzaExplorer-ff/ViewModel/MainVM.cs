using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Data;
using System.Windows.Input;
using ForzaExplorer.Framework;
using ForzaExplorer.Services;
using ForzaExplorer.Utils;
using GalaSoft.MvvmLight.Command;

namespace ForzaExplorer.ViewModel
{
  public class MainVM : NotifyPropertyChanged
  {
    private readonly IConfigurationService _configurationService;

    public string SearchText
    {
      get { return _searchText; }
      set
      {
        SetField(ref _searchText, value, "SearchText");
        if (String.IsNullOrEmpty(value))
          FileView.Filter = null;
        else
          FileView.Filter = o => ((FileSystemInfo)o).Name.MatchSub(value);
      }
    }

    public string CurrentPath
    {
      get { return _currentPath; }
      set
      {
        SetField(ref _currentPath, value, "CurrentPath");
        var dir = new DirectoryInfo(value);
        var files = dir.EnumerateFileSystemInfos();
        FileView = new CollectionView(files);
      }
    }

    public ICollectionView FileView
    {
      get { return _fileView; }
      set { SetField(ref _fileView, value, "FileView"); }
    }

    public FileSystemInfo SelectedFile
    {
      get { return _selectedFile; }
      set { SetField(ref _selectedFile, value, "SelectedFile"); }
    }

    public ICommand NavigateUp { get; private set; }
    public ICommand NavigateDown { get; private set; }
    public ICommand SelectCommand { get; private set; }
    public ICommand GoBack { get; private set; }

    public MainVM(IConfigurationService configurationService)
    {
      _configurationService = configurationService;
      InitializeData();
      InitializeCommands();
    }

    private void InitializeData()
    {
      CurrentPath = _configurationService.HomePath;
    }

    private void InitializeCommands()
    {
      NavigateUp = new RelayCommand(() => FileView.MoveCurrentToNext());
      NavigateDown = new RelayCommand(() => FileView.MoveCurrentToPrevious());
      SelectCommand = new RelayCommand(() =>
      {
        var item = FileView.CurrentItem as FileSystemInfo;
        SearchText = string.Empty;
        if (item == null)
          return;
        if (item is FileInfo)
          System.Diagnostics.Process.Start(item.FullName);
        else if (item is DirectoryInfo)
          CurrentPath = item.FullName;
      });
      GoBack = new RelayCommand(() =>
      {
        var index = CurrentPath.LastIndexOf('\\');
        if (index > 0)
          CurrentPath = CurrentPath.Substring(0, index);
      });
    }

    private string _currentPath;
    private string _searchText;
    private FileSystemInfo _selectedFile;
    private ICollectionView _fileView;
  }
}