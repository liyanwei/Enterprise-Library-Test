namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExecuteScalar = new System.Windows.Forms.Button();
            this.StoredProcCommand = new System.Windows.Forms.Button();
            this.Transaction = new System.Windows.Forms.Button();
            this.DataSetUpdate = new System.Windows.Forms.Button();
            this.ReturnXML = new System.Windows.Forms.Button();
            this.DataAsObject = new System.Windows.Forms.Button();
            this.Async = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(356, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ExecuteNonQuery";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExecuteNonQuery_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ExecuteDataSet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExecuteDataSet_Click);
            // 
            // ExecuteScalar
            // 
            this.ExecuteScalar.Location = new System.Drawing.Point(254, 220);
            this.ExecuteScalar.Name = "ExecuteScalar";
            this.ExecuteScalar.Size = new System.Drawing.Size(114, 23);
            this.ExecuteScalar.TabIndex = 3;
            this.ExecuteScalar.Text = "ExecuteScalar";
            this.ExecuteScalar.UseVisualStyleBackColor = true;
            this.ExecuteScalar.Click += new System.EventHandler(this.ExecuteScalar_Click);
            // 
            // StoredProcCommand
            // 
            this.StoredProcCommand.Location = new System.Drawing.Point(13, 250);
            this.StoredProcCommand.Name = "StoredProcCommand";
            this.StoredProcCommand.Size = new System.Drawing.Size(114, 23);
            this.StoredProcCommand.TabIndex = 4;
            this.StoredProcCommand.Text = "StoredProcCommand";
            this.StoredProcCommand.UseVisualStyleBackColor = true;
            this.StoredProcCommand.Click += new System.EventHandler(this.StoredProcCommand_Click);
            // 
            // Transaction
            // 
            this.Transaction.Location = new System.Drawing.Point(134, 250);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(113, 23);
            this.Transaction.TabIndex = 5;
            this.Transaction.Text = "Transaction";
            this.Transaction.UseVisualStyleBackColor = true;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // DataSetUpdate
            // 
            this.DataSetUpdate.Location = new System.Drawing.Point(254, 250);
            this.DataSetUpdate.Name = "DataSetUpdate";
            this.DataSetUpdate.Size = new System.Drawing.Size(114, 23);
            this.DataSetUpdate.TabIndex = 6;
            this.DataSetUpdate.Text = "DataSetUpdate";
            this.DataSetUpdate.UseVisualStyleBackColor = true;
            this.DataSetUpdate.Click += new System.EventHandler(this.DataSetUpdate_Click);
            // 
            // ReturnXML
            // 
            this.ReturnXML.Location = new System.Drawing.Point(12, 280);
            this.ReturnXML.Name = "ReturnXML";
            this.ReturnXML.Size = new System.Drawing.Size(115, 23);
            this.ReturnXML.TabIndex = 7;
            this.ReturnXML.Text = "ReturnXML";
            this.ReturnXML.UseVisualStyleBackColor = true;
            this.ReturnXML.Click += new System.EventHandler(this.ReturnXML_Click);
            // 
            // DataAsObject
            // 
            this.DataAsObject.Location = new System.Drawing.Point(134, 279);
            this.DataAsObject.Name = "DataAsObject";
            this.DataAsObject.Size = new System.Drawing.Size(113, 23);
            this.DataAsObject.TabIndex = 8;
            this.DataAsObject.Text = "DataAsObject";
            this.DataAsObject.UseVisualStyleBackColor = true;
            this.DataAsObject.Click += new System.EventHandler(this.DataAsObject_Click);
            // 
            // Async
            // 
            this.Async.Location = new System.Drawing.Point(254, 279);
            this.Async.Name = "Async";
            this.Async.Size = new System.Drawing.Size(114, 23);
            this.Async.TabIndex = 9;
            this.Async.Text = "Async";
            this.Async.UseVisualStyleBackColor = true;
            this.Async.Click += new System.EventHandler(this.Async_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 392);
            this.Controls.Add(this.Async);
            this.Controls.Add(this.DataAsObject);
            this.Controls.Add(this.ReturnXML);
            this.Controls.Add(this.DataSetUpdate);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.StoredProcCommand);
            this.Controls.Add(this.ExecuteScalar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExecuteScalar;
        private System.Windows.Forms.Button StoredProcCommand;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Button DataSetUpdate;
        private System.Windows.Forms.Button ReturnXML;
        private System.Windows.Forms.Button DataAsObject;
        private System.Windows.Forms.Button Async;
    }
}

