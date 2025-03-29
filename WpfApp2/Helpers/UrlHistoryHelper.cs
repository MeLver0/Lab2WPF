using System.Collections.ObjectModel;

namespace WpfApp2.Helpers;

public static class UrlHistoryHelper
{
    public static ObservableCollection<string> History { get; set; } = new ObservableCollection<string>();

    public static void AddToHistory(string url)
    {
        History.Insert(0, url);
    }
}