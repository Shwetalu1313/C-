
namespace TestProgram
{
    partial class frmgrade
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
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.lblReslt = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtgrade
            // 
            this.txtgrade.BackColor = System.Drawing.Color.Lime;
            this.txtgrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgrade.Location = new System.Drawing.Point(139, 49);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(200, 22);
            this.txtgrade.TabIndex = 1;
            this.txtgrade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblReslt
            // 
            this.lblReslt.BackColor = System.Drawing.SystemColors.Window;
            this.lblReslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReslt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblReslt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReslt.Location = new System.Drawing.Point(17, 100);
            this.lblReslt.Name = "lblReslt";
            this.lblReslt.Size = new System.Drawing.Size(321, 114);
            this.lblReslt.TabIndex = 2;
            this.lblReslt.Text = "The reslt is";
            this.lblReslt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnshow.Location = new System.Drawing.Point(21, 234);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(118, 40);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "&Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(210, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(356, 325);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lblReslt);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.label1);
            this.Name = "frmgrade";
            this.Text = "Grade Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Label lblReslt;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnExit;
    }
}