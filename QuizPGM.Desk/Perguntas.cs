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
        ///pergunta 1
        private void btn1quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void btn2quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void btn3quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void btn4quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        ///pergunta 2
        private void btn1quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void btn2quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void btn3quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void btn4quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        ///pergunta 3
        private void btn1quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void btn2quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void btn3quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void btn4quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        ///pergunta 4
        private void btn1quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void btn2quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void btn3quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void btn4quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        ///pergunta 5
        private void btn1quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void btn2quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void btn3quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void btn4quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        ///pergunta 6
        private void btn1quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void btn2quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void btn3quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void btn4quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        ///pergunta 7
        private void btn1quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void btn2quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void btn3quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void btn4quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        ///pergunta 8
        private void btn1quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void btn2quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void btn3quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void btn4quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        ///pergunta 9
        private void btn1quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        private void btn2quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        private void btn3quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        private void btn4quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        ///pergunta 10
        private void btn1quest10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn2quest10_Click(object sender, EventArgs e)
        {
            nota += 1;
            this.Close();
        }
        private void btn3quest10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn4quest10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
