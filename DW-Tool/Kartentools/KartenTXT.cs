namespace DW.Kartentools
{
    public partial class KartenTXT : System.Windows.Forms.UserControl
    {
        #region globals
        bool blockEvents = false;
        KartenTXTParser parser = new KartenTXTParser();
        #endregion

        #region contructor
        public KartenTXT()
        {
            InitializeComponent();
            backgroundWorkerKartenTXTParser.RunWorkerAsync();
        }

        private void backgroundWorkerKartenTXTParser_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            parser.run();
        }

        private void backgroundWorkerKartenTXTParser_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            blockEvents = true;
            textBoxCommander.Text = "";
            textBoxCommander.Enabled = true;
            textBoxClan.Text = "";
            textBoxClan.Enabled = true;
            textBoxKoord.Text = "";
            textBoxKoord.Enabled = true;
            blockEvents = false;
            textBoxRang.Text = "";
            textBoxRang.Enabled = true;
        }
        #endregion

        #region events
        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!blockEvents)
            {
                dataGridViewCommanders.Rows.Clear();
                foreach (Spieler spieler in parser.Spieler)
                {
                    if (spieler.match(textBoxKoord.Text, textBoxCommander.Text, "", textBoxClan.Text, textBoxRang.Text))
                    {
                        dataGridViewCommanders.Rows.Add(spieler.toStringArray());
                    }
                }
            }
        }
        #endregion
    }
}
