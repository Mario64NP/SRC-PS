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
            this.lvGameCategories = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPlatforma
            // 
            this.cmbPlatforma.FormattingEnabled = true;
            this.cmbPlatforma.Location = new System.Drawing.Point(150, 147);
            this.cmbPlatforma.Name = "cmbPlatforma";
            this.cmbPlatforma.Size = new System.Drawing.Size(100, 21);
            this.cmbPlatforma.TabIndex = 3;
            // 
            // nudGodinaIzdanja
            // 
            this.nudGodinaIzdanja.Location = new System.Drawing.Point(150, 108);
            this.nudGodinaIzdanja.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudGodinaIzdanja.Minimum = new decimal(new int[] {
            1958,
            0,
            0,
            0});
            this.nudGodinaIzdanja.Name = "nudGodinaIzdanja";
            this.nudGodinaIzdanja.Size = new System.Drawing.Size(100, 22);
            this.nudGodinaIzdanja.TabIndex = 2;
            this.nudGodinaIzdanja.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(150, 67);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(100, 22);
            this.txtIzdavac.TabIndex = 1;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(150, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 22);
            this.txtNaziv.TabIndex = 0;
            // 
            // lblPlatforma
            // 
            this.lblPlatforma.AutoSize = true;
            this.lblPlatforma.Location = new System.Drawing.Point(30, 150);
            this.lblPlatforma.Name = "lblPlatforma";
            this.lblPlatforma.Size = new System.Drawing.Size(59, 13);
            this.lblPlatforma.TabIndex = 13;
            this.lblPlatforma.Text = "Platforma:";
            // 
            // lblGodinaIzdanja
            // 
            this.lblGodinaIzdanja.AutoSize = true;
            this.lblGodinaIzdanja.Location = new System.Drawing.Point(30, 110);
            this.lblGodinaIzdanja.Name = "lblGodinaIzdanja";
            this.lblGodinaIzdanja.Size = new System.Drawing.Size(88, 13);
            this.lblGodinaIzdanja.TabIndex = 12;
            this.lblGodinaIzdanja.Text = "Godina izdanja:";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(30, 70);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(47, 13);
            this.lblIzdavac.TabIndex = 11;
            this.lblIzdavac.Text = "Izdavač:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(30, 30);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(175, 355);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(33, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Potvrdi";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lvGameCategories
            // 
            this.lvGameCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvGameCategories.HideSelection = false;
            this.lvGameCategories.Location = new System.Drawing.Point(33, 230);
            this.lvGameCategories.Name = "lvGameCategories";
            this.lvGameCategories.Size = new System.Drawing.Size(217, 100);
            this.lvGameCategories.TabIndex = 14;
            this.lvGameCategories.UseCompatibleStateImageBehavior = false;
            this.lvGameCategories.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dozvoljene kategorije:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Opis";
            this.columnHeader2.Width = 153;
            // 
            // frmVideoIgraDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(284, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvGameCategories);
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
        private System.Windows.Forms.ListView lvGameCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}