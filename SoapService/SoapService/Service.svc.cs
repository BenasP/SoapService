namespace SoapService
{
    public class Service : IService
    {
        private static int clicks = 0;
        public string GetData(int value)
        {
            return clicks.ToString();
        }

        public bool SendKeyPress()
        {
            clicks++;
            return true;
        }

    }
}
