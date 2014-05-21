using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Data;
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
      set
      {
        SetField(ref _searchText, value, "SearchText");
        if (String.IsNullOrEmpty(value))
          FileView.Filter = null;
        else
          FileView.Filter = o => ((FileSystemInfo)o).Name.ContainsIgnore( value);
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
    private FileSystemInfo _selectedFile;
    private ICollectionView _fileView;
  }

  public static class StringExtensions
  {


    /// <summary>
    /// Check if the string contains the specified string ignoring the case options specified by the culture
    /// </summary>
    /// <param name="text"></param>
    /// <param name="word">the string that has to be contained</param>
    /// <returns>Returns true if the string contains the word string, ignoring the case, otherwise false</returns>
    public static bool ContainsIgnore(this string text, string word)
    {
      return CultureInfo.CurrentCulture.CompareInfo.IndexOf(text, word, CompareOptions.IgnoreCase) >= 0;
    }
  }

}