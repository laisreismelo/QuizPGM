namespace QuizPGM.Desk
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.load = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(323, 310);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(165, 23);
            this.bar.TabIndex = 0;
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.BackColor = System.Drawing.Color.Transparent;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.Location = new System.Drawing.Point(119, 310);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(125, 24);
            this.load.TabIndex = 1;
            this.load.Text = "Carregando...";
            this.load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(183, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(133, 57);
            this.title.TabIndex = 2;
            this.title.Text = "Quiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primeira Guerra Mundial";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizPGM.Desk.Properties.Resources.gbsplash;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.load);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 345);
            this.MinimumSize = new System.Drawing.Size(500, 345);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}