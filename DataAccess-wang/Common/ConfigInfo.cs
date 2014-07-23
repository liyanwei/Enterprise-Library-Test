using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace DataAccess_wang.Common
{
    class ConfigInfo
    {
        //连接字符串
        public string ConnectionString { get; set; }

        //类的实例
        public static ConfigInfo Instance = new ConfigInfo();

        //构造函数，读取配置文件中的信息，给属性赋值
        public void ConfigInfo1()
        {
            string s = ConfigurationManager.AppSettings["key"];
            string ss = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("Monitor");
            //string con = ConfigurationManager.GetSection("connectionStrings").ToString();
            //ConnectionString = config["connectiongString"];
            //ConnectionString = con;
            string t = config["DBConfig"];
            ConnectionString = string.IsNullOrEmpty(t) ? "connectString" : t;
        }


    }
}
