
namespace TestProgram
{
    partial class frmdowhile
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
            this.txtstart = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.btngo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(92, 25);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(204, 22);
            this.txtstart.TabIndex = 2;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(92, 76);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(204, 22);
            this.txtend.TabIndex = 3;
            // 
            // lstNumber
            // 
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.ItemHeight = 16;
            this.lstNumber.Location = new System.Drawing.Point(31, 115);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.Size = new System.Drawing.Size(124, 228);
            this.lstNumber.TabIndex = 4;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(201, 127);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(95, 47);
            this.btngo.TabIndex = 5;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // frmdowhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 395);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.lstNumber);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtstart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdowhile";
            this.Text = "Numbering Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.ListBox lstNumber;
        private System.Windows.Forms.Button btngo;
    }
}