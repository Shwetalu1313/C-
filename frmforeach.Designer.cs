
namespace TestProgram
{
    partial class frmforeach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmforeach));
            this.label1 = new System.Windows.Forms.Label();
            this.txtvowel = new System.Windows.Forms.TextBox();
            this.lblString = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter String";
            // 
            // txtvowel
            // 
            this.txtvowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtvowel.Location = new System.Drawing.Point(138, 30);
            this.txtvowel.Name = "txtvowel";
            this.txtvowel.Size = new System.Drawing.Size(279, 22);
            this.txtvowel.TabIndex = 1;
            // 
            // lblString
            // 
            this.lblString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblString.Location = new System.Drawing.Point(22, 80);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(235, 81);
            this.lblString.TabIndex = 2;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncheck.Location = new System.Drawing.Point(287, 96);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(130, 40);
            this.btncheck.TabIndex = 3;
            this.btncheck.Text = "&Check";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // frmforeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(468, 210);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.txtvowel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmforeach";
            this.Text = "frmforeach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvowel;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Button btncheck;
    }
}