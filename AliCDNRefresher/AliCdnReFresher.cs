using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AliCDNRefresher;
using System.Text.Json;
using System.IO;
using AlibabaCloud.SDK.Cdn20180510.Models;

namespace AliCDNRefresher
{
    public class AliCdnReFresher
    {
        public SecretModel SecretModel { get; }

        public AliCdnReFresher(SecretModel secretModel)
        {
            SecretModel = secretModel ??
                          throw new ArgumentNullException(nameof(secretModel));
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="paths"></param>
        public void Refresh(IEnumerable<string> paths)
        {
            var objectPathInput = ObjectPathSerialize(paths);

            var client = CreateClient("boom", SecretModel.Secret);
            var pushObjectCacheRequest = new AlibabaCloud.SDK.Cdn20180510.Models.PushObjectCacheRequest()
            {
                ObjectPath = objectPathInput
            };

            client.PushObjectCache(pushObjectCacheRequest);
        }

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
    }
}
