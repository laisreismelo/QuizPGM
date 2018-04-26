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
        }
    }
}
