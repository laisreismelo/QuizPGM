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
        private int nota;
        public NovaPerguntas()
        {
            InitializeComponent();
            nota = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ques1name_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resp14.Checked == true)
            {
                nota += 1;
            }
            panel1.Visible = false;
            panel2.Visible = true;
            button3.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resp24.Checked == true)
            {
                nota += 1;
            }
            panel2.Visible = false;
            panel3.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resp33.Checked == true)
            {
                nota += 1;
            }
            panel3.Visible = false;
            panel4.Visible = true;
            button2.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resp42.Checked == true)
            {
                nota += 1;
            }
            panel4.Visible = false;
            panel5.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resp51.Checked == true)
            {
                nota += 1;
            }
            panel5.Visible = false;
            panel6.Visible = true;
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resp62.Checked == true)
            {
                nota += 1;
            }
            panel6.Visible = false;
            panel7.Visible = true;
            button6.Visible = false;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resp71.Checked == true)
            {
                nota += 1;
            }
            panel7.Visible = false;
            panel8.Visible = true;
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resp83.Checked == true)
            {
                nota += 1;
            }
            panel8.Visible = false;
            panel9.Visible = true;
            button8.Visible = false;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resp92.Checked == true)
            {
                nota += 1;
            }
            panel9.Visible = false;
            panel10.Visible = true;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (resp103.Checked == true)
            {
                nota += 1;
            }
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
