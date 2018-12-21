namespace DW
{
    public partial class DroidUC : System.Windows.Forms.UserControl
    {
        #region globals
        System.Collections.Generic.List<Droid> _droidList = new System.Collections.Generic.List<Droid>();
        System.Collections.Generic.Dictionary<string, Droid> _droidMap = new System.Collections.Generic.Dictionary<string, Droid>();
        System.Collections.Generic.Dictionary<string, System.Windows.Forms.NumericUpDown> _nudMap = new System.Collections.Generic.Dictionary<string, System.Windows.Forms.NumericUpDown>();
        #endregion

        #region events
        public delegate void ChangedEventHandler(object sender, System.EventArgs e);
        public event ChangedEventHandler Changed;
        #endregion

        #region contructor
        public DroidUC()
        {
            InitializeComponent();
            initializeDroids();
            initializeNUDMap();
        }

        private void initializeDroids()
        {
            _droidList.Add(new Droid("Sprul", 25, 15, 0));
            _droidList.Add(new Droid("Dega", 45, 60, 240));
            _droidList.Add(new Droid("Wrot", 120, 80, 320));
            _droidList.Add(new Droid("Nomic", 140, 200, 800));
            _droidList.Add(new Droid("Visvo", 350, 100, 400));
            _droidList.Add(new Droid("Zengal", 420, 270, 1080));
            _droidList.Add(new Droid("Aspor", 340, 520, 2080));
            _droidList.Add(new Droid("Solaron", 710, 550, 2200));
            _droidList.Add(new Droid("Xenox", 470, 870, 3480));
            _droidList.Add(new Droid("Sordron", 850, 850, 0));
            _droidList.Add(new Droid("Skaron", 900, 800, 0));
            _droidList.Add(new Droid("Perior", 30, 20, 80));
            _droidList.Add(new Droid("Negator", 240, 110, 440));
            _droidList.Add(new Droid("Dexon", 15, 60, 0));
            _droidList.Add(new Droid("Merger", 10, 110, 440));
            _droidList.Add(new Droid("Raxon", 36, 360, 0));
            _droidList.Add(new Droid("Trior", 230, 10, 0));
            _droidList.Add(new Droid("Osrem", 90, 70, 280));
            _droidList.Add(new Droid("Dragoon", 290, 250, 1000));
            _droidList.Add(new Droid("Rhacal", 310, 560, 0));
            foreach (Droid droid in _droidList)
            {
                _droidMap.Add(droid.Name, droid);
            }
        }

        private void initializeNUDMap()
        {
            _nudMap.Add("Sprul", numericUpDownSprul);
            _nudMap.Add("Dega", numericUpDownDega);
            _nudMap.Add("Wrot", numericUpDownWrot);
            _nudMap.Add("Nomic", numericUpDownNomic);
            _nudMap.Add("Visvo", numericUpDownVisvo);
            _nudMap.Add("Zengal", numericUpDownZengal);
            _nudMap.Add("Aspor", numericUpDownAspor);
            _nudMap.Add("Solaron", numericUpDownSolaron);
            _nudMap.Add("Xenox", numericUpDownXenox);
            _nudMap.Add("Sordron", numericUpDownSordron);
            _nudMap.Add("Skaron", numericUpDownSkaron);
            _nudMap.Add("Perior", numericUpDownPerior);
            _nudMap.Add("Negator", numericUpDownNegator);
            _nudMap.Add("Dexon", numericUpDownDexon);
            _nudMap.Add("Merger", numericUpDownMerger);
            _nudMap.Add("Raxon", numericUpDownRaxon);
            _nudMap.Add("Trior", numericUpDownTrior);
            _nudMap.Add("Osrem", numericUpDownOsrem);
            _nudMap.Add("Dragoon", numericUpDownDragoon);
            _nudMap.Add("Rhacal", numericUpDownRhacal);
        }
        #endregion contructor

        #region properties
        public System.Collections.Generic.Dictionary<string, int> DroidCount
        {
            get
            {
                System.Collections.Generic.Dictionary<string, int> droidCount = new System.Collections.Generic.Dictionary<string, int>();
                foreach (System.Collections.Generic.KeyValuePair<string, System.Windows.Forms.NumericUpDown> pair in _nudMap)
                {
                    droidCount.Add(pair.Key, (int)pair.Value.Value);
                }
                return droidCount;
            }
            set
            {
                foreach (System.Collections.Generic.KeyValuePair<string, int> pair in value)
                {
                    System.Windows.Forms.NumericUpDown nud;
                    if (_nudMap.TryGetValue(pair.Key, out nud))
                    {
                        try
                        {
                            nud.Value = pair.Value;
                        }
                        catch (System.ArgumentOutOfRangeException) { }
                    }
                }
            }
        }

        public System.Collections.Generic.Dictionary<string, Droid> Droids
        {
            get
            {
                return _droidMap;
            }
        }
        #endregion

        #region NumericUpDown events
        private void numericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, System.EventArgs.Empty);
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

        private void numericUpDown_Leave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.NumericUpDown senderNUD = sender as System.Windows.Forms.NumericUpDown;
            if (senderNUD != null)
            {
                System.Collections.IEnumerator ien = senderNUD.Controls.GetEnumerator();
                while (ien.MoveNext()) ;
                System.Windows.Forms.TextBox tb = ien.Current as System.Windows.Forms.TextBox;
                if ((tb != null) && (string.IsNullOrWhiteSpace(tb.Text)))
                {
                    tb.Text = "0";
                    senderNUD.Value = 0;
                }
            }
        }
        #endregion
    }
}
