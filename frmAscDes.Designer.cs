
namespace TestProgram
{
    partial class frmAscDes
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnaes = new System.Windows.Forms.Button();
            this.btndes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(22, 26);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(344, 356);
            this.lstDisplay.TabIndex = 0;
            // 
            // btnaes
            // 
            this.btnaes.Location = new System.Drawing.Point(26, 399);
            this.btnaes.Name = "btnaes";
            this.btnaes.Size = new System.Drawing.Size(110, 45);
            this.btnaes.TabIndex = 1;
            this.btnaes.Text = "Ascending";
            this.btnaes.UseVisualStyleBackColor = true;
            this.btnaes.Click += new System.EventHandler(this.btnaes_Click);
            // 
            // btndes
            // 
            this.btndes.Location = new System.Drawing.Point(247, 399);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(110, 45);
            this.btndes.TabIndex = 2;
            this.btndes.Text = "Descending";
            this.btndes.UseVisualStyleBackColor = true;
            this.btndes.Click += new System.EventHandler(this.btndes_Click);
            // 
            // frmAscDes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btndes);
            this.Controls.Add(this.btnaes);
            this.Controls.Add(this.lstDisplay);
            this.Name = "frmAscDes";
            this.Text = "Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnaes;
        private System.Windows.Forms.Button btndes;
    }
}