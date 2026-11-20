namespace esercizio_array
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            lbl_titolo = new Label();
            lbl_nome = new Label();
            lbl_cognome = new Label();
            lbl_saldo = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(79, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(321, 118);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(558, 118);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 2;
            // 
            // lbl_titolo
            // 
            lbl_titolo.AutoSize = true;
            lbl_titolo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titolo.Location = new Point(276, 24);
            lbl_titolo.Name = "lbl_titolo";
            lbl_titolo.Size = new Size(202, 32);
            lbl_titolo.TabIndex = 3;
            lbl_titolo.Text = "CONTI BANCARI";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(94, 77);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 4;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_cognome
            // 
            lbl_cognome.AutoSize = true;
            lbl_cognome.Location = new Point(321, 77);
            lbl_cognome.Name = "lbl_cognome";
            lbl_cognome.Size = new Size(63, 15);
            lbl_cognome.TabIndex = 5;
            lbl_cognome.Text = "Cognome:";
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Location = new Point(558, 77);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(39, 15);
            lbl_saldo.TabIndex = 6;
            lbl_saldo.Text = "Saldo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_saldo);
            Controls.Add(lbl_cognome);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_titolo);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label lbl_titolo;
        private Label lbl_nome;
        private Label lbl_cognome;
        private Label lbl_saldo;
    }
}
