using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.Views;

public partial class MainViewModelPage : Page
{
    public MainViewModelPage()
    {
        InitializeComponent();
    }
    private void OnNavigateToUrlAnalyzerPage(object sender, RoutedEventArgs e)
    {
        var urlAnalyzerPage = new UrlAnalyzerPage(); 
        var frame = (Frame)Window.GetWindow(this).FindName("MainFrame");
        frame.Navigate(urlAnalyzerPage);
    }
}