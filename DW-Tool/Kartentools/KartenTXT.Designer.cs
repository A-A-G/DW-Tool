namespace DW.Kartentools
{
    partial class KartenTXT
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKartentools = new System.Windows.Forms.Label();
            this.backgroundWorkerKartenTXTParser = new System.ComponentModel.BackgroundWorker();
            this.tabPageClans = new System.Windows.Forms.TabPage();
            this.tabPageCommandersuche = new System.Windows.Forms.TabPage();
            this.textBoxRang = new System.Windows.Forms.TextBox();
            this.labelRang = new System.Windows.Forms.Label();
            this.textBoxKoord = new System.Windows.Forms.TextBox();
            this.labelKoord = new System.Windows.Forms.Label();
            this.dataGridViewCommanders = new System.Windows.Forms.DataGridView();
            this.textBoxClan = new System.Windows.Forms.TextBox();
            this.textBoxCommander = new System.Windows.Forms.TextBox();
            this.labelClan = new System.Windows.Forms.Label();
            this.labelCommander = new System.Windows.Forms.Label();
            this.tabControlKartentools = new System.Windows.Forms.TabControl();
            this.Quad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commandername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCommandersuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommanders)).BeginInit();
            this.tabControlKartentools.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKartentools
            // 
            this.labelKartentools.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKartentools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKartentools.Location = new System.Drawing.Point(0, 0);
            this.labelKartentools.Name = "labelKartentools";
            this.labelKartentools.Size = new System.Drawing.Size(750, 25);
            this.labelKartentools.TabIndex = 0;
            this.labelKartentools.Text = "Kartentools";
            this.labelKartentools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // backgroundWorkerKartenTXTParser
            // 
            this.backgroundWorkerKartenTXTParser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerKartenTXTParser_DoWork);
            this.backgroundWorkerKartenTXTParser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerKartenTXTParser_RunWorkerCompleted);
            // 
            // tabPageClans
            // 
            this.tabPageClans.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageClans.Location = new System.Drawing.Point(4, 22);
            this.tabPageClans.Name = "tabPageClans";
            this.tabPageClans.Size = new System.Drawing.Size(742, 449);
            this.tabPageClans.TabIndex = 2;
            this.tabPageClans.Text = "Clanvergleich";
            // 
            // tabPageCommandersuche
            // 
            this.tabPageCommandersuche.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCommandersuche.Controls.Add(this.textBoxRang);
            this.tabPageCommandersuche.Controls.Add(this.labelRang);
            this.tabPageCommandersuche.Controls.Add(this.textBoxKoord);
            this.tabPageCommandersuche.Controls.Add(this.labelKoord);
            this.tabPageCommandersuche.Controls.Add(this.dataGridViewCommanders);
            this.tabPageCommandersuche.Controls.Add(this.textBoxClan);
            this.tabPageCommandersuche.Controls.Add(this.textBoxCommander);
            this.tabPageCommandersuche.Controls.Add(this.labelClan);
            this.tabPageCommandersuche.Controls.Add(this.labelCommander);
            this.tabPageCommandersuche.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandersuche.Name = "tabPageCommandersuche";
            this.tabPageCommandersuche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandersuche.Size = new System.Drawing.Size(742, 449);
            this.tabPageCommandersuche.TabIndex = 0;
            this.tabPageCommandersuche.Text = "Commandersuche";
            // 
            // textBoxRang
            // 
            this.textBoxRang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxRang.Enabled = false;
            this.textBoxRang.Location = new System.Drawing.Point(150, 35);
            this.textBoxRang.Name = "textBoxRang";
            this.textBoxRang.Size = new System.Drawing.Size(100, 20);
            this.textBoxRang.TabIndex = 2;
            this.textBoxRang.Text = "Loading KartenTXT...";
            this.textBoxRang.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelRang
            // 
            this.labelRang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelRang.AutoSize = true;
            this.labelRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRang.Location = new System.Drawing.Point(50, 40);
            this.labelRang.Name = "labelRang";
            this.labelRang.Size = new System.Drawing.Size(37, 13);
            this.labelRang.TabIndex = 16;
            this.labelRang.Text = "Rang";
            this.labelRang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxKoord
            // 
            this.textBoxKoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxKoord.Enabled = false;
            this.textBoxKoord.Location = new System.Drawing.Point(350, 35);
            this.textBoxKoord.Name = "textBoxKoord";
            this.textBoxKoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoord.TabIndex = 4;
            this.textBoxKoord.Text = "Loading KartenTXT...";
            this.textBoxKoord.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelKoord
            // 
            this.labelKoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelKoord.AutoSize = true;
            this.labelKoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKoord.Location = new System.Drawing.Point(300, 40);
            this.labelKoord.Name = "labelKoord";
            this.labelKoord.Size = new System.Drawing.Size(40, 13);
            this.labelKoord.TabIndex = 14;
            this.labelKoord.Text = "Koord";
            this.labelKoord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCommanders
            // 
            this.dataGridViewCommanders.AllowUserToAddRows = false;
            this.dataGridViewCommanders.AllowUserToDeleteRows = false;
            this.dataGridViewCommanders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCommanders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCommanders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quad,
            this.Omni,
            this.Commandername,
            this.Basis,
            this.Clan,
            this.Rang});
            this.dataGridViewCommanders.Location = new System.Drawing.Point(0, 70);
            this.dataGridViewCommanders.Name = "dataGridViewCommanders";
            this.dataGridViewCommanders.Size = new System.Drawing.Size(742, 379);
            this.dataGridViewCommanders.TabIndex = 11;
            this.dataGridViewCommanders.TabStop = false;
            // 
            // textBoxClan
            // 
            this.textBoxClan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxClan.Enabled = false;
            this.textBoxClan.Location = new System.Drawing.Point(350, 5);
            this.textBoxClan.Name = "textBoxClan";
            this.textBoxClan.Size = new System.Drawing.Size(100, 20);
            this.textBoxClan.TabIndex = 1;
            this.textBoxClan.Text = "Loading KartenTXT...";
            this.textBoxClan.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxCommander
            // 
            this.textBoxCommander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCommander.Enabled = false;
            this.textBoxCommander.Location = new System.Drawing.Point(150, 5);
            this.textBoxCommander.Name = "textBoxCommander";
            this.textBoxCommander.Size = new System.Drawing.Size(100, 20);
            this.textBoxCommander.TabIndex = 0;
            this.textBoxCommander.Text = "Loading KartenTXT...";
            this.textBoxCommander.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelClan
            // 
            this.labelClan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelClan.AutoSize = true;
            this.labelClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClan.Location = new System.Drawing.Point(300, 10);
            this.labelClan.Name = "labelClan";
            this.labelClan.Size = new System.Drawing.Size(32, 13);
            this.labelClan.TabIndex = 9;
            this.labelClan.Text = "Clan";
            this.labelClan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommander
            // 
            this.labelCommander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCommander.AutoSize = true;
            this.labelCommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommander.Location = new System.Drawing.Point(50, 10);
            this.labelCommander.Name = "labelCommander";
            this.labelCommander.Size = new System.Drawing.Size(72, 13);
            this.labelCommander.TabIndex = 7;
            this.labelCommander.Text = "Commander";
            this.labelCommander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlKartentools
            // 
            this.tabControlKartentools.Controls.Add(this.tabPageCommandersuche);
            this.tabControlKartentools.Controls.Add(this.tabPageClans);
            this.tabControlKartentools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlKartentools.Location = new System.Drawing.Point(0, 25);
            this.tabControlKartentools.Name = "tabControlKartentools";
            this.tabControlKartentools.SelectedIndex = 0;
            this.tabControlKartentools.Size = new System.Drawing.Size(750, 475);
            this.tabControlKartentools.TabIndex = 1;
            // 
            // Quad
            // 
            this.Quad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quad.HeaderText = "Quad";
            this.Quad.Name = "Quad";
            this.Quad.ReadOnly = true;
            this.Quad.Width = 58;
            // 
            // Omni
            // 
            this.Omni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Omni.HeaderText = "Omni";
            this.Omni.Name = "Omni";
            this.Omni.ReadOnly = true;
            this.Omni.Width = 56;
            // 
            // Commandername
            // 
            this.Commandername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Commandername.HeaderText = "Commandername";
            this.Commandername.Name = "Commandername";
            this.Commandername.ReadOnly = true;
            // 
            // Basis
            // 
            this.Basis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Basis.HeaderText = "Basis";
            this.Basis.Name = "Basis";
            this.Basis.ReadOnly = true;
            // 
            // Clan
            // 
            this.Clan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Clan.HeaderText = "Clan";
            this.Clan.Name = "Clan";
            this.Clan.ReadOnly = true;
            this.Clan.Width = 53;
            // 
            // Rang
            // 
            this.Rang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Rang.HeaderText = "Rang";
            this.Rang.Name = "Rang";
            this.Rang.ReadOnly = true;
            this.Rang.Width = 58;
            // 
            // KartenTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlKartentools);
            this.Controls.Add(this.labelKartentools);
            this.Name = "KartenTXT";
            this.Size = new System.Drawing.Size(750, 500);
            this.tabPageCommandersuche.ResumeLayout(false);
            this.tabPageCommandersuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommanders)).EndInit();
            this.tabControlKartentools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKartentools;
        private System.ComponentModel.BackgroundWorker backgroundWorkerKartenTXTParser;
        private System.Windows.Forms.TabPage tabPageClans;
        private System.Windows.Forms.TabPage tabPageCommandersuche;
        private System.Windows.Forms.TextBox textBoxKoord;
        private System.Windows.Forms.Label labelKoord;
        private System.Windows.Forms.DataGridView dataGridViewCommanders;
        private System.Windows.Forms.TextBox textBoxClan;
        private System.Windows.Forms.TextBox textBoxCommander;
        private System.Windows.Forms.Label labelClan;
        private System.Windows.Forms.Label labelCommander;
        private System.Windows.Forms.TabControl tabControlKartentools;
        private System.Windows.Forms.TextBox textBoxRang;
        private System.Windows.Forms.Label labelRang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commandername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rang;
    }
}
