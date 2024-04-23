using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Listadecontatost7
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        //propriedades (get e set)
        // é um controle de acesso Às varíaveis. */
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
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    //pais-cidade-telefone, ex: +55-11-97357-3786
                    telefone = "+00-00-00000-0000";
                }
            }
            
        }
        // o metodo que tem o mesmo nome da classe
        // e não retorna nada, é chamado CONSTRUTOR DA CLASSE
        public Contato()
        {
            Nome =  "Pietra";
            Sobrenome =  "Paiva";
            Telefone = "-11-99999-9999";
        }
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

            //sobreescreve o metodo tostring()
            //"polimorfismo"
            public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("{0}, {1}- {2}",
             Telefone.Substring(0, 2),
             Telefone.Substring(2, 5),
             Telefone.Substring(7, 4));

            return saida;
             
        }
    }
}