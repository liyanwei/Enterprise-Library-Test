using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace DataAccess_wang.Common
{
    class ConfigInfo
    {
        //连接字符串的名字
        public string DbConfig { get; private set; }

        //类的实例
        public static ConfigInfo Instance = new ConfigInfo();

        //构造函数，读取配置文件中的信息，给属性赋值
        private  ConfigInfo()
        {
            //string s = ConfigurationManager.AppSettings["key1"];
            var config = (NameValueCollection)ConfigurationManager.GetSection("TestGroup/Monitor");
            string t = config["DBConfig"];
            DbConfig = t ?? "connectString";//: t;
        }


    }
}
