using System;

namespace AliCDNRefresher
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Util.ReadConfig();
            var refresher = new AliCdnReFresher(config);

            refresher.Refresh(new[] { "https://img.cdn.gaein.cn/bing/20210325.jpg" });
        }
    }
}
