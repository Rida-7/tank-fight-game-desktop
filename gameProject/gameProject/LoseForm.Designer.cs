
namespace gameProject
{
    partial class LoseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnBackk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Blackadder ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "You Lose :\\ ";
            // 
            // btnnBackk
            // 
            this.btnnBackk.AutoSize = true;
            this.btnnBackk.BackColor = System.Drawing.Color.Black;
            this.btnnBackk.Font = new System.Drawing.Font("Blackadder ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnBackk.ForeColor = System.Drawing.Color.White;
            this.btnnBackk.Location = new System.Drawing.Point(39, 282);
            this.btnnBackk.Name = "btnnBackk";
            this.btnnBackk.Size = new System.Drawing.Size(75, 41);
            this.btnnBackk.TabIndex = 2;
            this.btnnBackk.Text = "Exit";
            this.btnnBackk.UseVisualStyleBackColor = false;
            this.btnnBackk.Click += new System.EventHandler(this.btnnBackk_Click);
            // 
            // LoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnBackk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoseForm";
            this.Text = "LoseForm";
            this.Load += new System.EventHandler(this.LoseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnBackk;
    }
}