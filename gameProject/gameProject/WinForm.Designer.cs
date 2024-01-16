
namespace gameProject
{
    partial class WinForm
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
            this.btnnBackk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOU WON :)";
            // 
            // btnnBackk
            // 
            this.btnnBackk.AutoSize = true;
            this.btnnBackk.BackColor = System.Drawing.Color.Black;
            this.btnnBackk.Font = new System.Drawing.Font("Blackadder ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnBackk.ForeColor = System.Drawing.Color.White;
            this.btnnBackk.Location = new System.Drawing.Point(362, 251);
            this.btnnBackk.Name = "btnnBackk";
            this.btnnBackk.Size = new System.Drawing.Size(75, 41);
            this.btnnBackk.TabIndex = 3;
            this.btnnBackk.Text = "Exit";
            this.btnnBackk.UseVisualStyleBackColor = false;
            this.btnnBackk.Click += new System.EventHandler(this.btnnBackk_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnBackk);
            this.Controls.Add(this.label1);
            this.Name = "WinForm";
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnBackk;
    }
}