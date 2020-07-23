namespace MenuTripGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbb1 = new System.Windows.Forms.ToolStripComboBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flieToolStripMenuItem,
            this.viewToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // flieToolStripMenuItem
            // 
            this.flieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cbb1,
            this.toolStripTextBox1});
            this.flieToolStripMenuItem.Name = "flieToolStripMenuItem";
            resources.ApplyResources(this.flieToolStripMenuItem, "flieToolStripMenuItem");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // cbb1
            // 
            this.cbb1.Items.AddRange(new object[] {
            resources.GetString("cbb1.Items"),
            resources.GetString("cbb1.Items1"),
            resources.GetString("cbb1.Items2"),
            resources.GetString("cbb1.Items3"),
            resources.GetString("cbb1.Items4")});
            this.cbb1.Name = "cbb1";
            resources.ApplyResources(this.cbb1, "cbb1");
            // 
            // bt1
            // 
            resources.ApplyResources(this.bt1, "bt1");
            this.bt1.Name = "bt1";
            this.toolTip1.SetToolTip(this.bt1, resources.GetString("bt1.ToolTip"));
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // lb1
            // 
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lb1, "lb1");
            this.lb1.Name = "lb1";
            // 
            // toolStripTextBox1
            // 
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLocalToolStripMenuItem});
            this.openToolStripMenuItem.Image = global::MenuTripGUI.Properties.Resources.Folder;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::MenuTripGUI.Properties.Resources.Folder;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // openLocalToolStripMenuItem
            // 
            this.openLocalToolStripMenuItem.Name = "openLocalToolStripMenuItem";
            resources.ApplyResources(this.openLocalToolStripMenuItem, "openLocalToolStripMenuItem");
            this.openLocalToolStripMenuItem.Click += new System.EventHandler(this.openLocalToolStripMenuItem_Click);
            // 
            // bt2
            // 
            resources.ApplyResources(this.bt2, "bt2");
            this.bt2.Name = "bt2";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flieToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbb1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bt2;
    }
}

