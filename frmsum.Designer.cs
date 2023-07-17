
namespace TestProgram
{
    partial class frmsum
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnsum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(153, 24);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(167, 22);
            this.txtnum.TabIndex = 1;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(26, 66);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(294, 196);
            this.lstResult.TabIndex = 2;
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(342, 66);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(85, 37);
            this.btnsum.TabIndex = 3;
            this.btnsum.Text = "Sum";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // frmsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 352);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Name = "frmsum";
            this.Text = "Sum Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnsum;
    }
}