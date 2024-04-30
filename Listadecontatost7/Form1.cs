using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Listadecontatost7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // um vetor de contatos.
        private Contato[] contatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("Contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }

            escreverEmArquivo.Close();
        }

        private void Ler()
        {
            StreamReader lerArquivo = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(lerArquivo.ReadLine())];

            for (int i = 0; i < contatos.Length; i++)
            {
                contatos[i] = new Contato();
                contatos[i].Nome = lerArquivo.ReadLine();
                contatos[i].Sobrenome = lerArquivo.ReadLine();
                contatos[i].Telefone = lerArquivo.ReadLine();
            }

            lerArquivo.Close();
        }

        // Atualiza a tela do programa com os contatos.
        private void Exibir()
        {
            // Limpa a lista de contatos.
            listBoxcontato.Items.Clear();

            for (int i = 0; i < contatos.Length; i++)
            {
                listBoxcontato.Items.Add(contatos[i].ToString());
            }

        }

        private void LimparFormulario()
        {
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            textBoxTelefone.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }



        private void buttoncontato_Click(object sender, EventArgs e)
        {
            //criar um objeto de classe contato 
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            // listBoxcontato.Items.Add(contato);

            Escrever(contato);
            Organizar();
            Ler();
            Exibir();
            LimparFormulario();

            // Limpar as caixas de texto para criar um novo contato
            textBoxNome.Clear();
            textBoxSobrenome.Clear();
            textBoxTelefone.Clear();
         

        }

        private void listBoxcontato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }

        private void Organizar()
        {
            Contato temporario;
            bool troca = true;

            do
            {
                troca = false;

                for (int x = 0; x < contatos.Length - 1; x++)
                {
                    if (contatos[x].Nome.CompareTo(contatos[x +1].Nome) > 0)
                    {
                        temporario = contatos[x];
                        contatos[x] = contatos[x + 1];
                        contatos[x +1] = temporario;
                        troca = true;
                    }
                }
            } while (troca == true);
        }

        private void buttonOrganizar_Click(object sender, EventArgs e)
        {
            Organizar();
            Exibir();
        }
    }
}
