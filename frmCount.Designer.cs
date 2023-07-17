
namespace TestProgram
{
    partial class frmCount
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
            this.txtletter = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Letter";
            // 
            // txtletter
            // 
            this.txtletter.Location = new System.Drawing.Point(148, 42);
            this.txtletter.Name = "txtletter";
            this.txtletter.Size = new System.Drawing.Size(350, 22);
            this.txtletter.TabIndex = 1;
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(30, 93);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(454, 91);
            this.lblresult.TabIndex = 2;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncount
            // 
            this.btncount.BackColor = System.Drawing.Color.Yellow;
            this.btncount.Location = new System.Drawing.Point(148, 203);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(213, 48);
            this.btncount.TabIndex = 3;
            this.btncount.Text = "Count";
            this.btncount.UseVisualStyleBackColor = false;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // frmCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 291);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtletter);
            this.Controls.Add(this.label1);
            this.Name = "frmCount";
            this.Text = "Space Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletter;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncount;
    }
}