namespace uas
{
    partial class Contrast
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
            this.tbOK = new System.Windows.Forms.Button();
            this.tbContrast = new System.Windows.Forms.TextBox();
            this.hscContrast = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbOK
            // 
            this.tbOK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbOK.Location = new System.Drawing.Point(285, 63);
            this.tbOK.Name = "tbOK";
            this.tbOK.Size = new System.Drawing.Size(62, 28);
            this.tbOK.TabIndex = 32;
            this.tbOK.Text = "OK";
            this.tbOK.UseVisualStyleBackColor = false;
            this.tbOK.Click += new System.EventHandler(this.tbOK_Click);
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(521, 28);
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(54, 20);
            this.tbContrast.TabIndex = 31;
            this.tbContrast.Text = "0";
            // 
            // hscContrast
            // 
            this.hscContrast.Location = new System.Drawing.Point(113, 28);
            this.hscContrast.Maximum = 136;
            this.hscContrast.Minimum = -127;
            this.hscContrast.Name = "hscContrast";
            this.hscContrast.Size = new System.Drawing.Size(382, 17);
            this.hscContrast.TabIndex = 30;
            this.hscContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscContrast_Scroll);
            this.hscContrast.ValueChanged += new System.EventHandler(this.hscContrast_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Contrast";
            // 
            // Contrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 132);
            this.Controls.Add(this.tbOK);
            this.Controls.Add(this.tbContrast);
            this.Controls.Add(this.hscContrast);
            this.Controls.Add(this.label2);
            this.Name = "Contrast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrast";
            this.Load += new System.EventHandler(this.Contrast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbOK;
        public System.Windows.Forms.TextBox tbContrast;
        public System.Windows.Forms.HScrollBar hscContrast;
        private System.Windows.Forms.Label label2;
    }
}