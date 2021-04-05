using System.IO;
using System.Text.Json;

namespace AliCDNRefresher
{
    public static class Util
    {
        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <returns>包含有Key信息的对象</returns>
        public static SecretModel ReadConfig(string path = "appSettings.json") =>
            JsonSerializer.Deserialize<SecretModel>(
                File.ReadAllText(
                    Path.Combine(
                        Directory.GetCurrentDirectory(),
                        path
                    )
                )
            );
    }
}
