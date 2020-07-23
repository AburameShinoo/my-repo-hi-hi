namespace ListViewGUI
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
            this.lv1 = new System.Windows.Forms.ListView();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(304, 12);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(401, 351);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(34, 52);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(193, 23);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Larger Icon";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(34, 132);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(193, 23);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "Small Icon";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(34, 92);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(193, 23);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "Details";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 375);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
    }
}

