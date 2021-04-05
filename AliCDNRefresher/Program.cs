namespace AliCDNRefresher
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var config = Util.ReadConfig();
            var refresher = new AliCdnReFresher(config);

            refresher.Refresh(args);
        }
    }
}
