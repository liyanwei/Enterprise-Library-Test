using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Xml.Linq;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Database db = DatabaseFactory.CreateDatabase("ConnectionString");

        /// <summary>
        /// 执行ExecuteNonQuery
        /// </summary>
        private void ExecuteNonQuery_Click(object sender, EventArgs e)
        {
            db.ExecuteNonQuery(CommandType.Text, "INSERT INTO [College] ([CollegeID],[Name]) values (6,'体育学院')");
        }

        /// <summary>
        /// 执行ExecuteDataSet，返回College列表
        /// </summary>
        /// <returns></returns>
        private void ExecuteDataSet_Click(object sender, EventArgs e)
        {
            string sql = "select * from College";
            DbCommand dw = db.GetSqlStringCommand(sql);

            dataGridView1.DataSource = db.ExecuteDataSet(dw).Tables[0];
        }

        /// <summary>
        /// 执行ExecuteScalar,返回单一的值
        /// </summary>
        /// <returns></returns>
        private void ExecuteScalar_Click(object sender, EventArgs e)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");

            string sql = "select count(*) from College";
            DbCommand dc = db.GetSqlStringCommand(sql);

            string str = "影响的行数:" + (int)db.ExecuteScalar(dc);

            MessageBox.Show(str);
        }
        
        /// <summary>
        /// 执行存储过程
        /// </summary>
        private void StoredProcCommand_Click(object sender, EventArgs e)
        {
            DbCommand dc = db.GetStoredProcCommand("usp_College_LoadByID");

            db.AddInParameter(dc, "@CollegeID", System.Data.DbType.Int32, 5);

            dataGridView1.DataSource = db.ExecuteDataSet(dc).Tables[0];
        }

        /// <summary>
        /// 事务
        /// </summary>
        private void Transaction_Click(object sender, EventArgs e)
        {
            DbCommand dc1 = db.GetStoredProcCommand("usp_College_Insert");

            db.AddInParameter(dc1, "@CollegeID", DbType.Int32, 7);
            db.AddInParameter(dc1, "@Name", DbType.String, "文旅学院");

            DbCommand dc2 = db.GetStoredProcCommand("usp_College_Insert");

            db.AddInParameter(dc2, "@CollegeID", DbType.Int32, 7);
            db.AddInParameter(dc2, "@Name", DbType.String, "化工学院");

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction trans = conn.BeginTransaction();

                try
                {
                    //添加一个ID为7的学院
                    db.ExecuteNonQuery(dc1, trans);

                    //添加一个ID为7的学院,主键重复,事务将回滚
                    db.ExecuteNonQuery(dc2, trans);

                    //提交事务.
                    trans.Commit();
                }
                catch
                {
                    //回滚
                    trans.Rollback();
                }
                conn.Close();
            }

            //查看数据库,数据未被添加,说明事务已回滚
            ExecuteDataSet_Click(null, null);
        }

        /// <summary>
        /// 通过DataSet更新数据库
        /// </summary>
        private void DataSetUpdate_Click(object sender, EventArgs e)
        {
            DataSet productsDataSet = new DataSet();

            string sql = "Select * From College";
            DbCommand cmd = db.GetSqlStringCommand(sql);

            string CollegeTableName = "College";

            //恢复原始数据
            db.LoadDataSet(cmd, productsDataSet, CollegeTableName);

            //获取数据表格
            DataTable dTable = productsDataSet.Tables[CollegeTableName];

            //添加一个新信息入DataSet中
            DataRow addedRow = dTable.Rows.Add(new object[] { 8, "外国语学院" });

            //修改一个原有数据
            dTable.Rows[0]["Name"] = "国教院";

            //提供插入,更新,删除存储过程
            DbCommand insertCommand = db.GetStoredProcCommand("usp_College_Insert");
            db.AddInParameter(insertCommand, "@CollegeID", DbType.Int32, "CollegeID", DataRowVersion.Current);
            db.AddInParameter(insertCommand, "@Name", DbType.String, "Name", DataRowVersion.Current);

            DbCommand deleteCommand = db.GetStoredProcCommand("usp_College_Delete");
            db.AddInParameter(deleteCommand, "@CollegeID", DbType.Int32, "CollegeID", DataRowVersion.Current);

            DbCommand updateCommand = db.GetStoredProcCommand("usp_College_Update");
            db.AddInParameter(updateCommand, "@CollegeID", DbType.Int32, "CollegeID", DataRowVersion.Current);
            db.AddInParameter(updateCommand, "@Name", DbType.String, "Name", DataRowVersion.Current);

            //通过DataSet更新数据库
            int rowsAffected = db.UpdateDataSet(productsDataSet, CollegeTableName, insertCommand, updateCommand, deleteCommand,
                                Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);

            MessageBox.Show("影响的行数:" + rowsAffected);
        }

        /// <summary>
        /// 返回值XML化
        /// </summary>
        private void ReturnXML_Click(object sender, EventArgs e)
        {
            //使用"FOR XML AUTO"参数使得SQL返回XML格式的信息
            SqlDatabase sqldb = (SqlDatabase)DatabaseFactory.CreateDatabase("ConnectionString");

            DbCommand cmd = sqldb.GetSqlStringCommand("SELECT * FROM College FOR XML AUTO");
            IEnumerable<string> productList;

            using (var reader = sqldb.ExecuteXmlReader(cmd))
            {
                if (reader.IsStartElement())
                {
                    var root = (XElement)XNode.ReadFrom(reader);
                    productList = root.Elements("CollegeID")
                                      .Attributes("Name")
                                      .Select(a => a.Value).ToArray();

                    MessageBox.Show(((XElement)root).ToString());
                }
            }

        }

        /// <summary>
        /// DataAsObject
        /// </summary>
        private void DataAsObject_Click(object sender, EventArgs e)
        {
            //将返回的数据对象化
            var results = db.ExecuteSprocAccessor<College>("usp_College_LoadAll");

            MessageBox.Show(results.ElementAt(0).ToString());
        }


        /// <summary>
        /// 异步访问数据库
        /// </summary>
        private void Async_Click(object sender, EventArgs e)
        {
            //创建新的数据库连接,属性必须添加:Asynchronous Processing=true
            String connectionString = @"server=(local); database=TestDB; Integrated Security=true; Asynchronous Processing=true";
            Database Sqldb = new SqlDatabase(connectionString);
            DbCommand cmd = Sqldb.GetStoredProcCommand("usp_College_LoadbyID");
            Sqldb.AddInParameter(cmd, "@CollegeID", DbType.Int32, 1);

            try
            {
                IAsyncResult result = Sqldb.BeginExecuteReader(cmd, MyEndExecuteCallback, Sqldb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //当获取完毕执行该函数
        private void MyEndExecuteCallback(IAsyncResult result)
        {
            try
            {
                Database Sqldb = (Database)result.AsyncState;
                IDataReader reader = db.EndExecuteReader(result);


                College c = new College((int)reader[0], (string)reader[1]);

                MessageBox.Show(c.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
