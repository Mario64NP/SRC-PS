namespace Aplikacija.Forme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpIgraci = new System.Windows.Forms.TabPage();
            this.pnlButtonsPanelIgraci = new System.Windows.Forms.Panel();
            this.btnIgracIzmeni = new System.Windows.Forms.Button();
            this.btnIgracObrisi = new System.Windows.Forms.Button();
            this.btnIgracDodaj = new System.Windows.Forms.Button();
            this.btnIgracPretrazi = new System.Windows.Forms.Button();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.tpVideoIgre = new System.Windows.Forms.TabPage();
            this.pnlButtonsPanelVideoIgre = new System.Windows.Forms.Panel();
            this.btnVideoIgraIzmeni = new System.Windows.Forms.Button();
            this.btnVideoIgraObrisi = new System.Windows.Forms.Button();
            this.btnVideoIgraDodaj = new System.Windows.Forms.Button();
            this.btnVideoIgraPretrazi = new System.Windows.Forms.Button();
            this.dgvVideoIgre = new System.Windows.Forms.DataGridView();
            this.tpRezultati = new System.Windows.Forms.TabPage();
            this.pnlButtonsPanelRezultati = new System.Windows.Forms.Panel();
            this.btnRezultatIzmeni = new System.Windows.Forms.Button();
            this.btnRezultatObrisi = new System.Windows.Forms.Button();
            this.btnRezultatDodaj = new System.Windows.Forms.Button();
            this.btnRezultatPretrazi = new System.Windows.Forms.Button();
            this.dgvRezultati = new System.Windows.Forms.DataGridView();
            this.txtPlayersSearch = new System.Windows.Forms.TextBox();
            this.txtGamesSearch = new System.Windows.Forms.TextBox();
            this.txtResultsSearch = new System.Windows.Forms.TextBox();
            this.tcTabs.SuspendLayout();
            this.tpIgraci.SuspendLayout();
            this.pnlButtonsPanelIgraci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            this.tpVideoIgre.SuspendLayout();
            this.pnlButtonsPanelVideoIgre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoIgre)).BeginInit();
            this.tpRezultati.SuspendLayout();
            this.pnlButtonsPanelRezultati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpIgraci);
            this.tcTabs.Controls.Add(this.tpVideoIgre);
            this.tcTabs.Controls.Add(this.tpRezultati);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(584, 361);
            this.tcTabs.TabIndex = 0;
            // 
            // tpIgraci
            // 
            this.tpIgraci.Controls.Add(this.pnlButtonsPanelIgraci);
            this.tpIgraci.Controls.Add(this.dgvIgraci);
            this.tpIgraci.Location = new System.Drawing.Point(4, 25);
            this.tpIgraci.Name = "tpIgraci";
            this.tpIgraci.Padding = new System.Windows.Forms.Padding(3);
            this.tpIgraci.Size = new System.Drawing.Size(576, 332);
            this.tpIgraci.TabIndex = 0;
            this.tpIgraci.Text = "Igrači";
            this.tpIgraci.UseVisualStyleBackColor = true;
            // 
            // pnlButtonsPanelIgraci
            // 
            this.pnlButtonsPanelIgraci.Controls.Add(this.txtPlayersSearch);
            this.pnlButtonsPanelIgraci.Controls.Add(this.btnIgracIzmeni);
            this.pnlButtonsPanelIgraci.Controls.Add(this.btnIgracObrisi);
            this.pnlButtonsPanelIgraci.Controls.Add(this.btnIgracDodaj);
            this.pnlButtonsPanelIgraci.Controls.Add(this.btnIgracPretrazi);
            this.pnlButtonsPanelIgraci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsPanelIgraci.Location = new System.Drawing.Point(3, 294);
            this.pnlButtonsPanelIgraci.Name = "pnlButtonsPanelIgraci";
            this.pnlButtonsPanelIgraci.Size = new System.Drawing.Size(570, 35);
            this.pnlButtonsPanelIgraci.TabIndex = 3;
            // 
            // btnIgracIzmeni
            // 
            this.btnIgracIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgracIzmeni.Location = new System.Drawing.Point(360, 7);
            this.btnIgracIzmeni.Name = "btnIgracIzmeni";
            this.btnIgracIzmeni.Size = new System.Drawing.Size(100, 25);
            this.btnIgracIzmeni.TabIndex = 3;
            this.btnIgracIzmeni.Text = "Izmeni";
            this.btnIgracIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnIgracObrisi
            // 
            this.btnIgracObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgracObrisi.Location = new System.Drawing.Point(465, 7);
            this.btnIgracObrisi.Name = "btnIgracObrisi";
            this.btnIgracObrisi.Size = new System.Drawing.Size(100, 25);
            this.btnIgracObrisi.TabIndex = 4;
            this.btnIgracObrisi.Text = "Obriši";
            this.btnIgracObrisi.UseVisualStyleBackColor = true;
            // 
            // btnIgracDodaj
            // 
            this.btnIgracDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgracDodaj.Location = new System.Drawing.Point(255, 7);
            this.btnIgracDodaj.Name = "btnIgracDodaj";
            this.btnIgracDodaj.Size = new System.Drawing.Size(100, 25);
            this.btnIgracDodaj.TabIndex = 1;
            this.btnIgracDodaj.Text = "Dodaj";
            this.btnIgracDodaj.UseVisualStyleBackColor = true;
            // 
            // btnIgracPretrazi
            // 
            this.btnIgracPretrazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIgracPretrazi.Location = new System.Drawing.Point(111, 7);
            this.btnIgracPretrazi.Name = "btnIgracPretrazi";
            this.btnIgracPretrazi.Size = new System.Drawing.Size(100, 25);
            this.btnIgracPretrazi.TabIndex = 2;
            this.btnIgracPretrazi.Text = "Pretraži";
            this.btnIgracPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToAddRows = false;
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.AllowUserToOrderColumns = true;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgraci.Location = new System.Drawing.Point(3, 3);
            this.dgvIgraci.MultiSelect = false;
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIgraci.Size = new System.Drawing.Size(570, 326);
            this.dgvIgraci.TabIndex = 0;
            // 
            // tpVideoIgre
            // 
            this.tpVideoIgre.Controls.Add(this.pnlButtonsPanelVideoIgre);
            this.tpVideoIgre.Controls.Add(this.dgvVideoIgre);
            this.tpVideoIgre.Location = new System.Drawing.Point(4, 25);
            this.tpVideoIgre.Name = "tpVideoIgre";
            this.tpVideoIgre.Padding = new System.Windows.Forms.Padding(3);
            this.tpVideoIgre.Size = new System.Drawing.Size(576, 332);
            this.tpVideoIgre.TabIndex = 1;
            this.tpVideoIgre.Text = "Video Igre";
            this.tpVideoIgre.UseVisualStyleBackColor = true;
            // 
            // pnlButtonsPanelVideoIgre
            // 
            this.pnlButtonsPanelVideoIgre.Controls.Add(this.txtGamesSearch);
            this.pnlButtonsPanelVideoIgre.Controls.Add(this.btnVideoIgraIzmeni);
            this.pnlButtonsPanelVideoIgre.Controls.Add(this.btnVideoIgraObrisi);
            this.pnlButtonsPanelVideoIgre.Controls.Add(this.btnVideoIgraDodaj);
            this.pnlButtonsPanelVideoIgre.Controls.Add(this.btnVideoIgraPretrazi);
            this.pnlButtonsPanelVideoIgre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsPanelVideoIgre.Location = new System.Drawing.Point(3, 294);
            this.pnlButtonsPanelVideoIgre.Name = "pnlButtonsPanelVideoIgre";
            this.pnlButtonsPanelVideoIgre.Size = new System.Drawing.Size(570, 35);
            this.pnlButtonsPanelVideoIgre.TabIndex = 1;
            // 
            // btnVideoIgraIzmeni
            // 
            this.btnVideoIgraIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoIgraIzmeni.Location = new System.Drawing.Point(360, 7);
            this.btnVideoIgraIzmeni.Name = "btnVideoIgraIzmeni";
            this.btnVideoIgraIzmeni.Size = new System.Drawing.Size(100, 25);
            this.btnVideoIgraIzmeni.TabIndex = 7;
            this.btnVideoIgraIzmeni.Text = "Izmeni";
            this.btnVideoIgraIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnVideoIgraObrisi
            // 
            this.btnVideoIgraObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoIgraObrisi.Location = new System.Drawing.Point(465, 7);
            this.btnVideoIgraObrisi.Name = "btnVideoIgraObrisi";
            this.btnVideoIgraObrisi.Size = new System.Drawing.Size(100, 25);
            this.btnVideoIgraObrisi.TabIndex = 8;
            this.btnVideoIgraObrisi.Text = "Obriši";
            this.btnVideoIgraObrisi.UseVisualStyleBackColor = true;
            // 
            // btnVideoIgraDodaj
            // 
            this.btnVideoIgraDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoIgraDodaj.Location = new System.Drawing.Point(255, 7);
            this.btnVideoIgraDodaj.Name = "btnVideoIgraDodaj";
            this.btnVideoIgraDodaj.Size = new System.Drawing.Size(100, 25);
            this.btnVideoIgraDodaj.TabIndex = 5;
            this.btnVideoIgraDodaj.Text = "Dodaj";
            this.btnVideoIgraDodaj.UseVisualStyleBackColor = true;
            // 
            // btnVideoIgraPretrazi
            // 
            this.btnVideoIgraPretrazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVideoIgraPretrazi.Location = new System.Drawing.Point(111, 7);
            this.btnVideoIgraPretrazi.Name = "btnVideoIgraPretrazi";
            this.btnVideoIgraPretrazi.Size = new System.Drawing.Size(100, 25);
            this.btnVideoIgraPretrazi.TabIndex = 6;
            this.btnVideoIgraPretrazi.Text = "Pretraži";
            this.btnVideoIgraPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvVideoIgre
            // 
            this.dgvVideoIgre.AllowUserToAddRows = false;
            this.dgvVideoIgre.AllowUserToDeleteRows = false;
            this.dgvVideoIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideoIgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVideoIgre.Location = new System.Drawing.Point(3, 3);
            this.dgvVideoIgre.MultiSelect = false;
            this.dgvVideoIgre.Name = "dgvVideoIgre";
            this.dgvVideoIgre.ReadOnly = true;
            this.dgvVideoIgre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVideoIgre.Size = new System.Drawing.Size(570, 326);
            this.dgvVideoIgre.TabIndex = 0;
            // 
            // tpRezultati
            // 
            this.tpRezultati.Controls.Add(this.pnlButtonsPanelRezultati);
            this.tpRezultati.Controls.Add(this.dgvRezultati);
            this.tpRezultati.Location = new System.Drawing.Point(4, 25);
            this.tpRezultati.Name = "tpRezultati";
            this.tpRezultati.Padding = new System.Windows.Forms.Padding(3);
            this.tpRezultati.Size = new System.Drawing.Size(576, 332);
            this.tpRezultati.TabIndex = 2;
            this.tpRezultati.Text = "Rezultati";
            this.tpRezultati.UseVisualStyleBackColor = true;
            // 
            // pnlButtonsPanelRezultati
            // 
            this.pnlButtonsPanelRezultati.Controls.Add(this.txtResultsSearch);
            this.pnlButtonsPanelRezultati.Controls.Add(this.btnRezultatIzmeni);
            this.pnlButtonsPanelRezultati.Controls.Add(this.btnRezultatObrisi);
            this.pnlButtonsPanelRezultati.Controls.Add(this.btnRezultatDodaj);
            this.pnlButtonsPanelRezultati.Controls.Add(this.btnRezultatPretrazi);
            this.pnlButtonsPanelRezultati.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsPanelRezultati.Location = new System.Drawing.Point(3, 294);
            this.pnlButtonsPanelRezultati.Name = "pnlButtonsPanelRezultati";
            this.pnlButtonsPanelRezultati.Size = new System.Drawing.Size(570, 35);
            this.pnlButtonsPanelRezultati.TabIndex = 1;
            // 
            // btnRezultatIzmeni
            // 
            this.btnRezultatIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezultatIzmeni.Location = new System.Drawing.Point(360, 7);
            this.btnRezultatIzmeni.Name = "btnRezultatIzmeni";
            this.btnRezultatIzmeni.Size = new System.Drawing.Size(100, 25);
            this.btnRezultatIzmeni.TabIndex = 11;
            this.btnRezultatIzmeni.Text = "Izmeni";
            this.btnRezultatIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnRezultatObrisi
            // 
            this.btnRezultatObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezultatObrisi.Location = new System.Drawing.Point(465, 7);
            this.btnRezultatObrisi.Name = "btnRezultatObrisi";
            this.btnRezultatObrisi.Size = new System.Drawing.Size(100, 25);
            this.btnRezultatObrisi.TabIndex = 12;
            this.btnRezultatObrisi.Text = "Obriši";
            this.btnRezultatObrisi.UseVisualStyleBackColor = true;
            // 
            // btnRezultatDodaj
            // 
            this.btnRezultatDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezultatDodaj.Location = new System.Drawing.Point(255, 7);
            this.btnRezultatDodaj.Name = "btnRezultatDodaj";
            this.btnRezultatDodaj.Size = new System.Drawing.Size(100, 25);
            this.btnRezultatDodaj.TabIndex = 9;
            this.btnRezultatDodaj.Text = "Dodaj";
            this.btnRezultatDodaj.UseVisualStyleBackColor = true;
            // 
            // btnRezultatPretrazi
            // 
            this.btnRezultatPretrazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRezultatPretrazi.Location = new System.Drawing.Point(111, 7);
            this.btnRezultatPretrazi.Name = "btnRezultatPretrazi";
            this.btnRezultatPretrazi.Size = new System.Drawing.Size(100, 25);
            this.btnRezultatPretrazi.TabIndex = 10;
            this.btnRezultatPretrazi.Text = "Pretraži";
            this.btnRezultatPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvRezultati
            // 
            this.dgvRezultati.AllowUserToAddRows = false;
            this.dgvRezultati.AllowUserToDeleteRows = false;
            this.dgvRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezultati.Location = new System.Drawing.Point(3, 3);
            this.dgvRezultati.MultiSelect = false;
            this.dgvRezultati.Name = "dgvRezultati";
            this.dgvRezultati.ReadOnly = true;
            this.dgvRezultati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezultati.Size = new System.Drawing.Size(570, 326);
            this.dgvRezultati.TabIndex = 0;
            // 
            // txtPlayersSearch
            // 
            this.txtPlayersSearch.Location = new System.Drawing.Point(5, 8);
            this.txtPlayersSearch.Name = "txtPlayersSearch";
            this.txtPlayersSearch.Size = new System.Drawing.Size(100, 22);
            this.txtPlayersSearch.TabIndex = 5;
            // 
            // txtGamesSearch
            // 
            this.txtGamesSearch.Location = new System.Drawing.Point(5, 8);
            this.txtGamesSearch.Name = "txtGamesSearch";
            this.txtGamesSearch.Size = new System.Drawing.Size(100, 22);
            this.txtGamesSearch.TabIndex = 9;
            // 
            // txtResultsSearch
            // 
            this.txtResultsSearch.Location = new System.Drawing.Point(5, 8);
            this.txtResultsSearch.Name = "txtResultsSearch";
            this.txtResultsSearch.Size = new System.Drawing.Size(100, 22);
            this.txtResultsSearch.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tcTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speedrun Community";
            this.tcTabs.ResumeLayout(false);
            this.tpIgraci.ResumeLayout(false);
            this.pnlButtonsPanelIgraci.ResumeLayout(false);
            this.pnlButtonsPanelIgraci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            this.tpVideoIgre.ResumeLayout(false);
            this.pnlButtonsPanelVideoIgre.ResumeLayout(false);
            this.pnlButtonsPanelVideoIgre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoIgre)).EndInit();
            this.tpRezultati.ResumeLayout(false);
            this.pnlButtonsPanelRezultati.ResumeLayout(false);
            this.pnlButtonsPanelRezultati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpIgraci;
        private System.Windows.Forms.TabPage tpVideoIgre;
        private System.Windows.Forms.TabPage tpRezultati;
        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.Button btnIgracPretrazi;
        private System.Windows.Forms.Button btnIgracDodaj;
        private System.Windows.Forms.Panel pnlButtonsPanelIgraci;
        private System.Windows.Forms.Button btnIgracObrisi;
        private System.Windows.Forms.Button btnIgracIzmeni;
        private System.Windows.Forms.Panel pnlButtonsPanelVideoIgre;
        private System.Windows.Forms.Button btnVideoIgraIzmeni;
        private System.Windows.Forms.Button btnVideoIgraObrisi;
        private System.Windows.Forms.Button btnVideoIgraDodaj;
        private System.Windows.Forms.Button btnVideoIgraPretrazi;
        private System.Windows.Forms.DataGridView dgvVideoIgre;
        private System.Windows.Forms.Panel pnlButtonsPanelRezultati;
        private System.Windows.Forms.Button btnRezultatIzmeni;
        private System.Windows.Forms.Button btnRezultatObrisi;
        private System.Windows.Forms.Button btnRezultatDodaj;
        private System.Windows.Forms.Button btnRezultatPretrazi;
        private System.Windows.Forms.DataGridView dgvRezultati;
        private System.Windows.Forms.TextBox txtPlayersSearch;
        private System.Windows.Forms.TextBox txtGamesSearch;
        private System.Windows.Forms.TextBox txtResultsSearch;
    }
}