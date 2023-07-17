
namespace TestProgram
{
    partial class frmDispaly
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDispaly = new System.Windows.Forms.Button();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(285, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 45);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDispaly
            // 
            this.btnDispaly.BackColor = System.Drawing.Color.Lime;
            this.btnDispaly.Location = new System.Drawing.Point(35, 198);
            this.btnDispaly.Name = "btnDispaly";
            this.btnDispaly.Size = new System.Drawing.Size(124, 45);
            this.btnDispaly.TabIndex = 4;
            this.btnDispaly.Text = "&Display";
            this.btnDispaly.UseVisualStyleBackColor = false;
            this.btnDispaly.Click += new System.EventHandler(this.btnDispaly_Click);
            // 
            // lbldisplay
            // 
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisplay.Location = new System.Drawing.Point(12, 9);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(429, 161);
            this.lbldisplay.TabIndex = 3;
            // 
            // frmDispaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 270);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDispaly);
            this.Controls.Add(this.lbldisplay);
            this.Name = "frmDispaly";
            this.Text = "frmDispaly";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDispaly;
        private System.Windows.Forms.Label lbldisplay;
    }
}