
namespace TestProgram
{
    partial class frmlargestnum
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnlargest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtfirst
            // 
            this.txtfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtfirst.Location = new System.Drawing.Point(169, 39);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 22);
            this.txtfirst.TabIndex = 2;
            // 
            // txtsecond
            // 
            this.txtsecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtsecond.Location = new System.Drawing.Point(169, 84);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(100, 22);
            this.txtsecond.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(31, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(237, 87);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnlargest
            // 
            this.btnlargest.Location = new System.Drawing.Point(35, 243);
            this.btnlargest.Name = "btnlargest";
            this.btnlargest.Size = new System.Drawing.Size(78, 34);
            this.btnlargest.TabIndex = 5;
            this.btnlargest.Text = "&Largest";
            this.btnlargest.UseVisualStyleBackColor = true;
            this.btnlargest.Click += new System.EventHandler(this.btnlargest_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Location = new System.Drawing.Point(191, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmlargestnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnlargest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmlargestnum";
            this.Text = "frmlargestnum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnlargest;
        private System.Windows.Forms.Button btnClose;
    }
}