
namespace TestProgram
{
    partial class frmswich
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
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Letter aka chr";
            // 
            // txtletter
            // 
            this.txtletter.Location = new System.Drawing.Point(195, 39);
            this.txtletter.Name = "txtletter";
            this.txtletter.Size = new System.Drawing.Size(209, 22);
            this.txtletter.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(27, 95);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(376, 129);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(36, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmswich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtletter);
            this.Controls.Add(this.label1);
            this.Name = "frmswich";
            this.Text = "Letter Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletter;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}