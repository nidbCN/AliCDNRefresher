// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AliCDNRefresher
{
    public class Util
    {

        /**
         * 使用AK&SK初始化账号Client
         * @param accessKeyId
         * @param accessKeySecret
         * @return Client
         * @throws Exception
         */
        public static AlibabaCloud.SDK.Cdn20180510.Client CreateClient(string accessKeyId, string accessKeySecret)
        {
            var config = new AlibabaCloud.OpenApiClient.Models.Config
            {
                // 您的AccessKey ID
                AccessKeyId = accessKeyId,
                // 您的AccessKey Secret
                AccessKeySecret = accessKeySecret,
                Endpoint = "cdn.aliyuncs.com",
            };

            // 访问的域名
            return new AlibabaCloud.SDK.Cdn20180510.Client(config);
        }

        public static void Add(string[] args)
        {
            var client = CreateClient("", "");
            var pushObjectCacheRequest = new AlibabaCloud.SDK.Cdn20180510.Models.PushObjectCacheRequest();

            // 复制代码运行请自行打印 API 的返回值
            client.PushObjectCache(pushObjectCacheRequest);
        }


    }
}
