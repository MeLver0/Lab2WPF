using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Linq;
using System.Net;
using WpfApp2.Models;

namespace WpfApp2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<NetworkInterfaceModel> Interfaces { get; set; }
        private NetworkInterfaceModel _selectedInterface;
        public NetworkInterfaceModel SelectedInterface
        {
            get => _selectedInterface;
            set
            {
                if (_selectedInterface != value)
                {
                    _selectedInterface = value;
                    OnPropertyChanged(nameof(SelectedInterface));
                    UpdateSelectedInterfaceInfo();
                }
            }
        }

        public string InterfaceDetails { get; set; }

        public MainViewModel()
        {
            Interfaces = new ObservableCollection<NetworkInterfaceModel>();
            GetNetworkInterfaces();
        }

        private void GetNetworkInterfaces()
        {
            foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                var ipProperties = adapter.GetIPProperties();
                var ipv4Address = ipProperties.UnicastAddresses
                    .FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.Address.ToString();
                var subnetMask = ipProperties.UnicastAddresses
                    .FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.IPv4Mask.ToString();

                Interfaces.Add(new NetworkInterfaceModel
                {
                    Name = adapter.Name,
                    IPAddress = ipv4Address ?? "N/A",
                    SubnetMask = subnetMask ?? "N/A",
                    MacAddress = adapter.GetPhysicalAddress()?.ToString() ?? "N/A",
                    Status = adapter.OperationalStatus.ToString(),
                    Speed = adapter.Speed.ToString(),
                    InterfaceType = adapter.NetworkInterfaceType.ToString(),
                });
            }
        }

        // Обновление информации о выбранном интерфейсе
        private void UpdateSelectedInterfaceInfo()
        {
            if (SelectedInterface != null)
            {
                InterfaceDetails = $"IP: {SelectedInterface.IPAddress}\n" +
                                   $"Subnet: {SelectedInterface.SubnetMask}\n" +
                                   $"MAC: {SelectedInterface.MacAddress}\n" +
                                   $"Status: {SelectedInterface.Status}\n" +
                                   $"Speed: {SelectedInterface.Speed}\n" +
                                   $"Type: {SelectedInterface.InterfaceType}";
            }
            else
            {
                InterfaceDetails = "No interface selected.";
            }
            OnPropertyChanged(nameof(InterfaceDetails));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
