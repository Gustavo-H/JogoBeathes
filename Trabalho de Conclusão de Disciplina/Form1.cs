using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Conclusão_de_Disciplina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTotal.MaxLength = 2;
            txtJohn.MaxLength = 2;
            txtPaul.MaxLength = 2;
            txtGeorge.MaxLength = 2;
            txtRingo.MaxLength = 2;
            txtTotal.Focus();

            enredo(1);
        }

        string[] nomes = new string[4];
        string[] idasVoltas = new string[5];
        string frases;
        
        public async void enredo(int p)
        {
            if (p == 1)
            {
                await Task.Delay(100);
            }            
            
            Enredo_Jogo enredo = new Enredo_Jogo();
            enredo.ShowDialog();          
            
        }

        public int verificar()
        {
            if (txtTotal.Text == String.Empty ||
                txtPaul.Text == String.Empty ||
                txtJohn.Text == String.Empty ||
                txtGeorge.Text == String.Empty ||
                txtRingo.Text == String.Empty) return 0;

            else if (txtTotal.Text == txtGeorge.Text
               || txtTotal.Text == txtJohn.Text
               || txtTotal.Text == txtPaul.Text
               || txtTotal.Text == txtRingo.Text
               || txtJohn.Text == txtPaul.Text
               || txtJohn.Text == txtGeorge.Text
               || txtJohn.Text == txtRingo.Text
               || txtPaul.Text == txtGeorge.Text
               || txtPaul.Text == txtRingo.Text
               || txtGeorge.Text == txtRingo.Text) return 0;

            else if (int.Parse(txtJohn.Text)  == 0 ||
                     int.Parse(txtPaul.Text)  == 0 ||
                     int.Parse(txtRingo.Text) == 0 ||
                     int.Parse(txtGeorge.Text) == 0) return 0;

            else return 1;
        }

        public bool verificarTempo(int john, int paul, int george, int ringo, int tempoTotal)
        {
            int[] tempos = new int[4];
            int soma = 0;

            tempos[0] = john;
            tempos[1] = paul;
            tempos[2] = george;
            tempos[3] = ringo;

            Array.Sort(tempos);

            for (int i = 0; i < 4; i++)
            {
                if (tempos[i] == john)
                {
                    nomes[i] = "John";
                }
                else if ((tempos[i] == paul))
                {
                    nomes[i] = "Paul";
                }
                else if ((tempos[i] == george))
                {
                    nomes[i] = "George";
                }
                else
                {
                    nomes[i] = "Ringo";
                }
            }

            ///ida de 0 e 1
            soma += tempos[1];
            idasVoltas[0] = "Passos:\n\n 1º Passo: Passar o " + nomes[0] + " e o " + nomes[1] + "\n\n";

            ///volta de 0
            soma += tempos[0];
            idasVoltas[1] = "2º Passo: Voltar o " + nomes[0] + "\n\n";

            ///ida de 2 e 3
            soma += tempos[3];
            idasVoltas[2] = "3º Passo: Passar o " + nomes[2] + " e o " + nomes[3] + "\n\n";

            ///volta de 1
            soma += tempos[1];
            idasVoltas[3] = "4º Passo: Voltar o " + nomes[1] + "\n\n";

            /// ida de 0 e 1 
            soma += tempos[1];
            idasVoltas[4] = "5º Passo: Passar o " + nomes[0] + " e o " + nomes[1];

            frases = idasVoltas[0] + idasVoltas[1] + idasVoltas[2] + idasVoltas[3] + idasVoltas[4];


            if (soma <= tempoTotal)
                return true;
            else
            {
                soma = 0;
                ///ida de 0 e 1
                soma += tempos[1];
                idasVoltas[0] = "Passos:\n\n 1º Passo: Passar o " + nomes[0] + " e o " + nomes[1] + "\n\n";

                ///volta de 0
                soma += tempos[0];
                idasVoltas[1] = "2º Passo: Voltar o " + nomes[0] + "\n\n";

                ///ida de 0 e 2
                soma += tempos[2];
                idasVoltas[2] = "3º Passo: Passar o " + nomes[0] + " e o " + nomes[2] + "\n\n";

                ///volta de 0
                soma += tempos[0];
                idasVoltas[3] = "4º Passo: Voltar o " + nomes[0] + "\n\n";

                /// ida de 0 e 3 
                soma += tempos[3];
                idasVoltas[4] = "5º Passo: Passar o " + nomes[0] + " e o " + nomes[3];

                frases = idasVoltas[0] + idasVoltas[1] + idasVoltas[2] + idasVoltas[3] + idasVoltas[4];


                if (soma <= tempoTotal)
                    return true;
                else
                    return false;
            }
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Text  = String.Empty;
            txtJohn.Text   = String.Empty;
            txtPaul.Text   = String.Empty;
            txtGeorge.Text = String.Empty;
            txtRingo.Text  = String.Empty;
            txtTotal.Focus();
        }

        private void validar(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back)) e.Handled = false;
            
            else e.Handled = true;                             
        }

        private void btnJogar_Click_1(object sender, EventArgs e)
        {
            if (verificar() == 0)
            {
                MessageBox.Show("VALORES INCORRETOS !\n\n1) Restrições:\n2) Tempos iguais para os integrantes\n3) Tempos com valor 0\n4) Tempos sem preenchimento", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int john = int.Parse(txtJohn.Text);
                int paul = int.Parse(txtPaul.Text);
                int george = int.Parse(txtGeorge.Text);
                int ringo = int.Parse(txtRingo.Text);
                int total = int.Parse(txtTotal.Text);
                if (verificarTempo(john, paul, george, ringo, total))
                {
                    Jogo game = new Jogo(john, paul, george, ringo, total, frases);
                    game.ShowDialog();
                    //this.Hide();
                }
                else
                    MessageBox.Show("TEMPO MÁXIMO EXCEDIDO !\n\nNão é possivel jogar com os tempos inseridos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnEnredo_Click(object sender, EventArgs e)
        {
            enredo(0);
        }              
    }
}
