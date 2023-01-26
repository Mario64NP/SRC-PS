using System;

namespace Aplikacija.Forme
{
    partial class frmRezultatDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezultatDetails));
            this.lblIgrac = new System.Windows.Forms.Label();
            this.lblVideoIgra = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIgrac = new System.Windows.Forms.ComboBox();
            this.cmbVideoIgra = new System.Windows.Forms.ComboBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.nudVreme = new System.Windows.Forms.NumericUpDown();
            this.chbVreme = new System.Windows.Forms.CheckBox();
            this.chbKategorija = new System.Windows.Forms.CheckBox();
            this.chbVideoIgra = new System.Windows.Forms.CheckBox();
            this.chbIgrac = new System.Windows.Forms.CheckBox();
            this.chbDatum = new System.Windows.Forms.CheckBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.Location = new System.Drawing.Point(40, 30);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(35, 13);
            this.lblIgrac.TabIndex = 12;
            this.lblIgrac.Text = "Igrač:";
            // 
            // lblVideoIgra
            // 
            this.lblVideoIgra.AutoSize = true;
            this.lblVideoIgra.Location = new System.Drawing.Point(40, 70);
            this.lblVideoIgra.Name = "lblVideoIgra";
            this.lblVideoIgra.Size = new System.Drawing.Size(63, 13);
            this.lblVideoIgra.TabIndex = 13;
            this.lblVideoIgra.Text = "Video igra:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(40, 110);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(59, 13);
            this.lblKategorija.TabIndex = 14;
            this.lblKategorija.Text = "Kategorija";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(40, 150);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(42, 13);
            this.lblVreme.TabIndex = 15;
            this.lblVreme.Text = "Vreme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Datum:";
            // 
            // cmbIgrac
            // 
            this.cmbIgrac.FormattingEnabled = true;
            this.cmbIgrac.Location = new System.Drawing.Point(120, 27);
            this.cmbIgrac.Name = "cmbIgrac";
            this.cmbIgrac.Size = new System.Drawing.Size(121, 21);
            this.cmbIgrac.TabIndex = 0;
            // 
            // cmbVideoIgra
            // 
            this.cmbVideoIgra.FormattingEnabled = true;
            this.cmbVideoIgra.Location = new System.Drawing.Point(120, 67);
            this.cmbVideoIgra.Name = "cmbVideoIgra";
            this.cmbVideoIgra.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoIgra.TabIndex = 1;
            this.cmbVideoIgra.SelectedIndexChanged += new System.EventHandler(this.cmbVideoIgra_SelectedIndexChanged);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(120, 107);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(43, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Potvrdi";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(166, 230);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 6;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // nudVreme
            // 
            this.nudVreme.Location = new System.Drawing.Point(120, 148);
            this.nudVreme.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudVreme.Name = "nudVreme";
            this.nudVreme.Size = new System.Drawing.Size(120, 22);
            this.nudVreme.TabIndex = 3;
            // 
            // chbVreme
            // 
            this.chbVreme.AutoSize = true;
            this.chbVreme.Checked = true;
            this.chbVreme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVreme.Location = new System.Drawing.Point(20, 150);
            this.chbVreme.Name = "chbVreme";
            this.chbVreme.Size = new System.Drawing.Size(15, 14);
            this.chbVreme.TabIndex = 10;
            this.chbVreme.UseVisualStyleBackColor = true;
            this.chbVreme.Visible = false;
            this.chbVreme.CheckedChanged += new System.EventHandler(this.chbVreme_CheckedChanged);
            // 
            // chbKategorija
            // 
            this.chbKategorija.AutoSize = true;
            this.chbKategorija.Checked = true;
            this.chbKategorija.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbKategorija.Location = new System.Drawing.Point(20, 110);
            this.chbKategorija.Name = "chbKategorija";
            this.chbKategorija.Size = new System.Drawing.Size(15, 14);
            this.chbKategorija.TabIndex = 9;
            this.chbKategorija.UseVisualStyleBackColor = true;
            this.chbKategorija.Visible = false;
            this.chbKategorija.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // chbVideoIgra
            // 
            this.chbVideoIgra.AutoSize = true;
            this.chbVideoIgra.Checked = true;
            this.chbVideoIgra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVideoIgra.Location = new System.Drawing.Point(20, 70);
            this.chbVideoIgra.Name = "chbVideoIgra";
            this.chbVideoIgra.Size = new System.Drawing.Size(15, 14);
            this.chbVideoIgra.TabIndex = 8;
            this.chbVideoIgra.UseVisualStyleBackColor = true;
            this.chbVideoIgra.Visible = false;
            this.chbVideoIgra.CheckedChanged += new System.EventHandler(this.chbVideoIgra_CheckedChanged);
            // 
            // chbIgrac
            // 
            this.chbIgrac.AutoSize = true;
            this.chbIgrac.Checked = true;
            this.chbIgrac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIgrac.Location = new System.Drawing.Point(20, 30);
            this.chbIgrac.Name = "chbIgrac";
            this.chbIgrac.Size = new System.Drawing.Size(15, 14);
            this.chbIgrac.TabIndex = 7;
            this.chbIgrac.UseVisualStyleBackColor = true;
            this.chbIgrac.Visible = false;
            this.chbIgrac.CheckedChanged += new System.EventHandler(this.chbIgrac_CheckedChanged);
            // 
            // chbDatum
            // 
            this.chbDatum.AutoSize = true;
            this.chbDatum.Checked = true;
            this.chbDatum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDatum.Location = new System.Drawing.Point(20, 190);
            this.chbDatum.Name = "chbDatum";
            this.chbDatum.Size = new System.Drawing.Size(15, 14);
            this.chbDatum.TabIndex = 11;
            this.chbDatum.UseVisualStyleBackColor = true;
            this.chbDatum.Visible = false;
            this.chbDatum.CheckedChanged += new System.EventHandler(this.chbDatum_CheckedChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(120, 186);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(121, 22);
            this.dtpDatum.TabIndex = 17;
            // 
            // frmRezultatDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(274, 281);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.chbDatum);
            this.Controls.Add(this.chbVreme);
            this.Controls.Add(this.chbKategorija);
            this.Controls.Add(this.chbVideoIgra);
            this.Controls.Add(this.chbIgrac);
            this.Controls.Add(this.nudVreme);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.cmbVideoIgra);
            this.Controls.Add(this.cmbIgrac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblVideoIgra);
            this.Controls.Add(this.lblIgrac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRezultatDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRezultatDetails";
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.Label lblVideoIgra;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIgrac;
        private System.Windows.Forms.ComboBox cmbVideoIgra;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.NumericUpDown nudVreme;
        private System.Windows.Forms.CheckBox chbVreme;
        private System.Windows.Forms.CheckBox chbKategorija;
        private System.Windows.Forms.CheckBox chbVideoIgra;
        private System.Windows.Forms.CheckBox chbIgrac;
        private System.Windows.Forms.CheckBox chbDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}