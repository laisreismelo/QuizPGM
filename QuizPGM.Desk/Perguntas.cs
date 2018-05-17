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
        private void Btn1quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void Btn2quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void Btn3quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void Btn4quest1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        ///pergunta 2
        private void Btn1quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void Btn2quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void Btn3quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void Btn4quest2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }
        ///pergunta 3
        private void Btn1quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void Btn2quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void Btn3quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void Btn4quest3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }
        ///pergunta 4
        private void Btn1quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void Btn2quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void Btn3quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void Btn4quest4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }
        ///pergunta 5
        private void Btn1quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void Btn2quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void Btn3quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void Btn4quest5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
        }
        ///pergunta 6
        private void Btn1quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void Btn2quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void Btn3quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void Btn4quest6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }
        ///pergunta 7
        private void Btn1quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void Btn2quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void Btn3quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void Btn4quest7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }
        ///pergunta 8
        private void Btn1quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void Btn2quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void Btn3quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void Btn4quest8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }
        ///pergunta 9
        private void Btn1quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        private void Btn2quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        private void Btn3quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        private void Btn4quest9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
        }
        ///pergunta 10
        private void Btn1quest10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn2quest10_Click(object sender, EventArgs e)
        {
            nota += 1;
            this.Close();
        }
        private void Btn3quest10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn4quest10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
