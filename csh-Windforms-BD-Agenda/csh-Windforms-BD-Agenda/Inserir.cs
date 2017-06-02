using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            string nome = txt_nome.Text;
            int telef = 0;
            int.TryParse(txt_telef.Text, out telef);
            string mail = txt_mail.Text;
            Contacto c = new Contacto(nome, telef, mail);
            MessageBox.Show(c.toString());

            try
            {
                string str = @"";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand();
                string sql = "insert into " + "Contacto (nome, telef, mail) values ('" 
                    +  c.getNome() + "','" + c.getTelef() + "','" + c.getEmail() + "')";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
    }
}
