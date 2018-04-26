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
        private int nota;
        public Perguntas()
        {
            InitializeComponent();
            nota = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void ques1name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radiores4ques1.Checked == true)
            {
                nota += 1;
            }
            panel1.Visible = false;
        }

        private void radiores4ques2_CheckedChanged(object sender, EventArgs e)
        {

=======
        private void Perguntas_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
>>>>>>> 13fee4f30fec3edd2d3e74bcce461a71121798ff
        }
    }
}
