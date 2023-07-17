
namespace TestProgram
{
    partial class frmoneway
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnwelcome = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(50, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(333, 154);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnwelcome
            // 
            this.btnwelcome.Location = new System.Drawing.Point(57, 338);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(85, 37);
            this.btnwelcome.TabIndex = 3;
            this.btnwelcome.Text = "&Welcome";
            this.btnwelcome.UseVisualStyleBackColor = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmoneway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 486);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmoneway";
            this.Text = "frmoneway";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnwelcome;
        private System.Windows.Forms.Button btnClose;
    }
}