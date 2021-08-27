
namespace CTU_Logistics
{
    partial class Form1
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
            this.LinkToAddresses = new System.Windows.Forms.Button();
            this.LinkToDrivers = new System.Windows.Forms.Button();
            this.LinkToCustomers = new System.Windows.Forms.Button();
            this.LinkToStatus = new System.Windows.Forms.Button();
            this.LinkToFreight = new System.Windows.Forms.Button();
            this.AppExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkToAddresses
            // 
            this.LinkToAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkToAddresses.Location = new System.Drawing.Point(41, 49);
            this.LinkToAddresses.Name = "LinkToAddresses";
            this.LinkToAddresses.Size = new System.Drawing.Size(225, 95);
            this.LinkToAddresses.TabIndex = 0;
            this.LinkToAddresses.Text = "Manage Addresses";
            this.LinkToAddresses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToAddresses.UseVisualStyleBackColor = true;
            this.LinkToAddresses.Click += new System.EventHandler(this.LinkToAddresses_Click);
            // 
            // LinkToDrivers
            // 
            this.LinkToDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LinkToDrivers.Location = new System.Drawing.Point(41, 263);
            this.LinkToDrivers.Name = "LinkToDrivers";
            this.LinkToDrivers.Size = new System.Drawing.Size(225, 100);
            this.LinkToDrivers.TabIndex = 1;
            this.LinkToDrivers.Text = "Manage Drivers";
            this.LinkToDrivers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToDrivers.UseVisualStyleBackColor = true;
            this.LinkToDrivers.Click += new System.EventHandler(this.LinkToDrivers_Click);
            // 
            // LinkToCustomers
            // 
            this.LinkToCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LinkToCustomers.Location = new System.Drawing.Point(327, 49);
            this.LinkToCustomers.Name = "LinkToCustomers";
            this.LinkToCustomers.Size = new System.Drawing.Size(221, 95);
            this.LinkToCustomers.TabIndex = 3;
            this.LinkToCustomers.Text = "Manage Customers";
            this.LinkToCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToCustomers.UseVisualStyleBackColor = true;
            this.LinkToCustomers.Click += new System.EventHandler(this.LinkToCustomers_Click);
            // 
            // LinkToStatus
            // 
            this.LinkToStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LinkToStatus.Location = new System.Drawing.Point(327, 263);
            this.LinkToStatus.Name = "LinkToStatus";
            this.LinkToStatus.Size = new System.Drawing.Size(221, 100);
            this.LinkToStatus.TabIndex = 4;
            this.LinkToStatus.Text = "Manage Statusus";
            this.LinkToStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToStatus.UseVisualStyleBackColor = true;
            this.LinkToStatus.Click += new System.EventHandler(this.LinkToStatus_Click);
            // 
            // LinkToFreight
            // 
            this.LinkToFreight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LinkToFreight.Location = new System.Drawing.Point(609, 49);
            this.LinkToFreight.Name = "LinkToFreight";
            this.LinkToFreight.Size = new System.Drawing.Size(223, 95);
            this.LinkToFreight.TabIndex = 6;
            this.LinkToFreight.Text = "Manage Freight";
            this.LinkToFreight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToFreight.UseVisualStyleBackColor = true;
            this.LinkToFreight.Click += new System.EventHandler(this.LinkToFreight_Click);
            // 
            // AppExit
            // 
            this.AppExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AppExit.Location = new System.Drawing.Point(609, 263);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(223, 100);
            this.AppExit.TabIndex = 7;
            this.AppExit.Text = "Exit";
            this.AppExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AppExit.UseVisualStyleBackColor = true;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 441);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.LinkToFreight);
            this.Controls.Add(this.LinkToStatus);
            this.Controls.Add(this.LinkToCustomers);
            this.Controls.Add(this.LinkToDrivers);
            this.Controls.Add(this.LinkToAddresses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LinkToAddresses;
        private System.Windows.Forms.Button LinkToDrivers;
        private System.Windows.Forms.Button LinkToCustomers;
        private System.Windows.Forms.Button LinkToStatus;
        private System.Windows.Forms.Button LinkToFreight;
        private System.Windows.Forms.Button AppExit;
    }
}

