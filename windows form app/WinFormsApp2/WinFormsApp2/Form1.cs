namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Müşteriler frm = new Frm_Müşteriler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}