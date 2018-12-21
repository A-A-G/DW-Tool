namespace DW.Kartentools
{
    public class Spieler
    {
        #region globals
        private string koord = "";
        private string commander = "";
        private string basis = "";
        private string clan = "";
        private string rang = "";
        private string squad = "";
        private int iquad = -1;
        #endregion

        #region constructor
        public Spieler(string koord, string commander, string basis, string clan, string rang)
        {
            this.koord = koord;
            this.commander = commander;
            this.basis = basis;
            this.clan = clan;
            this.rang = rang;
        }

        public Spieler(string cvsline)
        {
            string[] split = cvsline.Split(';');
            this.koord = split[0];
            this.commander = split[1];
            this.basis = split[2];
            this.clan = split[3];
            this.rang = split[4];
            string[] koords = koord.Split(':');
            this.squad = koords[0];
            this.iquad = System.Convert.ToInt32(koords[0]);
        }
        #endregion
        
        #region properties
        public string Koord
        {
            get { return koord; }
        }

        public string Commander
        {
            get { return commander; }
        }

        public string Basis
        {
            get { return basis; }
        }

        public string Clan
        {
            get { return clan; }
        }

        public string Rang
        {
            get { return rang; }
        }

        public int Quad
        {
            get { return iquad; }
        }
        #endregion

        public bool match(Spieler spieler)
        {
            return match(spieler.Koord, spieler.Commander, spieler.Basis, spieler.Clan, spieler.Rang);
        }

        public bool match(string koord, string commander, string basis, string clan, string rang)
        {
            if (this.koord.IndexOf(koord, System.StringComparison.CurrentCultureIgnoreCase) < 0)
                return false;
            if (this.commander.IndexOf(commander, System.StringComparison.CurrentCultureIgnoreCase) < 0)
                return false;
            if (this.basis.IndexOf(basis, System.StringComparison.CurrentCultureIgnoreCase) < 0)
                return false;
            if (this.clan.IndexOf(clan, System.StringComparison.CurrentCultureIgnoreCase) < 0)
                return false;
            if (this.rang.IndexOf(rang, System.StringComparison.CurrentCultureIgnoreCase) < 0)
                return false;
            return true;
        }

        public string[] toStringArray()
        {
            return new string[] {squad, koord, commander, basis, clan, rang};
        }
    }
}
