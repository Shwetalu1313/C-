
namespace TestProgram
{
    partial class frmCh1ass1
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblclick = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.Control;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(68, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(398, 43);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblclick
            // 
            this.lblclick.BackColor = System.Drawing.SystemColors.Control;
            this.lblclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclick.ForeColor = System.Drawing.Color.Black;
            this.lblclick.Location = new System.Drawing.Point(31, 224);
            this.lblclick.Name = "lblclick";
            this.lblclick.Size = new System.Drawing.Size(460, 43);
            this.lblclick.TabIndex = 1;
            this.lblclick.Text = "Do you want to see Message box. Please Click on Show Button";
            this.lblclick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClick.Location = new System.Drawing.Point(206, 113);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(127, 37);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Info;
            this.btnShow.Location = new System.Drawing.Point(206, 289);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(127, 37);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Me";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmCh1ass1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 491);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblclick);
            this.Controls.Add(this.lblResult);
            this.Name = "frmCh1ass1";
            this.Text = "Testing Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblclick;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnShow;
    }
}