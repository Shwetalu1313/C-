
namespace TestProgram
{
    partial class frmWhileLoop
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
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 16;
            this.lstData.Location = new System.Drawing.Point(17, 18);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(244, 404);
            this.lstData.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(276, 24);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(86, 47);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // frmWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lstData);
            this.Name = "frmWhileLoop";
            this.Text = "Random Number Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnRandom;
    }
}