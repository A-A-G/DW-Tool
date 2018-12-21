namespace DW
{
    partial class MainFrame
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAngriffsrechner = new System.Windows.Forms.TabPage();
            this.tabPagePVG = new System.Windows.Forms.TabPage();
            this.tabPageRMPlaner = new System.Windows.Forms.TabPage();
            this.tabPageClanpunkte = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.angriffsrechner = new DW.Angriffsrechner();
            this.pvg = new DW.PVG();
            this.rmPlaner = new DW.RMPlaner();
            this.clanpunkte = new DW.Clanpunkte();
            this.tabPageKartentools = new System.Windows.Forms.TabPage();
            this.kartenTXT1 = new DW.Kartentools.KartenTXT();
            this.tabControl.SuspendLayout();
            this.tabPageAngriffsrechner.SuspendLayout();
            this.tabPagePVG.SuspendLayout();
            this.tabPageRMPlaner.SuspendLayout();
            this.tabPageClanpunkte.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.tabPageKartentools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAngriffsrechner);
            this.tabControl.Controls.Add(this.tabPagePVG);
            this.tabControl.Controls.Add(this.tabPageRMPlaner);
            this.tabControl.Controls.Add(this.tabPageClanpunkte);
            this.tabControl.Controls.Add(this.tabPageKartentools);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(699, 622);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageAngriffsrechner
            // 
            this.tabPageAngriffsrechner.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAngriffsrechner.Controls.Add(this.angriffsrechner);
            this.tabPageAngriffsrechner.Location = new System.Drawing.Point(4, 22);
            this.tabPageAngriffsrechner.Name = "tabPageAngriffsrechner";
            this.tabPageAngriffsrechner.Size = new System.Drawing.Size(691, 596);
            this.tabPageAngriffsrechner.TabIndex = 3;
            this.tabPageAngriffsrechner.Text = "Angriffsrechner";
            // 
            // tabPagePVG
            // 
            this.tabPagePVG.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePVG.Controls.Add(this.pvg);
            this.tabPagePVG.Location = new System.Drawing.Point(4, 22);
            this.tabPagePVG.Name = "tabPagePVG";
            this.tabPagePVG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePVG.Size = new System.Drawing.Size(691, 596);
            this.tabPagePVG.TabIndex = 0;
            this.tabPagePVG.Text = "PVG-Rechner";
            // 
            // tabPageRMPlaner
            // 
            this.tabPageRMPlaner.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRMPlaner.Controls.Add(this.rmPlaner);
            this.tabPageRMPlaner.Location = new System.Drawing.Point(4, 22);
            this.tabPageRMPlaner.Name = "tabPageRMPlaner";
            this.tabPageRMPlaner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRMPlaner.Size = new System.Drawing.Size(691, 596);
            this.tabPageRMPlaner.TabIndex = 1;
            this.tabPageRMPlaner.Text = "RM-Planer";
            // 
            // tabPageClanpunkte
            // 
            this.tabPageClanpunkte.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageClanpunkte.Controls.Add(this.clanpunkte);
            this.tabPageClanpunkte.Location = new System.Drawing.Point(4, 22);
            this.tabPageClanpunkte.Name = "tabPageClanpunkte";
            this.tabPageClanpunkte.Size = new System.Drawing.Size(691, 596);
            this.tabPageClanpunkte.TabIndex = 2;
            this.tabPageClanpunkte.Text = "CP-Rechner";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemExit});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(105, 48);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // angriffsrechner
            // 
            this.angriffsrechner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angriffsrechner.Location = new System.Drawing.Point(0, 0);
            this.angriffsrechner.Name = "angriffsrechner";
            this.angriffsrechner.Size = new System.Drawing.Size(691, 596);
            this.angriffsrechner.TabIndex = 0;
            // 
            // pvg
            // 
            this.pvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvg.Location = new System.Drawing.Point(3, 3);
            this.pvg.Name = "pvg";
            this.pvg.Size = new System.Drawing.Size(685, 590);
            this.pvg.TabIndex = 0;
            // 
            // rmPlaner
            // 
            this.rmPlaner.BackColor = System.Drawing.SystemColors.Control;
            this.rmPlaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rmPlaner.Location = new System.Drawing.Point(3, 3);
            this.rmPlaner.Name = "rmPlaner";
            this.rmPlaner.Size = new System.Drawing.Size(685, 590);
            this.rmPlaner.TabIndex = 0;
            // 
            // clanpunkte
            // 
            this.clanpunkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clanpunkte.Location = new System.Drawing.Point(0, 0);
            this.clanpunkte.Name = "clanpunkte";
            this.clanpunkte.Size = new System.Drawing.Size(691, 596);
            this.clanpunkte.TabIndex = 0;
            // 
            // tabPageKartentools
            // 
            this.tabPageKartentools.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageKartentools.Controls.Add(this.kartenTXT1);
            this.tabPageKartentools.Location = new System.Drawing.Point(4, 22);
            this.tabPageKartentools.Name = "tabPageKartentools";
            this.tabPageKartentools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKartentools.Size = new System.Drawing.Size(691, 596);
            this.tabPageKartentools.TabIndex = 4;
            this.tabPageKartentools.Text = "Kartentools";
            // 
            // kartenTXT1
            // 
            this.kartenTXT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kartenTXT1.Location = new System.Drawing.Point(3, 3);
            this.kartenTXT1.Name = "kartenTXT1";
            this.kartenTXT1.Size = new System.Drawing.Size(685, 590);
            this.kartenTXT1.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 622);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "DW-Tool";
            this.Resize += new System.EventHandler(this.MainFrame_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPageAngriffsrechner.ResumeLayout(false);
            this.tabPagePVG.ResumeLayout(false);
            this.tabPageRMPlaner.ResumeLayout(false);
            this.tabPageClanpunkte.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.tabPageKartentools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PVG pvg;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePVG;
        private System.Windows.Forms.TabPage tabPageRMPlaner;
        private RMPlaner rmPlaner;
        private System.Windows.Forms.TabPage tabPageClanpunkte;
        private Clanpunkte clanpunkte;
        private System.Windows.Forms.TabPage tabPageAngriffsrechner;
        private Angriffsrechner angriffsrechner;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.TabPage tabPageKartentools;
        private Kartentools.KartenTXT kartenTXT1;

    }
}

