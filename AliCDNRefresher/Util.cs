// This file is auto-generated, don't edit it. Thanks.

using System.IO;
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
        private static SecretModel ReadConfig() =>
            JsonSerializer.Deserialize<SecretModel>(
                File.ReadAllText(
                    Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "appSettings.json"
                    )
                )
            );

        public static bool AddUrls(string[] urls)
        {
            var secretData = ReadConfig();

            var client = CreateClient(secretData.AccessKey, secretData.Secret);
            var pushObjectCacheRequest = new AlibabaCloud.SDK.Cdn20180510.Models.PushObjectCacheRequest();

            // 复制代码运行请自行打印 API 的返回值
            var result = client.PushObjectCache(pushObjectCacheRequest);

            return true;
        }
    }
}
