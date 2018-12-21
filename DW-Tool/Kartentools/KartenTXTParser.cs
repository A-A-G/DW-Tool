namespace DW.Kartentools
{
    public class KartenTXTParser
    {
        #region globals
        private string kartenUrl = "http://karte.d-wars.com/karte/karten.txt.gz";

        private System.Collections.Generic.Dictionary<string, Spieler> commanderMap = new System.Collections.Generic.Dictionary<string, Spieler>();
        private Utilities.MultiMap<string, Spieler> clanMap = new Utilities.MultiMap<string, Spieler>();
        private Utilities.MultiMap<int, Spieler> quadMap = new Utilities.MultiMap<int, Spieler>();
        private System.Collections.Generic.LinkedList<Spieler> spielerListe = new System.Collections.Generic.LinkedList<Spieler>();
        #endregion

        #region events
        public delegate void FinishedEventHandler(object sender, System.EventArgs e);
        public event FinishedEventHandler Finished;
        #endregion

        #region run
        public void run()
        {
            fillFromRemoteKartenTXT();
        }

        private void fillFromRemoteKartenTXT()
        {
            string responseFromServer = string.Empty;
            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(kartenUrl);
                webRequest.Method = System.Net.WebRequestMethods.Http.Get;
                webRequest.AutomaticDecompression = System.Net.DecompressionMethods.GZip;
                System.Net.HttpWebResponse webResponse = (System.Net.HttpWebResponse)webRequest.GetResponse();
                System.IO.Stream dataStream = webResponse.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                webResponse.Close();
            }
            catch (System.Exception){}
            if (string.IsNullOrWhiteSpace(responseFromServer))
            {
                System.Windows.Forms.MessageBox.Show("Error grabbing remote karten.txt!" + System.Environment.NewLine + "Using local copy from 10.12.2011.");
                fillFromLocalKartenTXT();
            }
            else
            {
                fillMaps(responseFromServer);
            }
        }

        private void fillFromLocalKartenTXT()
        {
            fillMaps(DW.Properties.Resources.karten);
        }

        private void fillMaps(string s)
        {
            s = s.Replace("\"", "");
            foreach (string line in s.Split(new string[] { "\r\n", "\n" }, System.StringSplitOptions.RemoveEmptyEntries))
            {
                Spieler spieler = new Spieler(line);
                //commanderMap.Add(spieler.Commander, spieler);
                clanMap.Add(spieler.Clan, spieler);
                quadMap.Add(spieler.Quad, spieler);
                spielerListe.AddLast(spieler);
            }
            if (Finished != null)
            {
                Finished(this, System.EventArgs.Empty);
            }
        }
        #endregion

        #region properties
        public System.Collections.Generic.Dictionary<string, Spieler> CommanderMap
        {
            get { return commanderMap; }
        }

        public Utilities.MultiMap<string, Spieler> ClanMap
        {
            get { return clanMap; }
        }

        public Utilities.MultiMap<int, Spieler> QuadMap
        {
            get { return quadMap; }
        }

        public System.Collections.Generic.LinkedList<Spieler> Spieler
        {
            get { return spielerListe; }
        }
        #endregion
    }
}
