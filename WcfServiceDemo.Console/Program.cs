using WcfServiceDemo.Console.ServiceReference;

namespace WcfServiceDemo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IpAddressServiceClient client = new IpAddressServiceClient();
            var ipAddress = client.GetIpAddress();
            System.Console.WriteLine(ipAddress.IpAddress);
            System.Console.ReadLine();
        }
    }
}
