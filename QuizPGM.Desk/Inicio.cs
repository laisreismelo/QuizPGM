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
    public partial class Inicio : Form
    {
        public string res; 

        public Inicio()
        {
            InitializeComponent();
            res = "n";
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void sim_Click(object sender, EventArgs e)
        {
            res = "s";
            this.Close();
        }

        private void nao_Click(object sender, EventArgs e)
        {
            res = "n";
            this.Close();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
