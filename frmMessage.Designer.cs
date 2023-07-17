
namespace TestProgram
{
    partial class frmMessage
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
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimple
            // 
            this.btnSimple.Location = new System.Drawing.Point(83, 63);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(374, 45);
            this.btnSimple.TabIndex = 0;
            this.btnSimple.Text = "Simple Message Box";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(83, 164);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(374, 45);
            this.btnTitle.TabIndex = 1;
            this.btnTitle.Text = "Message Box with Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(83, 261);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(374, 45);
            this.btnButton.TabIndex = 2;
            this.btnButton.Text = "Message Box with Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnSimple);
            this.Name = "frmMessage";
            this.Text = "Message Box Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnButton;
    }
}