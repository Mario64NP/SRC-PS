namespace Aplikacija.Server
{
    partial class frmMain
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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.lvConnectedClients = new System.Windows.Forms.ListView();
            this.columnIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(305, 112);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(100, 30);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Turn on";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(320, 45);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 47);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Off";
            // 
            // lvConnectedClients
            // 
            this.lvConnectedClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIP,
            this.columnState});
            this.lvConnectedClients.HideSelection = false;
            this.lvConnectedClients.Location = new System.Drawing.Point(12, 12);
            this.lvConnectedClients.Name = "lvConnectedClients";
            this.lvConnectedClients.Size = new System.Drawing.Size(260, 130);
            this.lvConnectedClients.TabIndex = 2;
            this.lvConnectedClients.UseCompatibleStateImageBehavior = false;
            this.lvConnectedClients.View = System.Windows.Forms.View.Details;
            // 
            // columnIP
            // 
            this.columnIP.Text = "IP";
            this.columnIP.Width = 130;
            // 
            // columnState
            // 
            this.columnState.Text = "State";
            this.columnState.Width = 120;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.lvConnectedClients);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnSwitch);
            this.Name = "frmMain";
            this.Text = "SRC DB Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ListView lvConnectedClients;
        private System.Windows.Forms.ColumnHeader columnIP;
        private System.Windows.Forms.ColumnHeader columnState;
    }
}

