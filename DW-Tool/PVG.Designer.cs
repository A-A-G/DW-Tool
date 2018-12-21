namespace DW
{
    partial class PVG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVG));
            this.labelPVGRechner = new System.Windows.Forms.Label();
            this.labelPVG = new System.Windows.Forms.Label();
            this.labelArt = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelUran = new System.Windows.Forms.Label();
            this.comboBoxArt = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.numericUpDownUran = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonToRight = new System.Windows.Forms.RadioButton();
            this.radioButtonToLeft = new System.Windows.Forms.RadioButton();
            this.droidUC = new DW.DroidUC();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUran)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPVGRechner
            // 
            this.labelPVGRechner.AutoSize = true;
            this.labelPVGRechner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPVGRechner.Location = new System.Drawing.Point(80, 10);
            this.labelPVGRechner.Name = "labelPVGRechner";
            this.labelPVGRechner.Size = new System.Drawing.Size(138, 24);
            this.labelPVGRechner.TabIndex = 41;
            this.labelPVGRechner.Text = "PVG Rechner";
            // 
            // labelPVG
            // 
            this.labelPVG.AutoSize = true;
            this.labelPVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPVG.Location = new System.Drawing.Point(150, 40);
            this.labelPVG.Name = "labelPVG";
            this.labelPVG.Size = new System.Drawing.Size(32, 13);
            this.labelPVG.TabIndex = 61;
            this.labelPVG.Text = "PVG";
            // 
            // labelArt
            // 
            this.labelArt.AutoSize = true;
            this.labelArt.Location = new System.Drawing.Point(150, 60);
            this.labelArt.Name = "labelArt";
            this.labelArt.Size = new System.Drawing.Size(20, 13);
            this.labelArt.TabIndex = 62;
            this.labelArt.Text = "Art";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(150, 80);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 63;
            this.labelLevel.Text = "Level";
            // 
            // labelUran
            // 
            this.labelUran.AutoSize = true;
            this.labelUran.Location = new System.Drawing.Point(150, 100);
            this.labelUran.Name = "labelUran";
            this.labelUran.Size = new System.Drawing.Size(30, 13);
            this.labelUran.TabIndex = 64;
            this.labelUran.Text = "Uran";
            // 
            // comboBoxArt
            // 
            this.comboBoxArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArt.FormattingEnabled = true;
            this.comboBoxArt.Items.AddRange(new object[] {
            "Clan",
            "BND",
            "Extern"});
            this.comboBoxArt.Location = new System.Drawing.Point(200, 60);
            this.comboBoxArt.Name = "comboBoxArt";
            this.comboBoxArt.Size = new System.Drawing.Size(70, 21);
            this.comboBoxArt.TabIndex = 2;
            this.comboBoxArt.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxLevel.Location = new System.Drawing.Point(200, 80);
            this.comboBoxLevel.MaxDropDownItems = 3;
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(70, 21);
            this.comboBoxLevel.TabIndex = 3;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // numericUpDownUran
            // 
            this.numericUpDownUran.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownUran.Location = new System.Drawing.Point(200, 100);
            this.numericUpDownUran.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownUran.Name = "numericUpDownUran";
            this.numericUpDownUran.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownUran.TabIndex = 1;
            this.numericUpDownUran.ValueChanged += new System.EventHandler(this.numericUpDownUran_ValueChanged);
            this.numericUpDownUran.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(200, 460);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 25);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonToRight
            // 
            this.radioButtonToRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonToRight.Location = new System.Drawing.Point(200, 400);
            this.radioButtonToRight.Name = "radioButtonToRight";
            this.radioButtonToRight.Size = new System.Drawing.Size(80, 25);
            this.radioButtonToRight.TabIndex = 4;
            this.radioButtonToRight.TabStop = true;
            this.radioButtonToRight.Text = "==>";
            this.radioButtonToRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonToRight.UseVisualStyleBackColor = true;
            this.radioButtonToRight.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonToLeft
            // 
            this.radioButtonToLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonToLeft.Location = new System.Drawing.Point(200, 430);
            this.radioButtonToLeft.Name = "radioButtonToLeft";
            this.radioButtonToLeft.Size = new System.Drawing.Size(80, 25);
            this.radioButtonToLeft.TabIndex = 5;
            this.radioButtonToLeft.TabStop = true;
            this.radioButtonToLeft.Text = "<==";
            this.radioButtonToLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonToLeft.UseVisualStyleBackColor = true;
            this.radioButtonToLeft.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // droidUC
            // 
            this.droidUC.DroidCount = ((System.Collections.Generic.Dictionary<string, int>)(resources.GetObject("droidUC.DroidCount")));
            this.droidUC.Location = new System.Drawing.Point(20, 40);
            this.droidUC.Name = "droidUC";
            this.droidUC.Size = new System.Drawing.Size(100, 480);
            this.droidUC.TabIndex = 0;
            this.droidUC.Changed += new DW.DroidUC.ChangedEventHandler(this.droidUC_Changed);
            // 
            // PVG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.droidUC);
            this.Controls.Add(this.radioButtonToLeft);
            this.Controls.Add(this.radioButtonToRight);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.numericUpDownUran);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxArt);
            this.Controls.Add(this.labelUran);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelArt);
            this.Controls.Add(this.labelPVG);
            this.Controls.Add(this.labelPVGRechner);
            this.Name = "PVG";
            this.Size = new System.Drawing.Size(300, 530);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPVGRechner;
        private System.Windows.Forms.Label labelPVG;
        private System.Windows.Forms.Label labelArt;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelUran;
        private System.Windows.Forms.ComboBox comboBoxArt;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownUran;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonToRight;
        private System.Windows.Forms.RadioButton radioButtonToLeft;
        private DroidUC droidUC;
    }
}
