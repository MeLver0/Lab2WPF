namespace WpfApp2.Models;

public class NetworkInterfaceModel
{
    public string Name { get; set; }
    public string IPAddress { get; set; }
    public string SubnetMask { get; set; }
    public string MacAddress { get; set; }
    public string Status { get; set; }
    public string Speed { get; set; }
    public string InterfaceType { get; set; }
}