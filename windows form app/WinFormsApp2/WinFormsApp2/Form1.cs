namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m��terilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_M��teriler frm = new Frm_M��teriler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}