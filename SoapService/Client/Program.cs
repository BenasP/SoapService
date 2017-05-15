using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClient = new ServiceClient();

            var result = myClient.GetData(1);
        }
    }
}
