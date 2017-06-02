using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh_Windforms_BD_Agenda
{
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_telef.Text = "";
            txt_mail.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nome = lbl_Nome.Text;
            int telef = 0;
            int.TryParse(txt_telef.Text, out telef);
            string mail = lbl_Mail.Text;
        }
    }
}
