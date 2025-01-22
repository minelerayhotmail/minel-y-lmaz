namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void müþterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Müþteriler frm = new Frm_Müþteriler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}