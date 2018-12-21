namespace DW
{
    public partial class Angriffsrechner : System.Windows.Forms.UserControl
    {
        #region globals
        System.Collections.Generic.List<Droid> _turretList = new System.Collections.Generic.List<Droid>();
        System.Collections.Generic.Dictionary<string, Droid> _turretMap = new System.Collections.Generic.Dictionary<string, Droid>();
        System.Collections.Generic.Dictionary<string, System.Windows.Forms.NumericUpDown> _nudMap = new System.Collections.Generic.Dictionary<string, System.Windows.Forms.NumericUpDown>();
        #endregion

        #region constructor
        public Angriffsrechner()
        {
            InitializeComponent();
            initializeTurrets();
            initializeNUDMap();
            comboBoxArt.SelectedIndex = 0;
            comboBoxLevel.SelectedIndex = 10;
            comboBoxOffensiv.SelectedIndex = 14;
            comboBoxAngreiferBoni.SelectedIndex = 12;
            comboBoxVerteidigerBoni.SelectedIndex = 12;
        }

        private void initializeTurrets()
        {
            _turretList.Add(new Droid("Verteidigungszentrum", 5, 10, 0));
            _turretList.Add(new Droid("Autokanone", 160, 15, 0));
            _turretList.Add(new Droid("Lasergeschütz", 220, 25, 0));
            _turretList.Add(new Droid("Plasmawerfer", 420, 260, 0));
            _turretList.Add(new Droid("Raketenstellung", 480, 45, 0));
            _turretList.Add(new Droid("Disruptorturm", 320, 90, 0));
            _turretList.Add(new Droid("Drohnenabwehr", 40, 10, 0));
            _turretList.Add(new Droid("Schwerer Plasmawerfer", 810, 450, 0));
            _turretList.Add(new Droid("Gazerturm", 580, 290, 0));
            _turretList.Add(new Droid("Helixturm", 80, 140, 0));
            foreach (Droid droid in _turretList)
            {
                _turretMap.Add(droid.Name, droid);
            }
        }

        private void initializeNUDMap()
        {
            _nudMap.Add("Verteidigungszentrum", numericUpDownVZLevel);
            _nudMap.Add("Autokanone", numericUpDownAutokanone);
            _nudMap.Add("Lasergeschütz", numericUpDownLasergeschütz);
            _nudMap.Add("Plasmawerfer", numericUpDownPlasmawerfer);
            _nudMap.Add("Raketenstellung", numericUpDownRaketenstellung);
            _nudMap.Add("Disruptorturm", numericUpDownDisruptorturm);
            _nudMap.Add("Drohnenabwehr", numericUpDownDrohnenabwehr);
            _nudMap.Add("Schwerer Plasmawerfer", numericUpDownSchwererPlasmawerfer);
            _nudMap.Add("Gazerturm", numericUpDownGazerturm);
            _nudMap.Add("Helixturm", numericUpDownHelixturm);
        }
        #endregion

        #region NumericUpDown events
        private void numericUpDown_Enter(object sender, System.EventArgs e)
        {
            System.Windows.Forms.NumericUpDown senderNUD = sender as System.Windows.Forms.NumericUpDown;
            if (senderNUD != null)
                senderNUD.Select(0, senderNUD.Value.ToString().Length);
        }

        private void numericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            //compute new results
            computeValues();
        }


        private void numericUpDown_Leave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.NumericUpDown senderNUD = sender as System.Windows.Forms.NumericUpDown;
            if(senderNUD != null)
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

        #region DroidUC events
        private void droidUCAngreifer_Changed(object sender, System.EventArgs e)
        {
            computeUran();
            //compute new results
            computeValues();
        }

        private void droidUCVerteidiger_Changed(object sender, System.EventArgs e)
        {
            //compute new results
            computeValues();
        }
        #endregion

        #region PVG
        private void comboBoxArt_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            computeUran();
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            computeUran();
        }

        private void computeUran()
        {
            int uran = 0;
            if (comboBoxLevel.SelectedIndex>0)
            {
                foreach (System.Collections.Generic.KeyValuePair<string, int> pair in droidUCAngreifer.DroidCount)
                {
                    Droid d;
                    if ((droidUCAngreifer.Droids.TryGetValue(pair.Key, out d)) && (d.PVGValue > 0))
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
            labelUranResult.Text = System.Convert.ToString(uran);
        }
        #endregion

        #region Bonis
        private void buttonMaxAngreifer_Click(object sender, System.EventArgs e)
        {
            //Offensiv
            checkBoxOffensiv.Checked = true;
            comboBoxOffensiv.Enabled = true;
            comboBoxOffensiv.SelectedIndex = 29;
            //Angreifer
            checkBoxAngreiferBoni.Checked = true;
            comboBoxAngreiferBoni.Enabled = true;
            comboBoxAngreiferBoni.SelectedIndex = 24;
            //Verteidiger
            checkBoxVerteidigerBoni.Checked = true;
            comboBoxVerteidigerBoni.Enabled = true;
            comboBoxVerteidigerBoni.SelectedIndex = 0;
            //compute new results
            computeValues();
        }

        private void buttonMaxVerteidiger_Click(object sender, System.EventArgs e)
        {
            //Offensiv
            checkBoxOffensiv.Checked = false;
            comboBoxOffensiv.Enabled = false;
            comboBoxOffensiv.SelectedIndex = 14;
            //Angreifer
            checkBoxAngreiferBoni.Checked = true;
            comboBoxAngreiferBoni.Enabled = true;
            comboBoxAngreiferBoni.SelectedIndex = 0;
            //Verteidiger
            checkBoxVerteidigerBoni.Checked = true;
            comboBoxVerteidigerBoni.Enabled = true;
            comboBoxVerteidigerBoni.SelectedIndex = 24;
            //compute new results
            computeValues();
        }

        private void buttonNoBoni_Click(object sender, System.EventArgs e)
        {
            //Offensiv
            checkBoxOffensiv.Checked = false;
            comboBoxOffensiv.Enabled = false;
            comboBoxOffensiv.SelectedIndex = 14;
            //Angreifer
            checkBoxAngreiferBoni.Checked = false;
            comboBoxAngreiferBoni.Enabled = false;
            comboBoxAngreiferBoni.SelectedIndex = 12;
            //Verteidiger
            checkBoxVerteidigerBoni.Checked = false;
            comboBoxVerteidigerBoni.Enabled = false;
            comboBoxVerteidigerBoni.SelectedIndex = 12;
            //compute new results
            computeValues();
        }

        private void checkBoxOffensiv_CheckedChanged(object sender, System.EventArgs e)
        {
            comboBoxOffensiv.Enabled = checkBoxOffensiv.Checked;
            //compute new results
            computeValues();
        }

        private void checkBoxAngreiferBoni_CheckedChanged(object sender, System.EventArgs e)
        {
            comboBoxAngreiferBoni.Enabled = checkBoxAngreiferBoni.Checked;
            //compute new results
            computeValues();
        }

        private void checkBoxVerteidigerBoni_CheckedChanged(object sender, System.EventArgs e)
        {
            comboBoxVerteidigerBoni.Enabled = checkBoxVerteidigerBoni.Checked;
            //compute new results
            computeValues();
        }

        private void comboBoxOffensiv_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //compute new results
            computeValues();
        }

        private void comboBoxAngreiferBoni_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //compute new results
            computeValues();
        }

        private void comboBoxVerteidigerBoni_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //compute new results
            computeValues();
        }
        #endregion

        private void computeValues()
        {
            //Angreifer:
            int attvalueA = 0;
            int defvalueA = 0;
            foreach (System.Collections.Generic.KeyValuePair<string, int> pair in droidUCAngreifer.DroidCount)
            {
                Droid d;
                if (droidUCAngreifer.Droids.TryGetValue(pair.Key, out d))
                {
                    attvalueA = attvalueA + pair.Value * d.AttValue;
                    if (pair.Key == "Merger")
                        defvalueA = defvalueA + pair.Value * d.DefValue / 2;
                    else
                        defvalueA = defvalueA + pair.Value * d.DefValue;
                }
            }
            attvalueA = attvalueA + attvalueA * (int)numericUpDownKVPAngreifer.Value / 10;
            defvalueA = defvalueA + defvalueA * (int)numericUpDownKVPAngreifer.Value / 10;
            int boni = 0;
            if (checkBoxOffensiv.Checked)
                boni = boni + comboBoxOffensiv.SelectedIndex + 1;
            if (checkBoxAngreiferBoni.Checked)
                boni = boni + comboBoxAngreiferBoni.SelectedIndex - 12;
            attvalueA = attvalueA + attvalueA * boni / 100;
            defvalueA = defvalueA + defvalueA * boni / 100;
            labelAAResult.Text = System.Convert.ToString(attvalueA);
            labelAVResult.Text = System.Convert.ToString(defvalueA);
            int attvalue = attvalueA + defvalueA / 2;
            labelAGResult.Text = System.Convert.ToString(attvalue);
            //Verteidiger:
            int attvalueV = 0;
            int defvalueV = 0;
            foreach (System.Collections.Generic.KeyValuePair<string, int> pair in droidUCVerteidiger.DroidCount)
            {
                Droid d;
                if (droidUCVerteidiger.Droids.TryGetValue(pair.Key, out d))
                {
                    attvalueV = attvalueV + pair.Value * d.AttValue;
                    if (pair.Key == "Merger")
                        defvalueV = defvalueV + pair.Value * d.DefValue / 2;
                    else
                        defvalueV = defvalueV + pair.Value * d.DefValue;
                }
            }
            foreach (System.Collections.Generic.KeyValuePair<string, System.Windows.Forms.NumericUpDown> pair in _nudMap)
            {
                Droid d;
                if (_turretMap.TryGetValue(pair.Key, out d))
                {
                    attvalueV = attvalueV + (int)pair.Value.Value * d.AttValue;
                    if (pair.Key == "Merger")
                        defvalueV = defvalueV + (int)pair.Value.Value * d.DefValue / 2;
                    else
                        defvalueV = defvalueV + (int)pair.Value.Value * d.DefValue;
                }
            }
            attvalueV = attvalueV + attvalueV * (int)numericUpDownKVPVerteidiger.Value / 10;
            defvalueV = defvalueV + defvalueV * (int)numericUpDownKVPVerteidiger.Value / 10;
            if (checkBoxVerteidigerBoni.Checked)
            {
                attvalueV = attvalueV + attvalueV * (comboBoxVerteidigerBoni.SelectedIndex - 12) / 100;
                defvalueV = defvalueV + defvalueV * (comboBoxVerteidigerBoni.SelectedIndex - 12) / 100;
            }
            labelVAResult.Text = System.Convert.ToString(attvalueV);
            labelVVResult.Text = System.Convert.ToString(defvalueV);
            int defvalue = attvalueV / 2 + defvalueV;
            labelVGResult.Text = System.Convert.ToString(defvalue);
            if (attvalue != 0)
            {
                if (attvalue > defvalue)
                {
                    labelWinner.Text = "Der Angreifer gewinnt!";
                    if (defvalue != 0)
                        labelSuperior.Text = "Der Angreifer ist um " + System.Math.Round((((double)attvalue / (double)defvalue) - 1) * 100,2) + "% überlegen!";
                    else
                        labelSuperior.Text = "Der Angreifer ist absolut überlegen!";
                }
                else if (defvalue > attvalue)
                {
                    labelWinner.Text = "Der Verteidiger gewinnt!";
                    labelSuperior.Text = "Der Verteidiger ist um " + System.Math.Round((((double)defvalue / (double)attvalue) - 1) * 100,2) + "% überlegen!";
                }
                else
                {
                    labelWinner.Text = "Gleichstand? Wirklich?";
                    labelSuperior.Text = "";
                }
            }
            else
            {
                labelWinner.Text = "";
                labelSuperior.Text = "";
            }
        }
    }
}
