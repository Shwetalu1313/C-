
namespace TestProgram
{
    partial class frmsumass
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
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(241, 37);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(207, 22);
            this.txtfirst.TabIndex = 2;
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(241, 98);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(207, 22);
            this.txtsecond.TabIndex = 3;
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisplay.Location = new System.Drawing.Point(47, 158);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(400, 112);
            this.lbldisplay.TabIndex = 4;
            this.lbldisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSum.Location = new System.Drawing.Point(54, 293);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(133, 40);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "&Sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(314, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmsumass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmsumass";
            this.Text = "Sum Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnClear;
    }
}