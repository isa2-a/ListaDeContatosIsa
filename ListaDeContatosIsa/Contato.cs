using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosIsa
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;

            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }

            }
        }
    }
}
