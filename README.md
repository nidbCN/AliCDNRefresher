# 阿里云CDN缓存刷新脚本

## 配置Token
1. 到[阿里云控制台](https://ram.console.aliyun.com/manage/ak) 创建AccessKey
2. 在克隆下来的目录中创建 `appSettings.json` 并且写入
   ```json
   {
       "AccessKey": "你的AccessKey",
       "Secret": "你的Secret"
   }
   ```

## 如何使用

1. 使用 `build.sh` 进行构建
2. 进入到 `Release` 目录，使用命令行启动 `AliCDNRefresher`
3. 在命令行后面跟上参数为要刷新的URL，比如：
   ```bash
   ./AliCDNRefresher https://img.cdn.gaein.cn/bing/20210321.jpg https://img.cdn.gaein.cn/bing/20210322.jpg
   ```
   如果没有任何输出说明它工作良好

## 开源协议

GPL v3
