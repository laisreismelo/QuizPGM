namespace QuizPGM.Desk
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.sim = new System.Windows.Forms.Button();
            this.nao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sim
            // 
            this.sim.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sim.Location = new System.Drawing.Point(679, 305);
            this.sim.Margin = new System.Windows.Forms.Padding(4);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(134, 32);
            this.sim.TabIndex = 0;
            this.sim.Text = "Sim";
            this.sim.UseVisualStyleBackColor = false;
            this.sim.Click += new System.EventHandler(this.sim_Click);
            // 
            // nao
            // 
            this.nao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nao.Location = new System.Drawing.Point(821, 305);
            this.nao.Margin = new System.Windows.Forms.Padding(4);
            this.nao.Name = "nao";
            this.nao.Size = new System.Drawing.Size(134, 32);
            this.nao.TabIndex = 0;
            this.nao.Text = "Não";
            this.nao.UseVisualStyleBackColor = false;
            this.nao.Click += new System.EventHandler(this.nao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(672, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja iniciar o quiz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(106, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRIMEIRA GUERRA MUNDIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(214, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Criadores: Diogo Escobar, Eduardo Kendy, Evelyn Pedrosa, Felipe Teixeira e Lais R" +
    "eis ";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(974, 652);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nao);
            this.Controls.Add(this.sim);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Primeira Guerra Mundial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sim;
        private System.Windows.Forms.Button nao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

