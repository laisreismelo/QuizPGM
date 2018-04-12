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
    public partial class Splash : Form
    {
        private int progress;
        public Splash()
        {
            InitializeComponent();
            progress = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress == 0)
            {
                bar.Value = 20;
                load.Text = "Carregando arquivos...";
                progress = 20;
            }
            else if (progress == 20)
            {
                bar.Value = 40;
                load.Text = "Carregando imagens...";
                progress = 40;
            }
            else if (progress == 40)
            {
                bar.Value = 60;
                load.Text = "Preparando artilharia...";
                progress = 60;
            }
            else if (progress == 60)
            {
                bar.Value = 80;
                load.Text = "Recarregando armas...";
                progress = 80;
            }
            else if (progress == 80)
            {
                bar.Value = 100;
                load.Text = "Preparando ataque...";
                progress = 100;
            }
            else if (progress == 100)
            {
                this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
