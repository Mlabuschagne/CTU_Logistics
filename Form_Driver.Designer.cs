
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.driverTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCtuLogisticsDataSet1 = new CTU_Logistics.DBCtuLogisticsDataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(63, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 113);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(590, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(590, 158);
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
            this.button4.Location = new System.Drawing.Point(590, 194);
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
            this.button5.Location = new System.Drawing.Point(482, 158);
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
            this.textBox2.Location = new System.Drawing.Point(183, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(129, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.button6.Location = new System.Drawing.Point(482, 194);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 161);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(92, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(116, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "BMI";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 220);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 61);
            this.textBox5.TabIndex = 24;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(482, 239);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "KG";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(528, 239);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pound";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(482, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 30);
            this.button7.TabIndex = 27;
            this.button7.Text = "BMI";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 38);
            this.label6.TabIndex = 28;
            this.label6.Text = "BMI Calculator";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(590, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Driver";
            this.Text = "BMI Calculator";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}