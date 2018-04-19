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
    public partial class Perguntas : Form
    {
        public Perguntas()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Perguntas_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }
    }
}
