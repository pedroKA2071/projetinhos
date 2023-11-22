using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string LerArquivo(string endereco) 
        { 
            string conteudo = "";

            if (File.Exists(endereco)) 
            { 
            
                using (StreamReader sr = new StreamReader(endereco)) 
                { 
                
                    conteudo = sr.ReadToEnd();
                
                }
                    
                 
            
            }
            return conteudo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string textonome = txb1.Text;
            string textotel = textBox2.Text;
            string textoemail = textBox1.Text;

            string caminho = "C:/Users/pedro.hgaspar2/source/Repos/projetinhos/projetinhos/textinho/seu arquivo.txt";

            string textoOld = LerArquivo(caminho);

            using (StreamWriter sw = new StreamWriter(caminho)) 
            { 
                sw.WriteLine(textoOld + textonome +" "+  textotel +" "+ textoemail);
            
            }

            if (rbemail.Checked) 
            
            {
                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine(textoOld + textonome + " " + "-" + " " + textoemail);

                }

            }
            else if (rbtel.Checked) 
            {

                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine(textoOld + textonome + " " + textotel + " " + "-");

                }

            }


            MessageBox.Show("Arquivo salvinho");



        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminho = "C:/Users/pedro.hgaspar2/source/Repos/projetinhos/projetinhos/textinho/seu arquivo.txt";


            string texto = LerArquivo(caminho);

            Array lista = texto.Split('\n');




            foreach (string pessoa in lista)
            {
                string[] dados = pessoa.Split(' ');




                comboBox1.Items.Add(dados[0]);


            }
        }
    }
}
