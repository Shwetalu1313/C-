
namespace TestProgram
{
    partial class frmLargest
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
            this.lblresult = new System.Windows.Forms.Label();
            this.btnlargest = new System.Windows.Forms.Button();
            this.btnsmallest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(188, 25);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(243, 22);
            this.txtfirst.TabIndex = 2;
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(188, 76);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(243, 22);
            this.txtsecond.TabIndex = 3;
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(27, 125);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(403, 74);
            this.lblresult.TabIndex = 4;
            // 
            // btnlargest
            // 
            this.btnlargest.Location = new System.Drawing.Point(30, 220);
            this.btnlargest.Name = "btnlargest";
            this.btnlargest.Size = new System.Drawing.Size(101, 34);
            this.btnlargest.TabIndex = 5;
            this.btnlargest.Text = "&Largest";
            this.btnlargest.UseVisualStyleBackColor = true;
            this.btnlargest.Click += new System.EventHandler(this.btnlargest_Click);
            // 
            // btnsmallest
            // 
            this.btnsmallest.Location = new System.Drawing.Point(320, 220);
            this.btnsmallest.Name = "btnsmallest";
            this.btnsmallest.Size = new System.Drawing.Size(101, 34);
            this.btnsmallest.TabIndex = 6;
            this.btnsmallest.Text = "&Smallest";
            this.btnsmallest.UseVisualStyleBackColor = true;
            this.btnsmallest.Click += new System.EventHandler(this.btnsmallest_Click);
            // 
            // frmLargest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 278);
            this.Controls.Add(this.btnsmallest);
            this.Controls.Add(this.btnlargest);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLargest";
            this.Text = "Find Largest & Smallesst Number Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnlargest;
        private System.Windows.Forms.Button btnsmallest;
    }
}