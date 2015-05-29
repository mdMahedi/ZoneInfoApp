using System;
using System.Windows.Forms;
using ZoneInfoApp.UI;

namespace ZoneInfoApp
{
    public partial class MainAreaUI : Form
    {
        public MainAreaUI()
        {
            InitializeComponent();
        }
        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeUI zoneTypeUi=new ZoneTypeUI();
            zoneTypeUi.ShowDialog();
        }
        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntryUi = new VisitorEntryUI();
            visitorEntryUi.ShowDialog();
        }
        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorNumberUI visitorNumberUi = new VisitorNumberUI();
            visitorNumberUi.ShowDialog();
        }
        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistiorDetailsUI vistiorDetailsUi=new VistiorDetailsUI();
            vistiorDetailsUi.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
