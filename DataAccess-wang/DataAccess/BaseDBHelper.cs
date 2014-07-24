using System;
using HEAO.WORK.Web.EntpriseLibrary.Data;
using DataAccess_wang.Common;

namespace DataAccess_wang.DataAccess
{
    class BaseDbHelper
    {
        /// <summary>
        /// 返回enterpriseLibrary中的 Database，下面可以用BaseDb来fill数据集等
        /// </summary>
        /// <returns></returns>
        public static BaseDB GetDefaultDb()
        {
            return new BaseDB(ConfigInfo.Instance.DbConfig, null);
        }
    }
}
