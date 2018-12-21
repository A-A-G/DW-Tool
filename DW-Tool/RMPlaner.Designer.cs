namespace DW
{
    partial class RMPlaner
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
            this.labelDoiden = new System.Windows.Forms.Label();
            this.labelTage = new System.Windows.Forms.Label();
            this.numericUpDownDroiden = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTage = new System.Windows.Forms.NumericUpDown();
            this.labelRaummissionen = new System.Windows.Forms.Label();
            this.labelEisen = new System.Windows.Forms.Label();
            this.labelTitan = new System.Windows.Forms.Label();
            this.labelÖl = new System.Windows.Forms.Label();
            this.labelUran = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            this.numericUpDownUranResult = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownÖlResult = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTitanResult = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEisenResult = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDroiden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTage)).BeginInit();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUranResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownÖlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTitanResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEisenResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoiden
            // 
            this.labelDoiden.AutoSize = true;
            this.labelDoiden.Location = new System.Drawing.Point(10, 55);
            this.labelDoiden.Name = "labelDoiden";
            this.labelDoiden.Size = new System.Drawing.Size(44, 13);
            this.labelDoiden.TabIndex = 0;
            this.labelDoiden.Text = "Droiden";
            this.labelDoiden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTage
            // 
            this.labelTage.AutoSize = true;
            this.labelTage.Location = new System.Drawing.Point(10, 85);
            this.labelTage.Name = "labelTage";
            this.labelTage.Size = new System.Drawing.Size(32, 13);
            this.labelTage.TabIndex = 2;
            this.labelTage.Text = "Tage";
            this.labelTage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownDroiden
            // 
            this.numericUpDownDroiden.Location = new System.Drawing.Point(60, 50);
            this.numericUpDownDroiden.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDroiden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDroiden.Name = "numericUpDownDroiden";
            this.numericUpDownDroiden.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDroiden.TabIndex = 3;
            this.numericUpDownDroiden.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDroiden.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownDroiden.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownTage
            // 
            this.numericUpDownTage.Location = new System.Drawing.Point(60, 80);
            this.numericUpDownTage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTage.Name = "numericUpDownTage";
            this.numericUpDownTage.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownTage.TabIndex = 4;
            this.numericUpDownTage.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDownTage.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelRaummissionen
            // 
            this.labelRaummissionen.AutoSize = true;
            this.labelRaummissionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaummissionen.Location = new System.Drawing.Point(10, 10);
            this.labelRaummissionen.Name = "labelRaummissionen";
            this.labelRaummissionen.Size = new System.Drawing.Size(159, 24);
            this.labelRaummissionen.TabIndex = 5;
            this.labelRaummissionen.Text = "Raummissionen";
            // 
            // labelEisen
            // 
            this.labelEisen.AutoSize = true;
            this.labelEisen.Location = new System.Drawing.Point(0, 5);
            this.labelEisen.Name = "labelEisen";
            this.labelEisen.Size = new System.Drawing.Size(36, 13);
            this.labelEisen.TabIndex = 6;
            this.labelEisen.Text = "Eisen:";
            // 
            // labelTitan
            // 
            this.labelTitan.AutoSize = true;
            this.labelTitan.Location = new System.Drawing.Point(0, 25);
            this.labelTitan.Name = "labelTitan";
            this.labelTitan.Size = new System.Drawing.Size(34, 13);
            this.labelTitan.TabIndex = 7;
            this.labelTitan.Text = "Titan:";
            // 
            // labelÖl
            // 
            this.labelÖl.AutoSize = true;
            this.labelÖl.Location = new System.Drawing.Point(0, 45);
            this.labelÖl.Name = "labelÖl";
            this.labelÖl.Size = new System.Drawing.Size(20, 13);
            this.labelÖl.TabIndex = 8;
            this.labelÖl.Text = "Öl:";
            // 
            // labelUran
            // 
            this.labelUran.AutoSize = true;
            this.labelUran.Location = new System.Drawing.Point(0, 65);
            this.labelUran.Name = "labelUran";
            this.labelUran.Size = new System.Drawing.Size(33, 13);
            this.labelUran.TabIndex = 9;
            this.labelUran.Text = "Uran:";
            // 
            // panelResults
            // 
            this.panelResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResults.Controls.Add(this.numericUpDownUranResult);
            this.panelResults.Controls.Add(this.numericUpDownÖlResult);
            this.panelResults.Controls.Add(this.numericUpDownTitanResult);
            this.panelResults.Controls.Add(this.numericUpDownEisenResult);
            this.panelResults.Controls.Add(this.labelEisen);
            this.panelResults.Controls.Add(this.labelTitan);
            this.panelResults.Controls.Add(this.labelUran);
            this.panelResults.Controls.Add(this.labelÖl);
            this.panelResults.Location = new System.Drawing.Point(10, 120);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(150, 84);
            this.panelResults.TabIndex = 11;
            // 
            // numericUpDownUranResult
            // 
            this.numericUpDownUranResult.AutoSize = true;
            this.numericUpDownUranResult.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownUranResult.Location = new System.Drawing.Point(50, 60);
            this.numericUpDownUranResult.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownUranResult.Name = "numericUpDownUranResult";
            this.numericUpDownUranResult.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownUranResult.TabIndex = 13;
            this.numericUpDownUranResult.ValueChanged += new System.EventHandler(this.numericUpDownUranResult_ValueChanged);
            this.numericUpDownUranResult.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownÖlResult
            // 
            this.numericUpDownÖlResult.AutoSize = true;
            this.numericUpDownÖlResult.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownÖlResult.Location = new System.Drawing.Point(50, 40);
            this.numericUpDownÖlResult.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownÖlResult.Name = "numericUpDownÖlResult";
            this.numericUpDownÖlResult.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownÖlResult.TabIndex = 12;
            this.numericUpDownÖlResult.ValueChanged += new System.EventHandler(this.numericUpDownÖlResult_ValueChanged);
            this.numericUpDownÖlResult.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownTitanResult
            // 
            this.numericUpDownTitanResult.AutoSize = true;
            this.numericUpDownTitanResult.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTitanResult.Location = new System.Drawing.Point(50, 20);
            this.numericUpDownTitanResult.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTitanResult.Name = "numericUpDownTitanResult";
            this.numericUpDownTitanResult.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownTitanResult.TabIndex = 11;
            this.numericUpDownTitanResult.ValueChanged += new System.EventHandler(this.numericUpDownTitanResult_ValueChanged);
            this.numericUpDownTitanResult.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownEisenResult
            // 
            this.numericUpDownEisenResult.AutoSize = true;
            this.numericUpDownEisenResult.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEisenResult.Location = new System.Drawing.Point(50, 0);
            this.numericUpDownEisenResult.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownEisenResult.Name = "numericUpDownEisenResult";
            this.numericUpDownEisenResult.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownEisenResult.TabIndex = 10;
            this.numericUpDownEisenResult.ValueChanged += new System.EventHandler(this.numericUpDownEisenResult_ValueChanged);
            this.numericUpDownEisenResult.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // RMPlaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.labelRaummissionen);
            this.Controls.Add(this.numericUpDownTage);
            this.Controls.Add(this.numericUpDownDroiden);
            this.Controls.Add(this.labelTage);
            this.Controls.Add(this.labelDoiden);
            this.Name = "RMPlaner";
            this.Size = new System.Drawing.Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDroiden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTage)).EndInit();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUranResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownÖlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTitanResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEisenResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoiden;
        private System.Windows.Forms.Label labelTage;
        private System.Windows.Forms.NumericUpDown numericUpDownDroiden;
        private System.Windows.Forms.NumericUpDown numericUpDownTage;
        private System.Windows.Forms.Label labelRaummissionen;
        private System.Windows.Forms.Label labelEisen;
        private System.Windows.Forms.Label labelTitan;
        private System.Windows.Forms.Label labelÖl;
        private System.Windows.Forms.Label labelUran;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.NumericUpDown numericUpDownUranResult;
        private System.Windows.Forms.NumericUpDown numericUpDownÖlResult;
        private System.Windows.Forms.NumericUpDown numericUpDownTitanResult;
        private System.Windows.Forms.NumericUpDown numericUpDownEisenResult;
    }
}
