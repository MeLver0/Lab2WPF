using System.Net.NetworkInformation;

namespace WpfApp2.Helpers
{
    public static class PingHelper
    {
        public static bool PingHost(string host)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(host);
                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        // Логирование ошибок пинга
                        Console.WriteLine($"Ping failed: {reply.Status}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Логируем исключение
                    Console.WriteLine($"Ping error: {ex.Message}");
                    return false;
                }
            }
        }
    }
}