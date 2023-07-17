
namespace TestProgram
{
    partial class frmtrycatch
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
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(33, 247);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(398, 134);
            this.lblresult.TabIndex = 2;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(223, 42);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(208, 22);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(223, 101);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(208, 22);
            this.txtnum2.TabIndex = 4;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncalculate.Location = new System.Drawing.Point(153, 165);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(139, 42);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // frmtrycatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 427);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmtrycatch";
            this.Text = "frmtrycatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btncalculate;
    }
}