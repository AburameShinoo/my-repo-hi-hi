namespace PictureGUI
{
    partial class Form1
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
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(43, 158);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(182, 21);
            this.cbb1.TabIndex = 0;
            this.cbb1.SelectedValueChanged += new System.EventHandler(this.cbb1_SelectedValueChanged);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(276, 47);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(292, 282);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 391);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.cbb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.PictureBox pb1;
    }
}

