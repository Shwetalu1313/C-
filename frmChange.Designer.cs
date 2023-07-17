
namespace TestProgram
{
    partial class frmChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fist Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(46, 64);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(163, 22);
            this.txtfirst.TabIndex = 2;
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(348, 64);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(163, 22);
            this.txtsecond.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldisplay);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Location = new System.Drawing.Point(46, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Before Swap";
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisplay.Location = new System.Drawing.Point(31, 75);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(402, 53);
            this.lbldisplay.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(183, 30);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 38);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblresult);
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Location = new System.Drawing.Point(46, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After Swap";
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(31, 75);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(402, 53);
            this.lblresult.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(183, 30);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(116, 38);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChange";
            this.Text = "Change the number";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnChange;
    }
}