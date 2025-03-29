using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WpfApp2.Helpers;

namespace WpfApp2.ViewModels;

public class UrlAnalyzerViewModel : INotifyPropertyChanged
{
    public string Url { get; set; }
    public string Scheme { get; set; }
    public string Host { get; set; }
    public string Port { get; set; }
    public string Path { get; set; }
    public string Query { get; set; }
    public string Fragment { get; set; }
    
    public string PingResult { get; set; }
    public string DnsInfo { get; set; }
    public string AddressType { get; set; }
    
    public ICommand AnalyzeCommand { get; }

    
    public ObservableCollection<string> UrlHistory => UrlHistoryHelper.History;
    public UrlAnalyzerViewModel()
    {
        // Привязываем команду к методу AnalyzeUrl
        AnalyzeCommand = new RelayCommand(AnalyzeUrl);
    }

    private void AnalyzeUrl()
    {
        if (Uri.TryCreate(Url, UriKind.Absolute, out Uri uri))
        {
            
            UrlHistoryHelper.AddToHistory(Url);
            
            Scheme = uri.Scheme;
            Host = uri.Host;
            Port = uri.Port.ToString();
            Path = uri.AbsolutePath;
            Query = uri.Query;
            Fragment = uri.Fragment;
            
            PingResult = PingHelper.PingHost(Host) ? "Host is reachable" : "Host is unreachable";
            DnsInfo = DnsHelper.GetDnsInfo(Host);
            AddressType = AddressHelper.GetAddressType(uri.Host);
            
            OnPropertyChanged(nameof(Scheme));
            OnPropertyChanged(nameof(Host));
            OnPropertyChanged(nameof(Port));
            OnPropertyChanged(nameof(Path));
            OnPropertyChanged(nameof(Query));
            OnPropertyChanged(nameof(Fragment));
            OnPropertyChanged(nameof(PingResult));
            OnPropertyChanged(nameof(DnsInfo));
            OnPropertyChanged(nameof(AddressType));
            OnPropertyChanged(nameof(UrlHistory));
            
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}