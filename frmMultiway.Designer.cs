
namespace TestProgram
{
    partial class frmMultiway
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMyanmar = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Myanmar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "math";
            // 
            // txtMyanmar
            // 
            this.txtMyanmar.Location = new System.Drawing.Point(142, 40);
            this.txtMyanmar.Name = "txtMyanmar";
            this.txtMyanmar.Size = new System.Drawing.Size(140, 22);
            this.txtMyanmar.TabIndex = 3;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(142, 97);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(140, 22);
            this.txtEnglish.TabIndex = 4;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(142, 157);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(140, 22);
            this.txtMath.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(39, 214);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(243, 101);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(39, 333);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(97, 38);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "&Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(185, 333);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(97, 38);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmMultiway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMyanmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMultiway";
            this.Text = "Exam Mark Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMyanmar;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnclose;
    }
}