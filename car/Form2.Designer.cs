namespace car
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.سياراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستأجرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموظفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عقدالتأجيرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حولالنظامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // سياراتToolStripMenuItem
            // 
            this.سياراتToolStripMenuItem.Name = "سياراتToolStripMenuItem";
            this.سياراتToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.سياراتToolStripMenuItem.Text = "سيارات";
            this.سياراتToolStripMenuItem.Click += new System.EventHandler(this.سياراتToolStripMenuItem_Click);
            // 
            // المستأجرToolStripMenuItem
            // 
            this.المستأجرToolStripMenuItem.Name = "المستأجرToolStripMenuItem";
            this.المستأجرToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.المستأجرToolStripMenuItem.Text = "المستأجر";
            this.المستأجرToolStripMenuItem.Click += new System.EventHandler(this.المستأجرToolStripMenuItem_Click);
            // 
            // الموظفToolStripMenuItem
            // 
            this.الموظفToolStripMenuItem.Name = "الموظفToolStripMenuItem";
            this.الموظفToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.الموظفToolStripMenuItem.Text = "الموظف";
            this.الموظفToolStripMenuItem.Click += new System.EventHandler(this.الموظفToolStripMenuItem_Click);
            // 
            // عقدالتأجيرToolStripMenuItem
            // 
            this.عقدالتأجيرToolStripMenuItem.Name = "عقدالتأجيرToolStripMenuItem";
            this.عقدالتأجيرToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.عقدالتأجيرToolStripMenuItem.Text = "عقد التأجير";
            this.عقدالتأجيرToolStripMenuItem.Click += new System.EventHandler(this.عقدالتأجيرToolStripMenuItem_Click);
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            // 
            // حولالنظامToolStripMenuItem
            // 
            this.حولالنظامToolStripMenuItem.Name = "حولالنظامToolStripMenuItem";
            this.حولالنظامToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.حولالنظامToolStripMenuItem.Text = "حول النظام";
            this.حولالنظامToolStripMenuItem.Click += new System.EventHandler(this.حولالنظامToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سياراتToolStripMenuItem,
            this.المستأجرToolStripMenuItem,
            this.الموظفToolStripMenuItem,
            this.عقدالتأجيرToolStripMenuItem,
            this.التقاريرToolStripMenuItem,
            this.حولالنظامToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::car.Properties.Resources.IMG_20200727_160523_1024x506_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 459);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "واجهة النظام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem سياراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستأجرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموظفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عقدالتأجيرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حولالنظامToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;

    }
}