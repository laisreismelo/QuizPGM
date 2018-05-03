using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPGM.Desk
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Splash tela = new Splash();
            Inicio inicio = new Inicio();
            tela.ShowDialog();
            inicio.ShowDialog();
            if (inicio.res== "s")
            {
                NovaPerguntas perguntas = new NovaPerguntas();
                perguntas.ShowDialog();
                
            }
            if (inicio.res == "n")
            {
                this.Close();
            }
            int nota = NovaPerguntas.nota;
            if (nota == 10)
            {
                textofim.Text = "Parabéns soldado, você ganhou a guerra!";
            } else if (nota <= 9 & nota >= 6)
            {
                textofim.Text = "Parabéns soldado, você foi muito bem!";
            } else if (nota <= 5 & nota >= 1)
            {
                textofim.Text = "Soldado, você morreu cara :/";
                this.BackgroundImage = Properties.Resources.perdeu;
            } else if (nota == 0)
            {
                textofim.Text = "Que horrível! Você não deu nem uma pimbada!";
                this.BackgroundImage = Properties.Resources.perdeu;
            }
            labelnota.Text = "Sua nota é: " + nota;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
            if (inicio.res == "s")
            {
                NovaPerguntas perguntas = new NovaPerguntas();
                perguntas.ShowDialog();

            }
            if (inicio.res == "n")
            {
                this.Close();
            }
            int nota = NovaPerguntas.nota;
            if (nota == 10)
            {
                textofim.Text = "Parabéns soldado, você ganhou a guerra!";
            }
            else if (nota <= 9 & nota >= 6)
            {
                textofim.Text = "Parabéns soldado, você foi muito bem!";
            }
            else if (nota <= 5 & nota >= 1)
            {
                textofim.Text = "Soldado, você morreu cara :/";
                this.BackgroundImage = Properties.Resources.perdeu;
            }
            else if (nota == 0)
            {
                textofim.Text = "Que horrível! Você não deu nem uma pimbada!";
                this.BackgroundImage = Properties.Resources.perdeu;
            }
            labelnota.Text = "Sua nota é: " + nota;
        }
    }
}
