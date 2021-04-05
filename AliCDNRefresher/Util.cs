using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace AliCDNRefresher
{
    public static class Util
    {


        /// <summary>
        /// 初始化Client
        /// </summary>
        /// <param name="accessKeyId">Id</param>
        /// <param name="accessKeySecret">Secret</param>
        /// <returns></returns>
        private static AlibabaCloud.SDK.Cdn20180510.Client CreateClient(
            string accessKeyId,
            string accessKeySecret
        ) =>
            new(
                new AlibabaCloud.OpenApiClient.Models.Config
                {
                    // 您的AccessKey ID
                    AccessKeyId = accessKeyId,
                    // 您的AccessKey Secret
                    AccessKeySecret = accessKeySecret,
                    Endpoint = "cdn.aliyuncs.com",
                }
            );


        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <returns>包含有Key信息的对象</returns>
        public static SecretModel ReadConfig(string path = "appSettings.json") =>
            JsonSerializer.Deserialize<SecretModel>(
                File.ReadAllText(
                    Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "appSettings.json"
                    )
                )
            );

        /// <summary>
        /// 生成path
        /// </summary>
        /// <param name="paths">path集合</param>
        /// <returns></returns>
        private static string ObjectPathSerialize(IEnumerable<string> paths)
        {
            var result = string.Empty;

            foreach (var objectPath in paths)
            {
                var length = result.Length + objectPath.Length;

                var strBuilder = new StringBuilder(result, length);
                strBuilder.AppendLine(objectPath);
            }

            return result;
        }
    }
}
