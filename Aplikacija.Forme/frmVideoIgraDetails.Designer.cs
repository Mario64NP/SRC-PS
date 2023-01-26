namespace Aplikacija.Forme
{
    partial class frmVideoIgraDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideoIgraDetails));
            this.cmbPlatforma = new System.Windows.Forms.ComboBox();
            this.nudGodinaIzdanja = new System.Windows.Forms.NumericUpDown();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblPlatforma = new System.Windows.Forms.Label();
            this.lblGodinaIzdanja = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chbNaziv = new System.Windows.Forms.CheckBox();
            this.chbIzdavac = new System.Windows.Forms.CheckBox();
            this.chbGodinaIzdanja = new System.Windows.Forms.CheckBox();
            this.chbPlatforma = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(40, 30);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(40, 70);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(48, 13);
            this.lblIzdavac.TabIndex = 11;
            this.lblIzdavac.Text = "Izdavač:";
            // 
            // lblGodinaIzdanja
            // 
            this.lblGodinaIzdanja.AutoSize = true;
            this.lblGodinaIzdanja.Location = new System.Drawing.Point(40, 110);
            this.lblGodinaIzdanja.Name = "lblGodinaIzdanja";
            this.lblGodinaIzdanja.Size = new System.Drawing.Size(80, 13);
            this.lblGodinaIzdanja.TabIndex = 12;
            this.lblGodinaIzdanja.Text = "Godina izdanja:";
            // 
            // lblPlatforma
            // 
            this.lblPlatforma.AutoSize = true;
            this.lblPlatforma.Location = new System.Drawing.Point(40, 150);
            this.lblPlatforma.Name = "lblPlatforma";
            this.lblPlatforma.Size = new System.Drawing.Size(54, 13);
            this.lblPlatforma.TabIndex = 13;
            this.lblPlatforma.Text = "Platforma:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(150, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(150, 67);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(100, 20);
            this.txtIzdavac.TabIndex = 1;
            // 
            // nudGodinaIzdanja
            // 
            this.nudGodinaIzdanja.Location = new System.Drawing.Point(150, 108);
            this.nudGodinaIzdanja.Minimum = 1958;
            this.nudGodinaIzdanja.Maximum = 2022;
            this.nudGodinaIzdanja.Name = "nudGodinaIzdanja";
            this.nudGodinaIzdanja.Size = new System.Drawing.Size(100, 20);
            this.nudGodinaIzdanja.TabIndex = 2;
            this.nudGodinaIzdanja.Value = 2000;
            // 
            // cmbPlatforma
            // 
            this.cmbPlatforma.FormattingEnabled = true;
            this.cmbPlatforma.Location = new System.Drawing.Point(150, 147);
            this.cmbPlatforma.Name = "cmbPlatforma";
            this.cmbPlatforma.Size = new System.Drawing.Size(100, 21);
            this.cmbPlatforma.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(43, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Potvrdi";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(175, 185);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // chbNaziv
            // 
            this.chbNaziv.AutoSize = true;
            this.chbNaziv.Checked = true;
            this.chbNaziv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNaziv.Location = new System.Drawing.Point(20, 30);
            this.chbNaziv.Name = "chbNaziv";
            this.chbNaziv.Size = new System.Drawing.Size(15, 14);
            this.chbNaziv.TabIndex = 6;
            this.chbNaziv.UseVisualStyleBackColor = true;
            this.chbNaziv.Visible = false;
            this.chbNaziv.CheckedChanged += new System.EventHandler(this.chbNaziv_CheckedChanged);
            // 
            // chbIzdavac
            // 
            this.chbIzdavac.AutoSize = true;
            this.chbIzdavac.Checked = true;
            this.chbIzdavac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIzdavac.Location = new System.Drawing.Point(20, 70);
            this.chbIzdavac.Name = "chbIzdavac";
            this.chbIzdavac.Size = new System.Drawing.Size(15, 14);
            this.chbIzdavac.TabIndex = 7;
            this.chbIzdavac.UseVisualStyleBackColor = true;
            this.chbIzdavac.Visible = false;
            this.chbIzdavac.CheckedChanged += new System.EventHandler(this.chbIzdavac_CheckedChanged);
            // 
            // chbGodinaIzdanja
            // 
            this.chbGodinaIzdanja.AutoSize = true;
            this.chbGodinaIzdanja.Checked = true;
            this.chbGodinaIzdanja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGodinaIzdanja.Location = new System.Drawing.Point(20, 110);
            this.chbGodinaIzdanja.Name = "chbGodinaIzdanja";
            this.chbGodinaIzdanja.Size = new System.Drawing.Size(15, 14);
            this.chbGodinaIzdanja.TabIndex = 8;
            this.chbGodinaIzdanja.UseVisualStyleBackColor = true;
            this.chbGodinaIzdanja.Visible = false;
            this.chbGodinaIzdanja.CheckedChanged += new System.EventHandler(this.chbGodinaIzdanja_CheckedChanged);
            // 
            // chbPlatforma
            // 
            this.chbPlatforma.AutoSize = true;
            this.chbPlatforma.Checked = true;
            this.chbPlatforma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPlatforma.Location = new System.Drawing.Point(20, 150);
            this.chbPlatforma.Name = "chbPlatforma";
            this.chbPlatforma.Size = new System.Drawing.Size(15, 14);
            this.chbPlatforma.TabIndex = 9;
            this.chbPlatforma.UseVisualStyleBackColor = true;
            this.chbPlatforma.Visible = false;
            this.chbPlatforma.CheckedChanged += new System.EventHandler(this.chbPlatforma_CheckedChanged);
            // 
            // frmVideoIgraDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.chbPlatforma);
            this.Controls.Add(this.chbGodinaIzdanja);
            this.Controls.Add(this.chbIzdavac);
            this.Controls.Add(this.chbNaziv);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbPlatforma);
            this.Controls.Add(this.nudGodinaIzdanja);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblPlatforma);
            this.Controls.Add(this.lblGodinaIzdanja);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVideoIgraDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVideoIgraDetails";
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlatforma;
        private System.Windows.Forms.NumericUpDown nudGodinaIzdanja;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblPlatforma;
        private System.Windows.Forms.Label lblGodinaIzdanja;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chbNaziv;
        private System.Windows.Forms.CheckBox chbIzdavac;
        private System.Windows.Forms.CheckBox chbGodinaIzdanja;
        private System.Windows.Forms.CheckBox chbPlatforma;
    }
}