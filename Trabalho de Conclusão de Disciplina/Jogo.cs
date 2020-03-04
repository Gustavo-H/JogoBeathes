using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Conclusão_de_Disciplina
{
    public partial class Jogo : Form
    {
        int tempoTotal;
        string idasEvoltas;

        public Jogo(int John, int Paul, int George, int Ringo, int Total, string frases)
        {
            InitializeComponent();

            lblTempo.Text = Total.ToString();

            tempoTotal = Total;
            idasEvoltas = frases;

            btnJohnAP.Text = btnJohnDP.Text = John.ToString();
            btnPaulAP.Text = btnPaulDP.Text = Paul.ToString();
            btnGeorgeAP.Text = btnGeorgeDP.Text = George.ToString();
            btnRingoAP.Text = btnRingoDP.Text = Ringo.ToString();

            gifIda2.Visible = false;
            gifIdaOne.Visible = false;
            gifVolta.Visible = false;
        }

        SoundPlayer somFim          = new SoundPlayer(Application.StartupPath + @"\sons\musicaFinal.wav");
        SoundPlayer somErro         = new SoundPlayer(Application.StartupPath + @"\sons\somErro.wav");
        SoundPlayer somPassos       = new SoundPlayer(Application.StartupPath + @"\sons\passos.wav");
        SoundPlayer somPassar       = new SoundPlayer(Application.StartupPath + @"\sons\somPassar.wav");        
        SoundPlayer somDerrota      = new SoundPlayer(Application.StartupPath + @"\sons\somFail.wav");
        SoundPlayer somCorrendo     = new SoundPlayer(Application.StartupPath + @"\sons\correndo.wav");
        SoundPlayer somSelecionar   = new SoundPlayer(Application.StartupPath + @"\sons\somSelecionar.wav");
        SoundPlayer cancelarSelecao = new SoundPlayer(Application.StartupPath + @"\sons\cancelarSelecao.wav");
        
        int selecionados = 0;

        bool lanternaDireito = false;
        bool lanternaEsquerdo = true;

        string[] nomes = new string[2];
        int[] tempos = new int[2];


        public async void atravessarPonteIda(string[] nome, int tempo)
        {
            alterar_Enabled_Buttons(0);

            for (int i = 0; i < 2; i++)
            {
                switch (nome[i])
                {
                    case "btnJohnAP":
                        btnJohnAP.Visible = false;
                        break;

                    case "btnPaulAP":
                        btnPaulAP.Visible = false;
                        break;

                    case "btnGeorgeAP":
                        btnGeorgeAP.Visible = false;
                        break;

                    case "btnRingoAP":
                        btnRingoAP.Visible = false;
                        break;
                }
            }

            if (selecionados == 1)
            {
                if (tempo != 1)
                {
                    gifIdaOne.Visible = true;


                    progresso.Value = 0;
                    progresso.Maximum = tempo;
                    progresso.Value = 1;

                    somPassos.Play();

                    await Task.Delay(500);                    

                    for (int i = 0; i < tempo; i++)
                    {
                        gifIdaOne.Left += 420 / tempo;
                        progresso.Value = i + 1;
                        lblTempo.Text = (int.Parse(lblTempo.Text) - 1).ToString();

                        if (int.Parse(lblTempo.Text) < 0)
                        {
                            fimDeJogo(1, nome);
                            break;
                        }

                        await Task.Delay(1000);
                    }

                    somPassos.Stop();

                    gifIdaOne.Visible = false;
                    gifIdaOne.Location = new Point(255, 198);
                    progresso.Value = 0;
                }
                else
                {                  

                    gifIdaOne.Visible = true;

                    somCorrendo.Play();

                    await Task.Delay(500);

                    progresso.Value = 0;
                    progresso.Maximum = 2;
                    
                    for (int i = 0; i < 2; i++)
                    {
                        progresso.Value += 1;
                        await Task.Delay(80);
                        gifIdaOne.Left += 210;
                        await Task.Delay(420);
                    }

                    somCorrendo.Stop();

                    lblTempo.Text = (int.Parse(lblTempo.Text) - 1).ToString();

                    if (int.Parse(lblTempo.Text) < 0)
                    {
                        fimDeJogo(1, nome);
                    }

                    gifIdaOne.Visible = false;
                    gifIdaOne.Location = new Point(255, 198);
                    progresso.Value = 0;
                }
            }
            else
            {
                gifIda2.Visible = true;                
                await Task.Delay(500);

                progresso.Value = 0;
                progresso.Maximum = tempo;
                progresso.Value = 1;
                somPassos.Play();
                await Task.Delay(500);

                for (int i = 0; i < tempo; i++)
                {
                    gifIda2.Left += 420 / tempo;
                    progresso.Value = i + 1;
                    lblTempo.Text = (int.Parse(lblTempo.Text) - 1).ToString();

                    if (int.Parse(lblTempo.Text) < 0)
                    {
                        fimDeJogo(2, nome);
                        break;
                    }

                    await Task.Delay(1000);
                }

                somPassos.Stop();

                gifIda2.Visible = false;
                gifIda2.Location = new Point(255, 175);
                progresso.Value = 0;
            }

            for (int i = 0; i < 2; i++)
            {
                switch (nome[i])
                {
                    case "btnJohnAP":
                        btnJohnDP.Visible = true;
                        break;

                    case "btnPaulAP":
                        btnPaulDP.Visible = true;
                        break;

                    case "btnGeorgeAP":
                        btnGeorgeDP.Visible = true;
                        break;

                    case "btnRingoAP":
                        btnRingoDP.Visible = true;
                        break;
                }
            }

            if (btnPaulAP.Visible == false && btnJohnAP.Visible == false && btnGeorgeAP.Visible == false && btnRingoAP.Visible == false)
            {
                somFim.Play();
                MessageBox.Show("VOCÊ CONSEGUIU", "PARABENS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                somFim.Stop();
                this.Close();
            }

            tempos[0] = 0;
            tempos[1] = 0;

            nomes[0] = string.Empty;
            nomes[1] = string.Empty;

            lanternaEsquerdo = false;
            lanternaDireito = true;

            alterar_Enabled_Buttons(1);
        }

        public async void atravessarPonteVolta(string nome, int tempo)
        {
            alterar_Enabled_Buttons(0);
            
            nomes[0] = nomes[1] = nome;
            somPassar.Play();


            switch (nome)
            {
                case "btnJohnDP":
                    btnJohnDP.Visible = false;
                    break;

                case "btnPaulDP":
                    btnPaulDP.Visible = false;
                    break;

                case "btnGeorgeDP":
                    btnGeorgeDP.Visible = false;
                    break;

                case "btnRingoDP":
                    btnRingoDP.Visible = false;
                    break;
            }

            if (tempo != 1)
            {
                gifVolta.Visible = true;
                await Task.Delay(500);

                progresso.Value = 0;
                progresso.Maximum = tempo;
                progresso.Value = 1;
                somPassos.Play();
                await Task.Delay(500);
                               
                for (int i = 0; i < tempo; i++)
                {
                    gifVolta.Left -= 420 / tempo;
                    progresso.Value = i + 1;
                    lblTempo.Text = (int.Parse(lblTempo.Text) - 1).ToString();

                    if (int.Parse(lblTempo.Text) < 0)
                    {
                        fimDeJogo(-1, nomes);
                        break;
                    }

                    await Task.Delay(1000);
                }

                somPassos.Stop();

                gifVolta.Visible = false;
                gifVolta.Location = new Point(645, 201);
                progresso.Value = 0;
            }
            else
            {
                gifVolta.Visible = true;
                
                somCorrendo.Play();
                
                await Task.Delay(500);

                progresso.Value = 0;
                progresso.Maximum = 2;               

                for (int i = 0; i < 2; i++)
                {
                    progresso.Value += 1;
                    await Task.Delay(80);
                    gifVolta.Left -= 210;
                    await Task.Delay(420);
                }

                somCorrendo.Stop();

                lblTempo.Text = (int.Parse(lblTempo.Text) - 1).ToString();

                if (int.Parse(lblTempo.Text) < 0)
                {
                    fimDeJogo(-1, nomes);
                }

                gifVolta.Visible = false;
                gifVolta.Location = new Point(645, 201);
                progresso.Value = 0;
            }


            switch (nome)
            {
                case "btnJohnDP":
                    btnJohnAP.Visible = true;
                    btnJohnAP.Left = 0;
                    break;

                case "btnPaulDP":
                    btnPaulAP.Visible = true;
                    btnPaulAP.Left = 0;
                    break;

                case "btnGeorgeDP":
                    btnGeorgeAP.Visible = true;
                    btnGeorgeAP.Left = 0;
                    break;

                case "btnRingoDP":
                    btnRingoAP.Visible = true;
                    btnRingoAP.Left = 0;
                    break;
            }
            selecionados = 0;

            nomes[0] = string.Empty;
            nomes[1] = string.Empty;

            alterar_Enabled_Buttons(1);

        }

        public void fimDeJogo(int qualGIF, string[] quaisButtons)
        {
            lblTempo.Text = "0";

            if (qualGIF == 1)
            {
                gifIdaOne.Enabled = false;
            }
            else if (qualGIF == 2)
            {
                gifIda2.Enabled = false;
            }
            else
            {
                gifVolta.Enabled = false;
            }


            for (int i = 0; i < 2; i++)
            {
                switch (quaisButtons[i])
                {
                    case "btnJohnAP":
                        btnJohnAP.Visible = true;
                        break;

                    case "btnPaulAP":
                        btnPaulAP.Visible = true;
                        break;

                    case "btnGeorgeAP":
                        btnGeorgeAP.Visible = true;
                        break;

                    case "btnRingoAP":
                        btnRingoAP.Visible = true;
                        break;

                    case "btnJohnDP":
                        btnJohnDP.Visible = true;
                        break;

                    case "btnPaulDP":
                        btnPaulDP.Visible = true;
                        break;

                    case "btnGeorgeDP":
                        btnGeorgeDP.Visible = true;
                        break;

                    case "btnRingoDP":
                        btnRingoDP.Visible = true;
                        break;
                }
            }

            somDerrota.Play();

            if (MessageBox.Show("Para Tentar Novamente Aperte Sim\nPara Ver Respostas e Sair Tecle Não", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation).ToString().ToUpper() == "YES")
            {
                btnJohnAP.Left   = 0;
                btnPaulAP.Left   = 0;
                btnGeorgeAP.Left = 0;
                btnRingoAP.Left  = 0;

                btnJohnAP.Visible   = true;
                btnPaulAP.Visible   = true;
                btnGeorgeAP.Visible = true;
                btnRingoAP.Visible  = true;

                btnJohnDP.Visible   = false;
                btnPaulDP.Visible   = false;
                btnGeorgeDP.Visible = false;
                btnRingoDP.Visible  = false;

                lblTempo.Text = tempoTotal.ToString();
                                
                nomes[0] = nomes[1] = string.Empty;
                tempos[0] = tempos[1] = selecionados = 0;

                lanternaDireito = false;
                lanternaEsquerdo = true;
            }
            else
            {
                MessageBox.Show(idasEvoltas);
                this.Close();
            }
        }

        public void alterar_Enabled_Buttons(int p)
        {
            if (p == 0)
            {
                btnPassar.Enabled = false;
                btnJohnAP.Enabled = false;
                btnJohnDP.Enabled = false;
                btnPaulAP.Enabled = false;
                btnPaulDP.Enabled = false;
                btnGeorgeAP.Enabled = false;
                btnGeorgeDP.Enabled = false;
                btnRingoAP.Enabled = false;
                btnRingoDP.Enabled = false;
            }
            else
            {
                btnPassar.Enabled = true;
                btnJohnAP.Enabled = true;
                btnJohnDP.Enabled = true;
                btnPaulAP.Enabled = true;
                btnPaulDP.Enabled = true;
                btnGeorgeAP.Enabled = true;
                btnGeorgeDP.Enabled = true;
                btnRingoAP.Enabled = true;
                btnRingoDP.Enabled = true;
            }
        }

        private void ida(object sender, EventArgs e)
        {
            if (lanternaEsquerdo == true)
            {
                if (selecionados == 0 || selecionados == 1)
                {
                    if ((sender as Button).Left == 0)
                    {
                        (sender as Button).Left = 80;

                        somSelecionar.Play();

                        nomes[selecionados] = (sender as Button).Name;
                        tempos[selecionados] = int.Parse((sender as Button).Text);

                        selecionados++;
                    }
                    else
                    {
                        (sender as Button).Left = 0;

                        int i = 0;

                        for (i = 0; i < selecionados; i++)
                        {
                            if (nomes[i] == (sender as Button).Name)
                            {
                                nomes[i] = string.Empty;
                                tempos[i] = 0;
                                break;
                            }
                        }

                        selecionados--;

                        cancelarSelecao.Play();

                        if (i == 0)
                        {
                            nomes[0] = nomes[1];
                            tempos[0] = tempos[1];
                        }
                    }
                }
                else
                {
                    if ((sender as Button).Left == 80)
                    {
                        (sender as Button).Left = 0;

                        int i = 0;

                        for (i = 0; i < selecionados; i++)
                        {
                            if (nomes[i] == (sender as Button).Name)
                            {
                                nomes[i] = string.Empty;
                                tempos[i] = 0;
                                break;
                            }
                        }

                        selecionados--;

                        cancelarSelecao.Play();

                        if (i == 0)
                        {
                            nomes[0] = nomes[1];
                            tempos[0] = tempos[1];
                        }
                    }
                    else
                    {
                        btnJohnAP.Left = 0;
                        btnPaulAP.Left = 0;
                        btnGeorgeAP.Left = 0;
                        btnRingoAP.Left = 0;

                        selecionados = 0;

                        nomes[0] = nomes[1] = string.Empty;
                        tempos[0] = tempos[1] = 0;

                        somSelecionar.Play();

                        (sender as Button).Left = 80;
                        nomes[selecionados] = (sender as Button).Name;
                        tempos[selecionados] = int.Parse((sender as Button).Text);

                        selecionados++;
                    }
                }
            }
        }

        private void volta(object sender, EventArgs e)
        {
            if (lanternaDireito == true)
            {
                atravessarPonteVolta((sender as Button).Name, int.Parse((sender as Button).Text));
                lanternaDireito = false;
                lanternaEsquerdo = true;
            }
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.btnPaulAP, "Paul\nTempo: " + btnPaulAP.Text + " Minutos");
            toolTip1.SetToolTip(this.btnJohnAP, "John\nTempo: " + btnJohnAP.Text + " Minutos");
            toolTip1.SetToolTip(this.btnGeorgeAP, "George\nTempo: " + btnGeorgeAP.Text + " Minutos");
            toolTip1.SetToolTip(this.btnRingoAP, "Ringo\nTempo: " + btnRingoAP.Text + " Minutos");

            toolTip1.SetToolTip(this.btnPaulDP, "Paul\nTempo: " + btnPaulDP.Text + " Minutos");
            toolTip1.SetToolTip(this.btnJohnDP, "John\nTempo: " + btnJohnDP.Text + " Minutos");
            toolTip1.SetToolTip(this.btnGeorgeDP, "George\nTempo: " + btnGeorgeDP.Text + " Minutos");
            toolTip1.SetToolTip(this.btnRingoDP, "Ringo\nTempo: " + btnRingoDP.Text + " Minutos");
            toolTip1.SetToolTip(this.progresso, "Progresso De Travessia\nDo Personagem Selecionado");
        }

        private void btnPassar_Click(object sender, EventArgs e)
        {
            if (selecionados > 0)
            {
                somPassar.Play();

                if (tempos[0] > tempos[1])
                {
                    atravessarPonteIda(nomes, tempos[0]);
                }
                else
                {
                    atravessarPonteIda(nomes, tempos[1]);
                }
            }
            else
            {
                somErro.Play();
                MessageBox.Show("Selecione Pelo Menos Um \nPersonagens Para Passa-lo", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Palmeiras Não Tem Mundial ! ! !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelarSelecao.Play();
        }                       
    }
}

