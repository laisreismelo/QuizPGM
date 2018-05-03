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
    public partial class NovaPerguntas : Form
    {
        public static int nota;
        public NovaPerguntas()
        {
            InitializeComponent();
            nota = 0;
        }
        private void resp41_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void resp42_Click_1(object sender, EventArgs e)
        {
            nota += 1;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void resp43_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void resp44_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
    }
}
