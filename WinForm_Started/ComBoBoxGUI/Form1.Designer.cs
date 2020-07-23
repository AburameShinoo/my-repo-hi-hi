namespace ComBoBoxGUI
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
            this.bt1 = new System.Windows.Forms.Button();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.cbb3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(40, 43);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(89, 48);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(40, 115);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(185, 21);
            this.cbb1.TabIndex = 1;
            this.cbb1.SelectedValueChanged += new System.EventHandler(this.cbb1_SelectedValueChanged);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(266, 116);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(185, 20);
            this.tb1.TabIndex = 2;
            // 
            // cbb2
            // 
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Location = new System.Drawing.Point(40, 164);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(185, 21);
            this.cbb2.TabIndex = 3;
            this.cbb2.SelectedValueChanged += new System.EventHandler(this.cbb2_SelectedValueChanged);
            // 
            // cbb3
            // 
            this.cbb3.FormattingEnabled = true;
            this.cbb3.Location = new System.Drawing.Point(266, 164);
            this.cbb3.Name = "cbb3";
            this.cbb3.Size = new System.Drawing.Size(185, 21);
            this.cbb3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 331);
            this.Controls.Add(this.cbb3);
            this.Controls.Add(this.cbb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.ComboBox cbb2;
        private System.Windows.Forms.ComboBox cbb3;
    }
}

