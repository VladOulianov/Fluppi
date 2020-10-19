namespace Fluppi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flore = new System.Windows.Forms.PictureBox();
            this.fluppy = new System.Windows.Forms.PictureBox();
            this.piloneTop = new System.Windows.Forms.PictureBox();
            this.piloneBot = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluppy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piloneTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piloneBot)).BeginInit();
            this.SuspendLayout();
            // 
            // flore
            // 
            this.flore.BackColor = System.Drawing.Color.Transparent;
            this.flore.Image = ((System.Drawing.Image)(resources.GetObject("flore.Image")));
            this.flore.Location = new System.Drawing.Point(-9, 711);
            this.flore.Name = "flore";
            this.flore.Size = new System.Drawing.Size(842, 111);
            this.flore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flore.TabIndex = 0;
            this.flore.TabStop = false;
            this.flore.Click += new System.EventHandler(this.label1_Click);
            // 
            // fluppy
            // 
            this.fluppy.Image = ((System.Drawing.Image)(resources.GetObject("fluppy.Image")));
            this.fluppy.Location = new System.Drawing.Point(49, 257);
            this.fluppy.Name = "fluppy";
            this.fluppy.Size = new System.Drawing.Size(80, 62);
            this.fluppy.TabIndex = 1;
            this.fluppy.TabStop = false;
            // 
            // piloneTop
            // 
            this.piloneTop.Image = ((System.Drawing.Image)(resources.GetObject("piloneTop.Image")));
            this.piloneTop.Location = new System.Drawing.Point(372, 438);
            this.piloneTop.Name = "piloneTop";
            this.piloneTop.Size = new System.Drawing.Size(104, 384);
            this.piloneTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piloneTop.TabIndex = 2;
            this.piloneTop.TabStop = false;
            // 
            // piloneBot
            // 
            this.piloneBot.Image = ((System.Drawing.Image)(resources.GetObject("piloneBot.Image")));
            this.piloneBot.Location = new System.Drawing.Point(488, -2);
            this.piloneBot.Name = "piloneBot";
            this.piloneBot.Size = new System.Drawing.Size(94, 250);
            this.piloneBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piloneBot.TabIndex = 3;
            this.piloneBot.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ScoreText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreText.Location = new System.Drawing.Point(191, 743);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(93, 22);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score : 0";
            this.ScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(733, 819);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.flore);
            this.Controls.Add(this.piloneBot);
            this.Controls.Add(this.piloneTop);
            this.Controls.Add(this.fluppy);
            this.Name = "Form1";
            this.Text = "Fluppi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluppy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piloneTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piloneBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flore;
        private System.Windows.Forms.PictureBox fluppy;
        private System.Windows.Forms.PictureBox piloneTop;
        private System.Windows.Forms.PictureBox piloneBot;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

