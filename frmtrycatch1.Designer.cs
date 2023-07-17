
namespace TestProgram
{
    partial class frmtrycatch1
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
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btngo = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // lbldisplay
            // 
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisplay.Location = new System.Drawing.Point(35, 123);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(454, 92);
            this.lbldisplay.TabIndex = 1;
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btngo.Location = new System.Drawing.Point(384, 53);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(105, 39);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "&Go";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtnum.Location = new System.Drawing.Point(151, 64);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(208, 22);
            this.txtnum.TabIndex = 3;
            // 
            // frmtrycatch1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 292);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.label1);
            this.Name = "frmtrycatch1";
            this.Text = "frmtrycatch1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox txtnum;
    }
}