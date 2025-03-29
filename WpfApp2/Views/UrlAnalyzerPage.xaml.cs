using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.Views;

public partial class UrlAnalyzerPage : Page
{
    public UrlAnalyzerPage()
    {
        InitializeComponent();
    }
    private void OnBackToMainViewModelPage(object sender, RoutedEventArgs e)
    {
        var frame = (Frame)Window.GetWindow(this).FindName("MainFrame");
        frame.GoBack();
    }
}