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
            lst_nomi = new ListBox();
            lst_numero = new ListBox();
            lst_saldo = new ListBox();
            lbl_titolo = new Label();
            lbl_nome = new Label();
            lbl_cognome = new Label();
            lbl_saldo = new Label();
            btn_n1 = new Button();
            btn_n2 = new Button();
            btn_n3 = new Button();
            btn_n4 = new Button();
            btn_n5 = new Button();
            btn_n6 = new Button();
            lst_risultato = new ListBox();
            SuspendLayout();
            // 
            // lst_nomi
            // 
            lst_nomi.FormattingEnabled = true;
            lst_nomi.Location = new Point(25, 95);
            lst_nomi.Name = "lst_nomi";
            lst_nomi.Size = new Size(120, 94);
            lst_nomi.TabIndex = 0;
            lst_nomi.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lst_numero
            // 
            lst_numero.FormattingEnabled = true;
            lst_numero.Location = new Point(172, 95);
            lst_numero.Name = "lst_numero";
            lst_numero.Size = new Size(120, 94);
            lst_numero.TabIndex = 1;
            lst_numero.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // lst_saldo
            // 
            lst_saldo.FormattingEnabled = true;
            lst_saldo.Location = new Point(321, 95);
            lst_saldo.Name = "lst_saldo";
            lst_saldo.Size = new Size(120, 94);
            lst_saldo.TabIndex = 2;
            lst_saldo.SelectedIndexChanged += listBox3_SelectedIndexChanged;
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
            lbl_nome.Location = new Point(25, 77);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(0, 15);
            lbl_nome.TabIndex = 4;
            // 
            // lbl_cognome
            // 
            lbl_cognome.AutoSize = true;
            lbl_cognome.Location = new Point(172, 77);
            lbl_cognome.Name = "lbl_cognome";
            lbl_cognome.Size = new Size(0, 15);
            lbl_cognome.TabIndex = 5;
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Location = new Point(321, 77);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(0, 15);
            lbl_saldo.TabIndex = 6;
            lbl_saldo.Click += lbl_saldo_Click;
            // 
            // btn_n1
            // 
            btn_n1.ForeColor = Color.Fuchsia;
            btn_n1.Location = new Point(25, 212);
            btn_n1.Name = "btn_n1";
            btn_n1.Size = new Size(120, 68);
            btn_n1.TabIndex = 7;
            btn_n1.Text = "Visualizzare cognome e nome dell'intestatario e il suo saldo";
            btn_n1.UseVisualStyleBackColor = true;
            btn_n1.Click += btn_n1_Click;
            // 
            // btn_n2
            // 
            btn_n2.ForeColor = Color.Fuchsia;
            btn_n2.Location = new Point(172, 212);
            btn_n2.Name = "btn_n2";
            btn_n2.Size = new Size(120, 68);
            btn_n2.TabIndex = 8;
            btn_n2.Text = "Visualizzare numero del conto e saldo";
            btn_n2.UseVisualStyleBackColor = true;
            // 
            // btn_n3
            // 
            btn_n3.ForeColor = Color.Fuchsia;
            btn_n3.Location = new Point(321, 212);
            btn_n3.Name = "btn_n3";
            btn_n3.Size = new Size(120, 68);
            btn_n3.TabIndex = 9;
            btn_n3.Text = "Visualizzare cognome e nome delle persone con il conto in rosso";
            btn_n3.UseVisualStyleBackColor = true;
            // 
            // btn_n4
            // 
            btn_n4.ForeColor = Color.Fuchsia;
            btn_n4.Location = new Point(25, 335);
            btn_n4.Name = "btn_n4";
            btn_n4.Size = new Size(120, 68);
            btn_n4.TabIndex = 10;
            btn_n4.Text = "Visualizzare cognome e nome del cliente che ha il saldo massimo";
            btn_n4.UseVisualStyleBackColor = true;
            // 
            // btn_n5
            // 
            btn_n5.ForeColor = Color.Fuchsia;
            btn_n5.Location = new Point(172, 335);
            btn_n5.Name = "btn_n5";
            btn_n5.Size = new Size(120, 68);
            btn_n5.TabIndex = 11;
            btn_n5.Text = "Visualizzare la media dei saldi";
            btn_n5.UseVisualStyleBackColor = true;
            btn_n5.Click += button5_Click;
            // 
            // btn_n6
            // 
            btn_n6.ForeColor = Color.Fuchsia;
            btn_n6.Location = new Point(321, 335);
            btn_n6.Name = "btn_n6";
            btn_n6.Size = new Size(120, 68);
            btn_n6.TabIndex = 12;
            btn_n6.Text = "Visualizzare l'elenco dei cognomi dei clienti ordinati in base al saldo";
            btn_n6.UseVisualStyleBackColor = true;
            // 
            // lst_risultato
            // 
            lst_risultato.FormattingEnabled = true;
            lst_risultato.Location = new Point(490, 95);
            lst_risultato.Name = "lst_risultato";
            lst_risultato.Size = new Size(282, 304);
            lst_risultato.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_risultato);
            Controls.Add(btn_n6);
            Controls.Add(btn_n5);
            Controls.Add(btn_n4);
            Controls.Add(btn_n3);
            Controls.Add(btn_n2);
            Controls.Add(btn_n1);
            Controls.Add(lbl_saldo);
            Controls.Add(lbl_cognome);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_titolo);
            Controls.Add(lst_saldo);
            Controls.Add(lst_numero);
            Controls.Add(lst_nomi);
            ForeColor = Color.Yellow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_nomi;
        private ListBox lst_numero;
        private ListBox lst_saldo;
        private Label lbl_titolo;
        private Label lbl_nome;
        private Label lbl_cognome;
        private Label lbl_saldo;
        private Button btn_n1;
        private Button btn_n2;
        private Button btn_n3;
        private Button btn_n4;
        private Button btn_n5;
        private Button btn_n6;
        private ListBox lst_risultato;
    }
}
