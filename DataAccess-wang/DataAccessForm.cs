using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess_wang.Common;
using DataAccess_wang.DataAccess;
using DataAccess_wang.DataSets;
using HEAO.WORK.Web.EntpriseLibrary.Data;

namespace DataAccess_wang
{
    public partial class DataAccessForm : Form
    {
        public DataAccessForm()
        {
            InitializeComponent();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            var college = new DataSet_College();
            BaseDB Db = BaseDbHelper.GetDefaultDb();

            Db.GetProcCommand("usp_College_LoadAll");
            Db.BaseFillData(college,college.College.TableName);

            dataGridView1.DataSource = college.College.DefaultView;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
