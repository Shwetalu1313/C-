
namespace TestProgram
{
    partial class frmCircle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCircle));
            this.lblradius = new System.Windows.Forms.Label();
            this.lblpi = new System.Windows.Forms.Label();
            this.txtradius = new System.Windows.Forms.TextBox();
            this.txtpi = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblradius
            // 
            this.lblradius.AutoSize = true;
            this.lblradius.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblradius.Location = new System.Drawing.Point(35, 48);
            this.lblradius.Name = "lblradius";
            this.lblradius.Size = new System.Drawing.Size(205, 29);
            this.lblradius.TabIndex = 0;
            this.lblradius.Text = "Enter radius value";
            // 
            // lblpi
            // 
            this.lblpi.AutoSize = true;
            this.lblpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpi.Location = new System.Drawing.Point(35, 127);
            this.lblpi.Name = "lblpi";
            this.lblpi.Size = new System.Drawing.Size(161, 29);
            this.lblpi.TabIndex = 1;
            this.lblpi.Text = "Enter Pi value";
            // 
            // txtradius
            // 
            this.txtradius.Location = new System.Drawing.Point(305, 55);
            this.txtradius.Name = "txtradius";
            this.txtradius.Size = new System.Drawing.Size(287, 22);
            this.txtradius.TabIndex = 2;
            // 
            // txtpi
            // 
            this.txtpi.Location = new System.Drawing.Point(305, 134);
            this.txtpi.Name = "txtpi";
            this.txtpi.Size = new System.Drawing.Size(287, 22);
            this.txtpi.TabIndex = 3;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(72, 206);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(157, 49);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.LightCoral;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(353, 206);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(157, 49);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(53, 298);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(507, 56);
            this.lblresult.TabIndex = 6;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpi);
            this.Controls.Add(this.txtradius);
            this.Controls.Add(this.lblpi);
            this.Controls.Add(this.lblradius);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCircle";
            this.Text = "Circle Area Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblradius;
        private System.Windows.Forms.Label lblpi;
        private System.Windows.Forms.TextBox txtradius;
        private System.Windows.Forms.TextBox txtpi;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblresult;
    }
}