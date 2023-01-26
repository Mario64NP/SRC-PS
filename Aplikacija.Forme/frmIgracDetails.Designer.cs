namespace Aplikacija.Forme
{
    partial class frmIgracDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIgracDetails));
            this.lblNadimak = new System.Windows.Forms.Label();
            this.lblStarost = new System.Windows.Forms.Label();
            this.txtNadimak = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.nudStarost = new System.Windows.Forms.NumericUpDown();
            this.chbNadimak = new System.Windows.Forms.CheckBox();
            this.chbStarost = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Location = new System.Drawing.Point(40, 30);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(52, 13);
            this.lblNadimak.TabIndex = 7;
            this.lblNadimak.Text = "Nadimak:";
            // 
            // lblStarost
            // 
            this.lblStarost.AutoSize = true;
            this.lblStarost.Location = new System.Drawing.Point(40, 70);
            this.lblStarost.Name = "lblStarost";
            this.lblStarost.Size = new System.Drawing.Size(43, 13);
            this.lblStarost.TabIndex = 8;
            this.lblStarost.Text = "Starost:";
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(140, 27);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(100, 20);
            this.txtNadimak.TabIndex = 1;
            // 
            // nudStarost
            // 
            this.nudStarost.Location = new System.Drawing.Point(140, 68);
            this.nudStarost.Minimum = 13;
            this.nudStarost.Name = "nudStarost";
            this.nudStarost.Size = new System.Drawing.Size(100, 20);
            this.nudStarost.TabIndex = 2;
            this.nudStarost.Value = 13;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(43, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Potvrdi";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(165, 115);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // chbNadimak
            // 
            this.chbNadimak.AutoSize = true;
            this.chbNadimak.Checked = true;
            this.chbNadimak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNadimak.Location = new System.Drawing.Point(20, 30);
            this.chbNadimak.Name = "chbNadimak";
            this.chbNadimak.Size = new System.Drawing.Size(15, 14);
            this.chbNadimak.TabIndex = 5;
            this.chbNadimak.UseVisualStyleBackColor = true;
            this.chbNadimak.Visible = false;
            this.chbNadimak.CheckedChanged += new System.EventHandler(this.chbNadimak_CheckedChanged);
            // 
            // chbStarost
            // 
            this.chbStarost.AutoSize = true;
            this.chbStarost.Checked = true;
            this.chbStarost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStarost.Location = new System.Drawing.Point(20, 70);
            this.chbStarost.Name = "chbStarost";
            this.chbStarost.Size = new System.Drawing.Size(15, 14);
            this.chbStarost.TabIndex = 6;
            this.chbStarost.UseVisualStyleBackColor = true;
            this.chbStarost.Visible = false;
            this.chbStarost.CheckedChanged += new System.EventHandler(this.chbStarost_CheckedChanged);
            // 
            // frmIgracDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.chbStarost);
            this.Controls.Add(this.chbNadimak);
            this.Controls.Add(this.nudStarost);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNadimak);
            this.Controls.Add(this.lblStarost);
            this.Controls.Add(this.lblNadimak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIgracDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Igrača";
            ((System.ComponentModel.ISupportInitialize)(this.nudStarost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNadimak;
        private System.Windows.Forms.Label lblStarost;
        private System.Windows.Forms.TextBox txtNadimak;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.NumericUpDown nudStarost;
        private System.Windows.Forms.CheckBox chbNadimak;
        private System.Windows.Forms.CheckBox chbStarost;
    }
}