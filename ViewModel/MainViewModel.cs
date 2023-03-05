
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp2.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel() 
    {
        items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [ICommand]
    void Add()
    {
        if (string.IsNullOrEmpty(Text))
            return;

        items.Add(Text);
        // add our item
        Text= string.Empty;
    }

    [ICommand]
    void Delete(string s)
    {
        if(items.Contains(s))
        {
            Items.Remove(s);
        }
    }
  
}
