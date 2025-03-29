using System.Net;
using System.Linq;

namespace WpfApp2.Helpers
{
    public static class DnsHelper
    {
        public static string GetDnsInfo(string host)
        {
            try
            {
                var entry = Dns.GetHostEntry(host);
                // Логирование DNS-запроса
                Console.WriteLine($"DNS lookup successful for {host}: {string.Join(", ", entry.AddressList.Select(x => x.ToString()))}");
                return string.Join(", ", entry.AddressList.Select(x => x.ToString()));
            }
            catch (Exception ex)
            {
                // Логируем ошибку
                Console.WriteLine($"DNS lookup failed for {host}: {ex.Message}");
                return "Dns lookup failed";
            }
        }
    }
}