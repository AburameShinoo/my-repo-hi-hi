namespace LingQGUI
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
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxData
            // 
            this.comboBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Location = new System.Drawing.Point(90, 139);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(268, 150);
            this.comboBoxData.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxResult.FormattingEnabled = true;
            this.comboBoxResult.Location = new System.Drawing.Point(437, 138);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(281, 151);
            this.comboBoxResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxResult;
    }
}

