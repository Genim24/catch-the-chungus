namespace catch_the_chungus
{
    partial class FrmAlien
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrAlien = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PnlGame.Location = new System.Drawing.Point(10, 160);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(300, 300);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseDown);
            // 
            // TmrAlien
            // 
            this.TmrAlien.Enabled = true;
            this.TmrAlien.Interval = 600;
            this.TmrAlien.Tick += new System.EventHandler(this.TmrAlien_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catch The Chungus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.Color.White;
            this.LblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblScore.Location = new System.Drawing.Point(377, 218);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(60, 30);
            this.LblScore.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TmrCountdown
            // 
            this.TmrCountdown.Interval = 1000;
            this.TmrCountdown.Tick += new System.EventHandler(this.TmrCountdown_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Left";
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.White;
            this.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTime.Location = new System.Drawing.Point(373, 125);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(60, 30);
            this.LblTime.TabIndex = 7;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuQuit});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(484, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(52, 20);
            this.MnuStart.Text = "START";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(46, 20);
            this.MnuQuit.Text = "QUIT";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // FrmAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlien";
            this.Text = "Catch The Chungus";
            this.Load += new System.EventHandler(this.FrmAlien_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAlien_MouseDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrAlien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer TmrCountdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
    }
}

