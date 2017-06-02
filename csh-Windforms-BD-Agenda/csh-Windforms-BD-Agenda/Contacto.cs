using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csh_Windforms_BD_Agenda
{
    class Contacto
    {
        private string nome;
        private int telef;
        private string email;

        public Contacto()
        {
            this.nome = ""; this.telef = 0; this.email = "";

        }

        public Contacto(string n, int t, string e)
        {
            this.nome = n ; this.telef = t; this.email = e;

        }

        public string getNome()
        {
            return this.nome;
        }

        public int getTelef()
        {
            return this.telef;
        }
        public string getEmail()
        {
            return this.email;
        }

        public string toString()
        {
            return nome + " " + telef + " " + email;
        }



    }


}
