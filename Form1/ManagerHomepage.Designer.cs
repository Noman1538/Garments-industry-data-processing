namespace Form1
{
    partial class ManagerHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHomepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupervisorInfo = new System.Windows.Forms.Button();
            this.ProductInfo = new System.Windows.Forms.Button();
            this.TeamInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options});
            this.menuStrip1.Location = new System.Drawing.Point(20, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(960, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // options
            // 
            this.options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(73, 24);
            this.options.Text = "Options";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // SupervisorInfo
            // 
            this.SupervisorInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SupervisorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupervisorInfo.ForeColor = System.Drawing.Color.Transparent;
            this.SupervisorInfo.Image = ((System.Drawing.Image)(resources.GetObject("SupervisorInfo.Image")));
            this.SupervisorInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SupervisorInfo.Location = new System.Drawing.Point(535, 127);
            this.SupervisorInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SupervisorInfo.Name = "SupervisorInfo";
            this.SupervisorInfo.Size = new System.Drawing.Size(442, 74);
            this.SupervisorInfo.TabIndex = 1;
            this.SupervisorInfo.Text = "Update Supervisor Info";
            this.SupervisorInfo.UseVisualStyleBackColor = false;
            this.SupervisorInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductInfo
            // 
            this.ProductInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfo.ForeColor = System.Drawing.Color.Transparent;
            this.ProductInfo.Image = ((System.Drawing.Image)(resources.GetObject("ProductInfo.Image")));
            this.ProductInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProductInfo.Location = new System.Drawing.Point(535, 205);
            this.ProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(442, 74);
            this.ProductInfo.TabIndex = 2;
            this.ProductInfo.Text = "Add new product";
            this.ProductInfo.UseVisualStyleBackColor = false;
            this.ProductInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeamInfo
            // 
            this.TeamInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TeamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamInfo.ForeColor = System.Drawing.Color.Transparent;
            this.TeamInfo.Image = ((System.Drawing.Image)(resources.GetObject("TeamInfo.Image")));
            this.TeamInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TeamInfo.Location = new System.Drawing.Point(535, 283);
            this.TeamInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamInfo.Name = "TeamInfo";
            this.TeamInfo.Size = new System.Drawing.Size(442, 71);
            this.TeamInfo.TabIndex = 3;
            this.TeamInfo.Text = "Add new team";
            this.TeamInfo.UseVisualStyleBackColor = false;
            this.TeamInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form1.Properties.Resources.AAEAAQAAAAAAAAW7AAAAJDc3Y2E0OTgzLTJiMDktNDZlNi04NDU2LTQ2NmU5MGY3M2VhMA;
            this.pictureBox1.Location = new System.Drawing.Point(-56, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(535, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Supervisor Log";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ManagerHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TeamInfo);
            this.Controls.Add(this.ProductInfo);
            this.Controls.Add(this.SupervisorInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerHomepage";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Homepage: Manager";
            this.Load += new System.EventHandler(this.ManagerHomepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button SupervisorInfo;
        private System.Windows.Forms.Button ProductInfo;
        private System.Windows.Forms.Button TeamInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}