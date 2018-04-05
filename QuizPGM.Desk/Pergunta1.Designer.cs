namespace Questionario.Desk
{
    partial class pergunta1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.questão1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.RadioButton();
            this.d1 = new System.Windows.Forms.RadioButton();
            this.b1 = new System.Windows.Forms.RadioButton();
            this.c1 = new System.Windows.Forms.RadioButton();
            this.questão1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questão1
            // 
            this.questão1.BackColor = System.Drawing.Color.Gainsboro;
            this.questão1.Controls.Add(this.d1);
            this.questão1.Controls.Add(this.c1);
            this.questão1.Controls.Add(this.a1);
            this.questão1.Controls.Add(this.b1);
            this.questão1.Controls.Add(this.label1);
            this.questão1.ForeColor = System.Drawing.Color.Black;
            this.questão1.Location = new System.Drawing.Point(305, 173);
            this.questão1.Name = "questão1";
            this.questão1.Size = new System.Drawing.Size(311, 162);
            this.questão1.TabIndex = 0;
            this.questão1.TabStop = false;
            this.questão1.Text = " Questão 1 ";
            this.questão1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual dos gases abaixo não foi utilizado como arma de \r\ndestruição em massa durant" +
    "e a 1º Guerra:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(9, 67);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(82, 17);
            this.a1.TabIndex = 1;
            this.a1.TabStop = true;
            this.a1.Text = "a) Gás cloro\r\n";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Location = new System.Drawing.Point(9, 136);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(118, 17);
            this.d1.TabIndex = 1;
            this.d1.TabStop = true;
            this.d1.Text = "d) Gás lacrimogênio";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Location = new System.Drawing.Point(9, 90);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(102, 17);
            this.b1.TabIndex = 2;
            this.b1.TabStop = true;
            this.b1.Text = "b) Gás mostarda";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(9, 113);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(108, 17);
            this.c1.TabIndex = 3;
            this.c1.TabStop = true;
            this.c1.Text = "c) Gás fosfogênio";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(974, 652);
            this.Controls.Add(this.questão1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "pergunta1";
            this.Text = "Pergunta - 01";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Questão1_Load);
            this.questão1.ResumeLayout(false);
            this.questão1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questão1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton a1;
        private System.Windows.Forms.RadioButton b1;
        private System.Windows.Forms.RadioButton d1;
        private System.Windows.Forms.RadioButton c1;
    }
}

