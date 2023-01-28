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
            ((System.ComponentModel.ISupportInitialize)(this.nudStarost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Location = new System.Drawing.Point(30, 30);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(55, 13);
            this.lblNadimak.TabIndex = 7;
            this.lblNadimak.Text = "Nadimak:";
            // 
            // lblStarost
            // 
            this.lblStarost.AutoSize = true;
            this.lblStarost.Location = new System.Drawing.Point(30, 70);
            this.lblStarost.Name = "lblStarost";
            this.lblStarost.Size = new System.Drawing.Size(46, 13);
            this.lblStarost.TabIndex = 8;
            this.lblStarost.Text = "Starost:";
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(140, 27);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(100, 22);
            this.txtNadimak.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(33, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Potvrdi";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            // nudStarost
            // 
            this.nudStarost.Location = new System.Drawing.Point(140, 68);
            this.nudStarost.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudStarost.Name = "nudStarost";
            this.nudStarost.Size = new System.Drawing.Size(100, 22);
            this.nudStarost.TabIndex = 2;
            this.nudStarost.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // frmIgracDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(274, 161);
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
    }
}