namespace DW
{
    public partial class RMPlaner : System.Windows.Forms.UserControl
    {
        private bool blockEvents = true;

        public RMPlaner()
        {
            InitializeComponent();
            blockEvents = false;
        }

        private void numericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            if ((numericUpDownDroiden.Value > 0) && (numericUpDownTage.Value > 0))
            {
                numericUpDownEisenResult.Value = (numericUpDownTage.Value * numericUpDownDroiden.Value) * 100 + 1000;
                numericUpDownTitanResult.Value = (numericUpDownTage.Value * numericUpDownDroiden.Value) * 10 + 2000;
                numericUpDownÖlResult.Value = (numericUpDownTage.Value * numericUpDownDroiden.Value) * 300 + 2500;
                numericUpDownUranResult.Value = (numericUpDownTage.Value * numericUpDownDroiden.Value) * 600 + 1200;
            }
            else
            {
                numericUpDownEisenResult.Value = 0;
                numericUpDownTitanResult.Value = 0;
                numericUpDownÖlResult.Value = 0;
                numericUpDownUranResult.Value = 0;
            }
        }

        private void numericUpDownEisenResult_ValueChanged(object sender, System.EventArgs e)
        {
            if (!blockEvents)
            {
                if ((numericUpDownEisenResult.Value - 1000) / (100 * numericUpDownDroiden.Value) > 0)
                    numericUpDownTage.Value = (int)((numericUpDownEisenResult.Value - 1000) / (100 * numericUpDownDroiden.Value));
                else
                    numericUpDownTage.Value = 0;
            }
        }

        private void numericUpDownTitanResult_ValueChanged(object sender, System.EventArgs e)
        {
            if (!blockEvents)
            {
                if ((numericUpDownTitanResult.Value - 2000) / (10 * numericUpDownDroiden.Value) > 0)
                    numericUpDownTage.Value = (int)((numericUpDownTitanResult.Value - 2000) / (10 * numericUpDownDroiden.Value));
                else
                    numericUpDownTage.Value = 0;
            }
        }

        private void numericUpDownÖlResult_ValueChanged(object sender, System.EventArgs e)
        {
            if (!blockEvents)
            {
                if ((numericUpDownÖlResult.Value - 2500) / (300 * numericUpDownDroiden.Value) > 0)
                    numericUpDownTage.Value = (int)((numericUpDownÖlResult.Value - 2500) / (300 * numericUpDownDroiden.Value));
                else
                    numericUpDownTage.Value = 0;
            }
        }

        private void numericUpDownUranResult_ValueChanged(object sender, System.EventArgs e)
        {
            if (!blockEvents)
            {
                if ((numericUpDownUranResult.Value - 1200) / (600 * numericUpDownDroiden.Value) > 0)
                    numericUpDownTage.Value = (int)((numericUpDownUranResult.Value - 1200) / (600 * numericUpDownDroiden.Value));
                else
                    numericUpDownTage.Value = 0;
            }
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
