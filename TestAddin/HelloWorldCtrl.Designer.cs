﻿using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestAddin
{
    partial class HelloWorldCtrl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(287, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // HelloWorldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "HelloWorldCtrl";
            this.Size = new System.Drawing.Size(366, 329);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            ////Подключение к Sql
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = (local)\\SQLEXPRESS; database = Database1; integrated security = SSPI";

            //SqlCommand cmd = new SqlCommand("select * from Table", con);
            //con.Open();
            //SqlDataReader DR = cmd.ExecuteReader();

            //BindingSource source = new BindingSource();
            //source.DataSource = DR;

            //dataGridView1.DataSource = source;
            //con.Close();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
