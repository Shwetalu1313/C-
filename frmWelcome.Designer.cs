
namespace TestProgram
{
    partial class frmWelcome
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
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btnwelcome = new System.Windows.Forms.Button();
            this.btngood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisplay.Location = new System.Drawing.Point(49, 106);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(443, 101);
            this.lbldisplay.TabIndex = 0;
            // 
            // btnwelcome
            // 
            this.btnwelcome.Location = new System.Drawing.Point(49, 31);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(141, 45);
            this.btnwelcome.TabIndex = 1;
            this.btnwelcome.Text = "Welcome";
            this.btnwelcome.UseVisualStyleBackColor = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            // 
            // btngood
            // 
            this.btngood.Location = new System.Drawing.Point(351, 31);
            this.btngood.Name = "btngood";
            this.btngood.Size = new System.Drawing.Size(141, 45);
            this.btngood.TabIndex = 2;
            this.btngood.Text = "Good Day";
            this.btngood.UseVisualStyleBackColor = true;
            this.btngood.Click += new System.EventHandler(this.btngood_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 272);
            this.Controls.Add(this.btngood);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.lbldisplay);
            this.Name = "frmWelcome";
            this.Text = "frmWelcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btnwelcome;
        private System.Windows.Forms.Button btngood;
    }
}