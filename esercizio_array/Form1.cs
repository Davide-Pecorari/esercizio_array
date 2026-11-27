using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace esercizio_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] saldo = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
        string[] nomi = { "Rossi Mario", "Bianchi Luigi ", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
        int[] numero = { 11264, 99780, 00342, 03419, 34562, 09887, 02341 };

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_nomi_Click(object sender, EventArgs e)
        {

        }

        private void btn_numeri_Click(object sender, EventArgs e)
        {

        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            lst_nomi.Items.Clear();
            lst_numero.Items.Clear();
            lst_saldo.Items.Clear();
            for (int i = 0; i < nome.Length; i++)
            {
                lst_nomi.Items.Add(nome[i]);
                lst_numero.Items.Add(numero[i].ToString("D5"));
                lst_saldo.Items.Add(saldo[i]);
            }
    }
}
