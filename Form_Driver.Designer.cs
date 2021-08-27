
namespace CTU_Logistics
{
    partial class Form_Driver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.driverTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCtuLogisticsDataSet1 = new CTU_Logistics.DBCtuLogisticsDataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dBCtuLogisticsDataSet = new CTU_Logistics.DBCtuLogisticsDataSet();
            this.dBCtuLogisticsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driver_TableTableAdapter = new CTU_Logistics.DBCtuLogisticsDataSetTableAdapters.Driver_TableTableAdapter();
            this.driver_TableTableAdapter1 = new CTU_Logistics.DBCtuLogisticsDataSet1TableAdapters.Driver_TableTableAdapter();
            this.driverTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCtuLogisticsDataSet2 = new CTU_Logistics.DBCtuLogisticsDataSet2();
            this.driver_TableTableAdapter2 = new CTU_Logistics.DBCtuLogisticsDataSet2TableAdapters.Driver_TableTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.driverTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(94, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(198, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Yes";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(306, 156);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 24);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(64, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(306, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(430, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(558, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(183, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Read";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // driverTableBindingSource1
            // 
            this.driverTableBindingSource1.DataMember = "Driver_Table";
            this.driverTableBindingSource1.DataSource = this.dBCtuLogisticsDataSet1;
            // 
            // dBCtuLogisticsDataSet1
            // 
            this.dBCtuLogisticsDataSet1.DataSetName = "DBCtuLogisticsDataSet1";
            this.dBCtuLogisticsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(113, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 15;
            // 
            // dBCtuLogisticsDataSet
            // 
            this.dBCtuLogisticsDataSet.DataSetName = "DBCtuLogisticsDataSet";
            this.dBCtuLogisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCtuLogisticsDataSetBindingSource
            // 
            this.dBCtuLogisticsDataSetBindingSource.DataSource = this.dBCtuLogisticsDataSet;
            this.dBCtuLogisticsDataSetBindingSource.Position = 0;
            // 
            // driverTableBindingSource
            // 
            this.driverTableBindingSource.DataMember = "Driver_Table";
            this.driverTableBindingSource.DataSource = this.dBCtuLogisticsDataSetBindingSource;
            // 
            // driver_TableTableAdapter
            // 
            this.driver_TableTableAdapter.ClearBeforeFill = true;
            // 
            // driver_TableTableAdapter1
            // 
            this.driver_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // driverTableBindingSource2
            // 
            this.driverTableBindingSource2.DataMember = "Driver_Table";
            this.driverTableBindingSource2.DataSource = this.dBCtuLogisticsDataSet2;
            // 
            // dBCtuLogisticsDataSet2
            // 
            this.dBCtuLogisticsDataSet2.DataSetName = "DBCtuLogisticsDataSet2";
            this.dBCtuLogisticsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driver_TableTableAdapter2
            // 
            this.driver_TableTableAdapter2.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(558, 179);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 181);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Driver";
            this.Text = "Form_Driver";
            this.Load += new System.EventHandler(this.Form_Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCtuLogisticsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource dBCtuLogisticsDataSetBindingSource;
        private DBCtuLogisticsDataSet dBCtuLogisticsDataSet;
        private System.Windows.Forms.BindingSource driverTableBindingSource;
        private DBCtuLogisticsDataSetTableAdapters.Driver_TableTableAdapter driver_TableTableAdapter;
        private DBCtuLogisticsDataSet1 dBCtuLogisticsDataSet1;
        private System.Windows.Forms.BindingSource driverTableBindingSource1;
        private DBCtuLogisticsDataSet1TableAdapters.Driver_TableTableAdapter driver_TableTableAdapter1;
        private DBCtuLogisticsDataSet2 dBCtuLogisticsDataSet2;
        private System.Windows.Forms.BindingSource driverTableBindingSource2;
        private DBCtuLogisticsDataSet2TableAdapters.Driver_TableTableAdapter driver_TableTableAdapter2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}