using System;
using System.Windows.Forms;
using Keystroke.API;


namespace PasteAnywhere
{
    public partial class frmMain : Form
    {
        KeystrokeAPI api = new KeystrokeAPI();
        public frmMain()
        {
            InitializeComponent();
            api.CreateKeyboardHook((character) =>
            {
                if (character.ToString() == "<F4>")
                {
                    SendKeys.Send(Clipboard.GetText());
                }
            });

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            updateContent();
        }

        private void updateContent()
        {
            txtPasteContent.Text = Clipboard.GetText();
        }

        private void icoTray_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void icoTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void icoTray_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
