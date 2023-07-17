
namespace TestProgram
{
    partial class frmForLoop2
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.lstDispaly = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(160, 33);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(181, 22);
            this.txtFirst.TabIndex = 1;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(368, 31);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(114, 32);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "&Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // lstDispaly
            // 
            this.lstDispaly.FormattingEnabled = true;
            this.lstDispaly.ItemHeight = 16;
            this.lstDispaly.Location = new System.Drawing.Point(32, 76);
            this.lstDispaly.Name = "lstDispaly";
            this.lstDispaly.Size = new System.Drawing.Size(449, 180);
            this.lstDispaly.TabIndex = 3;
            // 
            // frmForLoop2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDispaly);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Name = "frmForLoop2";
            this.Text = "Multiplication Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ListBox lstDispaly;
    }
}