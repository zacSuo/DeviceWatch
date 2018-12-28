using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using ServiceStack.Redis;

namespace WebApplication1
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private IRedisClient GetClient
        {
            get
            {
                string strIPPort = string.Format("{0}:{1}", "127.0.0.1", 6379);
                PooledRedisClientManager prcm = new PooledRedisClientManager(new string[] { strIPPort }, new string[] { strIPPort }, new RedisClientManagerConfig
                            {
                                MaxWritePoolSize = 200, // “写”链接池链接数 
                                MaxReadPoolSize = 200, // “读”链接池链接数 
                                AutoStart = true,
                            });
                return prcm.GetClient();
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession=true)]
        public string ReportStatus(int idx)
        {

            IRedisClient client = this.GetClient;
            string str = client.Get<string>("Number");
            str += (idx + ",");
            client.Set<string>("Number", str);
            return "我是服务器，收到异常";
        }

        [WebMethod(EnableSession = true)]
        public string RepairStatus(int idx)
        {
            IRedisClient client = this.GetClient;
            string str = client.Get<string>("Number");
            str = str.Replace(idx + ",", "");
            client.Set<string>("Number", str);
            return "我是服务器，收到修复";
        }

        [WebMethod(EnableSession = true)]
        public string GetStatus()
        {
            IRedisClient client = this.GetClient;
            string strResult = client.Get<string>("Number");

            return strResult;
        }
    }
}
