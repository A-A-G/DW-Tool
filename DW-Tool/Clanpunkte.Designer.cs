namespace DW
{
    partial class Clanpunkte
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
            this.labelClanpunkte = new System.Windows.Forms.Label();
            this.labelBattlepoints = new System.Windows.Forms.Label();
            this.numericUpDownBattlepoints = new System.Windows.Forms.NumericUpDown();
            this.labelEisen = new System.Windows.Forms.Label();
            this.numericUpDownEisen = new System.Windows.Forms.NumericUpDown();
            this.labelKVP = new System.Windows.Forms.Label();
            this.numericUpDownKVP = new System.Windows.Forms.NumericUpDown();
            this.labelClanpoints = new System.Windows.Forms.Label();
            this.labelÖl = new System.Windows.Forms.Label();
            this.labelUran = new System.Windows.Forms.Label();
            this.labelTitan = new System.Windows.Forms.Label();
            this.numericUpDownUran = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTitan = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownÖl = new System.Windows.Forms.NumericUpDown();
            this.labelClanpointResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBattlepoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEisen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTitan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownÖl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClanpunkte
            // 
            this.labelClanpunkte.AutoSize = true;
            this.labelClanpunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClanpunkte.Location = new System.Drawing.Point(10, 10);
            this.labelClanpunkte.Name = "labelClanpunkte";
            this.labelClanpunkte.Size = new System.Drawing.Size(201, 24);
            this.labelClanpunkte.TabIndex = 0;
            this.labelClanpunkte.Text = "Clanpunkte Rechner";
            // 
            // labelBattlepoints
            // 
            this.labelBattlepoints.AutoSize = true;
            this.labelBattlepoints.Location = new System.Drawing.Point(10, 150);
            this.labelBattlepoints.Name = "labelBattlepoints";
            this.labelBattlepoints.Size = new System.Drawing.Size(65, 13);
            this.labelBattlepoints.TabIndex = 1;
            this.labelBattlepoints.Text = "Battlepoints:";
            // 
            // numericUpDownBattlepoints
            // 
            this.numericUpDownBattlepoints.Location = new System.Drawing.Point(90, 147);
            this.numericUpDownBattlepoints.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBattlepoints.Name = "numericUpDownBattlepoints";
            this.numericUpDownBattlepoints.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBattlepoints.TabIndex = 5;
            this.numericUpDownBattlepoints.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownBattlepoints.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelEisen
            // 
            this.labelEisen.AutoSize = true;
            this.labelEisen.Location = new System.Drawing.Point(10, 70);
            this.labelEisen.Name = "labelEisen";
            this.labelEisen.Size = new System.Drawing.Size(58, 13);
            this.labelEisen.TabIndex = 3;
            this.labelEisen.Text = "Eisenmine:";
            // 
            // numericUpDownEisen
            // 
            this.numericUpDownEisen.Location = new System.Drawing.Point(90, 67);
            this.numericUpDownEisen.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownEisen.Name = "numericUpDownEisen";
            this.numericUpDownEisen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEisen.TabIndex = 1;
            this.numericUpDownEisen.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownEisen.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelKVP
            // 
            this.labelKVP.AutoSize = true;
            this.labelKVP.Location = new System.Drawing.Point(10, 50);
            this.labelKVP.Name = "labelKVP";
            this.labelKVP.Size = new System.Drawing.Size(31, 13);
            this.labelKVP.TabIndex = 5;
            this.labelKVP.Text = "KVP:";
            // 
            // numericUpDownKVP
            // 
            this.numericUpDownKVP.Location = new System.Drawing.Point(90, 47);
            this.numericUpDownKVP.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownKVP.Name = "numericUpDownKVP";
            this.numericUpDownKVP.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKVP.TabIndex = 0;
            this.numericUpDownKVP.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownKVP.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownKVP.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelClanpoints
            // 
            this.labelClanpoints.AutoSize = true;
            this.labelClanpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClanpoints.Location = new System.Drawing.Point(10, 190);
            this.labelClanpoints.Name = "labelClanpoints";
            this.labelClanpoints.Size = new System.Drawing.Size(89, 17);
            this.labelClanpoints.TabIndex = 7;
            this.labelClanpoints.Text = "Clanpoints:";
            // 
            // labelÖl
            // 
            this.labelÖl.AutoSize = true;
            this.labelÖl.Location = new System.Drawing.Point(10, 110);
            this.labelÖl.Name = "labelÖl";
            this.labelÖl.Size = new System.Drawing.Size(79, 13);
            this.labelÖl.TabIndex = 8;
            this.labelÖl.Text = "Ölförderanlage:";
            // 
            // labelUran
            // 
            this.labelUran.AutoSize = true;
            this.labelUran.Location = new System.Drawing.Point(10, 130);
            this.labelUran.Name = "labelUran";
            this.labelUran.Size = new System.Drawing.Size(55, 13);
            this.labelUran.TabIndex = 9;
            this.labelUran.Text = "Uranmine:";
            // 
            // labelTitan
            // 
            this.labelTitan.AutoSize = true;
            this.labelTitan.Location = new System.Drawing.Point(10, 90);
            this.labelTitan.Name = "labelTitan";
            this.labelTitan.Size = new System.Drawing.Size(56, 13);
            this.labelTitan.TabIndex = 10;
            this.labelTitan.Text = "Titanmine:";
            // 
            // numericUpDownUran
            // 
            this.numericUpDownUran.Location = new System.Drawing.Point(90, 127);
            this.numericUpDownUran.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownUran.Name = "numericUpDownUran";
            this.numericUpDownUran.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUran.TabIndex = 4;
            this.numericUpDownUran.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownUran.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownTitan
            // 
            this.numericUpDownTitan.Location = new System.Drawing.Point(90, 87);
            this.numericUpDownTitan.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownTitan.Name = "numericUpDownTitan";
            this.numericUpDownTitan.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTitan.TabIndex = 2;
            this.numericUpDownTitan.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownTitan.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownÖl
            // 
            this.numericUpDownÖl.Location = new System.Drawing.Point(90, 107);
            this.numericUpDownÖl.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownÖl.Name = "numericUpDownÖl";
            this.numericUpDownÖl.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownÖl.TabIndex = 3;
            this.numericUpDownÖl.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownÖl.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelClanpointResult
            // 
            this.labelClanpointResult.BackColor = System.Drawing.SystemColors.Window;
            this.labelClanpointResult.Location = new System.Drawing.Point(100, 190);
            this.labelClanpointResult.Name = "labelClanpointResult";
            this.labelClanpointResult.Size = new System.Drawing.Size(110, 20);
            this.labelClanpointResult.TabIndex = 11;
            // 
            // Clanpunkte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelClanpointResult);
            this.Controls.Add(this.numericUpDownÖl);
            this.Controls.Add(this.numericUpDownTitan);
            this.Controls.Add(this.numericUpDownUran);
            this.Controls.Add(this.labelTitan);
            this.Controls.Add(this.labelUran);
            this.Controls.Add(this.labelÖl);
            this.Controls.Add(this.labelClanpoints);
            this.Controls.Add(this.numericUpDownKVP);
            this.Controls.Add(this.labelKVP);
            this.Controls.Add(this.numericUpDownEisen);
            this.Controls.Add(this.labelEisen);
            this.Controls.Add(this.numericUpDownBattlepoints);
            this.Controls.Add(this.labelBattlepoints);
            this.Controls.Add(this.labelClanpunkte);
            this.Name = "Clanpunkte";
            this.Size = new System.Drawing.Size(230, 230);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBattlepoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEisen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTitan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownÖl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClanpunkte;
        private System.Windows.Forms.Label labelBattlepoints;
        private System.Windows.Forms.NumericUpDown numericUpDownBattlepoints;
        private System.Windows.Forms.Label labelEisen;
        private System.Windows.Forms.NumericUpDown numericUpDownEisen;
        private System.Windows.Forms.Label labelKVP;
        private System.Windows.Forms.NumericUpDown numericUpDownKVP;
        private System.Windows.Forms.Label labelClanpoints;
        private System.Windows.Forms.Label labelÖl;
        private System.Windows.Forms.Label labelUran;
        private System.Windows.Forms.Label labelTitan;
        private System.Windows.Forms.NumericUpDown numericUpDownUran;
        private System.Windows.Forms.NumericUpDown numericUpDownTitan;
        private System.Windows.Forms.NumericUpDown numericUpDownÖl;
        private System.Windows.Forms.Label labelClanpointResult;
    }
}
