namespace WinFormsApp2
{
    partial class frmMusteri
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
            txtCustomerId = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            CampanyName = new Label();
            SuspendLayout();
            // 
            // txtCustomerId
            // 
            txtCustomerId.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerId.Location = new Point(28, 41);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(188, 39);
            txtCustomerId.TabIndex = 0;
            txtCustomerId.Text = "Custemor ID:";
            txtCustomerId.TextAlign = ContentAlignment.MiddleRight;
            txtCustomerId.Click += txtCustomerId_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(222, 41);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(222, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 39);
            textBox2.TabIndex = 3;
            // 
            // CampanyName
            // 
            CampanyName.BorderStyle = BorderStyle.FixedSingle;
            CampanyName.Location = new Point(28, 98);
            CampanyName.Name = "CampanyName";
            CampanyName.Size = new Size(188, 39);
            CampanyName.TabIndex = 2;
            CampanyName.Text = "Campany Name";
            CampanyName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmMusteri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(CampanyName);
            Controls.Add(textBox1);
            Controls.Add(txtCustomerId);
            Name = "frmMusteri";
            Text = "frmMusteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCustomerId;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label CampanyName;
    }
}