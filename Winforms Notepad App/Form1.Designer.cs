// Cammi Smith
// 11366085

namespace Winforms_Notepad_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFibonacciNumbersfirst50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFibonacciNumbersfirst100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadFromFileToolStripMenuItem,
            this.loadFibonacciNumbersfirst50ToolStripMenuItem,
            this.loadFibonacciNumbersfirst100ToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load from file...";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // loadFibonacciNumbersfirst50ToolStripMenuItem
            // 
            this.loadFibonacciNumbersfirst50ToolStripMenuItem.Name = "loadFibonacciNumbersfirst50ToolStripMenuItem";
            this.loadFibonacciNumbersfirst50ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.loadFibonacciNumbersfirst50ToolStripMenuItem.Text = "Load Fibonacci numbers (first 50)";
            this.loadFibonacciNumbersfirst50ToolStripMenuItem.Click += new System.EventHandler(this.loadFibonacciNumbersfirst50ToolStripMenuItem_Click);
            // 
            // loadFibonacciNumbersfirst100ToolStripMenuItem
            // 
            this.loadFibonacciNumbersfirst100ToolStripMenuItem.Name = "loadFibonacciNumbersfirst100ToolStripMenuItem";
            this.loadFibonacciNumbersfirst100ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.loadFibonacciNumbersfirst100ToolStripMenuItem.Text = "Load Fibonacci numbers (first 100)";
            this.loadFibonacciNumbersfirst100ToolStripMenuItem.Click += new System.EventHandler(this.loadFibonacciNumbersfirst100ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(843, 579);
            this.textBox1.TabIndex = 1;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 603);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "322 Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFibonacciNumbersfirst50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFibonacciNumbersfirst100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

