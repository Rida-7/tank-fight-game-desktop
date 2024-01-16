
namespace gameProject
{
    partial class MainForm
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblVerHealth = new System.Windows.Forms.Label();
            this.lblHorHealth = new System.Windows.Forms.Label();
            this.lblRandHealth = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(16, 519);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 25);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score = ";
            // 
            // lblVerHealth
            // 
            this.lblVerHealth.AutoSize = true;
            this.lblVerHealth.BackColor = System.Drawing.Color.White;
            this.lblVerHealth.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerHealth.ForeColor = System.Drawing.Color.Black;
            this.lblVerHealth.Location = new System.Drawing.Point(16, 569);
            this.lblVerHealth.Name = "lblVerHealth";
            this.lblVerHealth.Size = new System.Drawing.Size(199, 25);
            this.lblVerHealth.TabIndex = 1;
            this.lblVerHealth.Text = "VerticalEnemyHealth = ";
            // 
            // lblHorHealth
            // 
            this.lblHorHealth.AutoSize = true;
            this.lblHorHealth.BackColor = System.Drawing.Color.White;
            this.lblHorHealth.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorHealth.ForeColor = System.Drawing.Color.Black;
            this.lblHorHealth.Location = new System.Drawing.Point(12, 611);
            this.lblHorHealth.Name = "lblHorHealth";
            this.lblHorHealth.Size = new System.Drawing.Size(224, 25);
            this.lblHorHealth.TabIndex = 2;
            this.lblHorHealth.Text = "HorizontalEnemyHealth = ";
            // 
            // lblRandHealth
            // 
            this.lblRandHealth.AutoSize = true;
            this.lblRandHealth.BackColor = System.Drawing.Color.White;
            this.lblRandHealth.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandHealth.ForeColor = System.Drawing.Color.Black;
            this.lblRandHealth.Location = new System.Drawing.Point(12, 653);
            this.lblRandHealth.Name = "lblRandHealth";
            this.lblRandHealth.Size = new System.Drawing.Size(203, 25);
            this.lblRandHealth.TabIndex = 3;
            this.lblRandHealth.Text = "RandomEnemyHealth = ";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.White;
            this.lblHealth.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.Black;
            this.lblHealth.Location = new System.Drawing.Point(419, 569);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(133, 25);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "PlayerHealth = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblRandHealth);
            this.Controls.Add(this.lblHorHealth);
            this.Controls.Add(this.lblVerHealth);
            this.Controls.Add(this.lblScore);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblVerHealth;
        private System.Windows.Forms.Label lblHorHealth;
        private System.Windows.Forms.Label lblRandHealth;
        private System.Windows.Forms.Label lblHealth;
    }
}

