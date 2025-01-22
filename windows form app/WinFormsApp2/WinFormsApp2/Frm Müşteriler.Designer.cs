namespace WinFormsApp2
{
    partial class Frm_Müşteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Müşteriler));
            toolStrip1 = new ToolStrip();
            btnYeniKayıt = new ToolStripButton();
            panel1 = new Panel();
            txtAra = new TextBox();
            label1 = new Label();
            btnAra = new Button();
            gridListe = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            MenultemSil = new ToolStripMenuItem();
            MenultemDuzenle = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridListe).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnYeniKayıt });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(697, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniKayıt
            // 
            btnYeniKayıt.Image = (Image)resources.GetObject("btnYeniKayıt.Image");
            btnYeniKayıt.ImageTransparentColor = Color.Magenta;
            btnYeniKayıt.Name = "btnYeniKayıt";
            btnYeniKayıt.Size = new Size(114, 29);
            btnYeniKayıt.Text = "Yeni Kayıt";
            btnYeniKayıt.Click += btnYeniKayıt_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 50);
            panel1.TabIndex = 1;
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.Location = new Point(143, 8);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(382, 39);
            txtAra.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Ara:";
            // 
            // btnAra
            // 
            btnAra.Image = (Image)resources.GetObject("btnAra.Image");
            btnAra.Location = new Point(531, 8);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(47, 34);
            btnAra.TabIndex = 2;
            btnAra.UseVisualStyleBackColor = true;
            // 
            // gridListe
            // 
            gridListe.AllowUserToAddRows = false;
            gridListe.AllowUserToDeleteRows = false;
            gridListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListe.ContextMenuStrip = contextMenuStrip1;
            gridListe.Dock = DockStyle.Fill;
            gridListe.Location = new Point(0, 84);
            gridListe.Name = "gridListe";
            gridListe.ReadOnly = true;
            gridListe.RowHeadersWidth = 62;
            gridListe.RowTemplate.Height = 33;
            gridListe.Size = new Size(697, 366);
            gridListe.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { MenultemSil, MenultemDuzenle });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 68);
            // 
            // MenultemSil
            // 
            MenultemSil.Name = "MenultemSil";
            MenultemSil.Size = new Size(147, 32);
            MenultemSil.Text = "Sil";
            MenultemSil.Click += MenultemSil_Click;
            // 
            // MenultemDuzenle
            // 
            MenultemDuzenle.Name = "MenultemDuzenle";
            MenultemDuzenle.Size = new Size(147, 32);
            MenultemDuzenle.Text = "Düzenle";
            MenultemDuzenle.Click += müşteriyiDüzenleToolStripMenuItem_Click;
            // 
            // Frm_Müşteriler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 450);
            Controls.Add(gridListe);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Frm_Müşteriler";
            Text = "Müşteri Listesi";
            WindowState = FormWindowState.Maximized;
            Load += Frm_Müşteriler_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridListe).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnYeniKayıt;
        private Panel panel1;
        private Button btnAra;
        private Label label1;
        private TextBox txtAra;
        private DataGridView gridListe;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MenultemSil;
        private ToolStripMenuItem MenultemDuzenle;
    }
}