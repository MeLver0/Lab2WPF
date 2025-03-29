using System.Net;

namespace WpfApp2.Helpers
{
    public static class AddressHelper
    {
        public static string GetAddressType(string address)
        {
            if (IPAddress.TryParse(address, out var ipAddress))
            {
                if (ipAddress.Equals(IPAddress.Loopback)) // Используем объект IPAddress.Loopback
                {
                    return "Loopback";
                }
                return "Public";
            }
            return "Invalid IP Address";
        }
    }
}