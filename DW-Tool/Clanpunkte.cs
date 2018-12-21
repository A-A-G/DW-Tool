namespace DW
{
    public partial class Clanpunkte : System.Windows.Forms.UserControl
    {
        public Clanpunkte()
        {
            InitializeComponent();
        }

        private void numericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            labelClanpointResult.Text = System.String.Format("{0:0.00}",(1 + numericUpDownKVP.Value + (numericUpDownEisen.Value + numericUpDownTitan.Value + numericUpDownÖl.Value + numericUpDownUran.Value) / 4 + numericUpDownBattlepoints.Value / 10000));
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
