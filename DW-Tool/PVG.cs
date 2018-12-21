namespace DW
{
    public partial class PVG : System.Windows.Forms.UserControl
    {

        private bool blockEvents = true;

        public PVG()
        {
            InitializeComponent();
            comboBoxArt.SelectedIndex = 0;
            comboBoxLevel.SelectedIndex = 10;
            blockEvents = false;
        }

        private void droidUC_Changed(object sender, System.EventArgs e)
        {
            computeUran();
        }

        private void comboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            compute();
        }

        private void radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            compute();
        }

        private void compute()
        {
            if (radioButtonToRight.Checked)
                computeUran();
            else
                computeDroids();
        }

        private void numericUpDownUran_ValueChanged(object sender, System.EventArgs e)
        {
            computeDroids();
        }

        private void computeUran()
        {
            if (!blockEvents)
            {
                blockEvents = true;
                int uran = 0;
                if (comboBoxLevel.SelectedIndex > 0)
                {
                    foreach (System.Collections.Generic.KeyValuePair<string, int> pair in droidUC.DroidCount)
                    {
                        Droid d;
                        if ((droidUC.Droids.TryGetValue(pair.Key, out d)) && (d.PVGValue > 0))
                        {
                            switch (comboBoxArt.SelectedIndex)
                            {
                                case 0:
                                    {
                                        uran = uran + pair.Value * d.DefValue * (14 - comboBoxLevel.SelectedIndex);
                                        break;
                                    }
                                case 1:
                                    {
                                        uran = System.Convert.ToInt32(uran + pair.Value * d.DefValue * (14 - comboBoxLevel.SelectedIndex) * 1.5);
                                        break;
                                    }
                                case 2:
                                    {
                                        uran = uran + pair.Value * d.DefValue * (14 - comboBoxLevel.SelectedIndex) * 3;
                                        break;
                                    }
                            }
                        }
                    }
                }
                radioButtonToRight.Checked = true;
                try
                {
                    numericUpDownUran.Value = uran;
                }
                catch (System.ArgumentOutOfRangeException) { }
                blockEvents = false;
            }
        }

        private void computeDroids()
        {
            if (!blockEvents)
            {
                blockEvents = true;
                int uran = (int)numericUpDownUran.Value;
                System.Collections.Generic.Dictionary<string, int> droidCount = new System.Collections.Generic.Dictionary<string, int>();
                foreach (string name in droidUC.Droids.Keys)
                {
                    int number = 0;
                    if (comboBoxLevel.SelectedIndex > 0)
                    {
                        Droid d;
                        if ((droidUC.Droids.TryGetValue(name, out d)) && (d.PVGValue > 0))
                        {
                            switch (comboBoxArt.SelectedIndex)
                            {
                                case 0:
                                    {
                                        number = uran / (d.DefValue * (14 - comboBoxLevel.SelectedIndex));
                                        break;
                                    }
                                case 1:
                                    {
                                        number = (int)(uran / (d.DefValue * (14 - comboBoxLevel.SelectedIndex) * 1.5));
                                        break;
                                    }
                                case 2:
                                    {
                                        number = uran / (d.DefValue * (14 - comboBoxLevel.SelectedIndex) * 3);
                                        break;
                                    }
                            }
                        }
                    }
                    droidCount.Add(name, number);
                }
                droidUC.DroidCount = droidCount;
                radioButtonToLeft.Checked = true;
                blockEvents = false;
            }
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            blockEvents = true;
            System.Collections.Generic.Dictionary<string, int> droidCount = new System.Collections.Generic.Dictionary<string, int>();
            foreach (string name in droidUC.Droids.Keys)
            {
                droidCount.Add(name, 0);
            }
            numericUpDownUran.Value = 0;
            droidUC.DroidCount = droidCount;
            blockEvents = false;
        }

        private void numericUpDown_Enter(object sender, System.EventArgs e)
        {
            System.Windows.Forms.NumericUpDown answerBox = sender as System.Windows.Forms.NumericUpDown;
            if (answerBox != null)
            {
                answerBox.Select(0, answerBox.Value.ToString().Length);
            }
        }
    }
}
