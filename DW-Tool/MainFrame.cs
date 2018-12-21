namespace DW
{
    public partial class MainFrame : System.Windows.Forms.Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Resize(object sender, System.EventArgs e)
        {
            if (System.Windows.Forms.FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
            else if (System.Windows.Forms.FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, System.EventArgs e)
        {
            this.Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void toolStripMenuItemExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
    }
}
