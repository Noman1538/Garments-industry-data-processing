namespace Form1
{
    partial class WorkerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerInfo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkersGridView = new System.Windows.Forms.DataGridView();
            this.WorkerName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.mobiletextBox = new System.Windows.Forms.TextBox();
            this.positioncomboBox = new System.Windows.Forms.ComboBox();
            this.performancecomboBox = new System.Windows.Forms.ComboBox();
            this.New = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.homepageToolStripMenuItem.Text = "Back";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // WorkersGridView
            // 
            this.WorkersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkersGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersGridView.Location = new System.Drawing.Point(433, 91);
            this.WorkersGridView.Name = "WorkersGridView";
            this.WorkersGridView.RowTemplate.Height = 24;
            this.WorkersGridView.Size = new System.Drawing.Size(547, 477);
            this.WorkersGridView.TabIndex = 1;
            this.WorkersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkersGridView_CellContentClick);
            // 
            // WorkerName
            // 
            this.WorkerName.AutoSize = true;
            this.WorkerName.BackColor = System.Drawing.Color.SeaShell;
            this.WorkerName.Font = new System.Drawing.Font("X-Files", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerName.Location = new System.Drawing.Point(21, 115);
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Size = new System.Drawing.Size(59, 18);
            this.WorkerName.TabIndex = 2;
            this.WorkerName.Text = "Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.SeaShell;
            this.Address.Font = new System.Drawing.Font("X-Files", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(21, 174);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(89, 18);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.BackColor = System.Drawing.Color.SeaShell;
            this.Mobile.Font = new System.Drawing.Font("X-Files", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.Location = new System.Drawing.Point(21, 235);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(77, 18);
            this.Mobile.TabIndex = 4;
            this.Mobile.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("X-Files", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Performance";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.BackColor = System.Drawing.Color.SeaShell;
            this.Position.Font = new System.Drawing.Font("X-Files", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.Location = new System.Drawing.Point(21, 294);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(94, 18);
            this.Position.TabIndex = 5;
            this.Position.Text = "Position";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(188, 115);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(200, 22);
            this.nametextBox.TabIndex = 9;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(188, 174);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(200, 22);
            this.addresstextBox.TabIndex = 10;
            // 
            // mobiletextBox
            // 
            this.mobiletextBox.Location = new System.Drawing.Point(188, 235);
            this.mobiletextBox.Name = "mobiletextBox";
            this.mobiletextBox.Size = new System.Drawing.Size(200, 22);
            this.mobiletextBox.TabIndex = 11;
            // 
            // positioncomboBox
            // 
            this.positioncomboBox.FormattingEnabled = true;
            this.positioncomboBox.Items.AddRange(new object[] {
            "Sewinger",
            "Cutter",
            "Finisher"});
            this.positioncomboBox.Location = new System.Drawing.Point(188, 294);
            this.positioncomboBox.Name = "positioncomboBox";
            this.positioncomboBox.Size = new System.Drawing.Size(200, 24);
            this.positioncomboBox.TabIndex = 12;
            // 
            // performancecomboBox
            // 
            this.performancecomboBox.FormattingEnabled = true;
            this.performancecomboBox.Items.AddRange(new object[] {
            "Extra Ordinary",
            "Good",
            "Moderate",
            "Bad"});
            this.performancecomboBox.Location = new System.Drawing.Point(188, 360);
            this.performancecomboBox.Name = "performancecomboBox";
            this.performancecomboBox.Size = new System.Drawing.Size(200, 24);
            this.performancecomboBox.TabIndex = 13;
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.MidnightBlue;
            this.New.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.Transparent;
            this.New.Location = new System.Drawing.Point(84, 427);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(121, 45);
            this.New.TabIndex = 14;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.MidnightBlue;
            this.Update.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Transparent;
            this.Update.Location = new System.Drawing.Point(84, 493);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(121, 45);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.Delete.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Transparent;
            this.Delete.Location = new System.Drawing.Point(222, 493);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 45);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.MidnightBlue;
            this.Save.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Transparent;
            this.Save.Location = new System.Drawing.Point(222, 427);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 45);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Form1.Properties.Resources.Prev_Page;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(902, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WorkerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.performancecomboBox);
            this.Controls.Add(this.positioncomboBox);
            this.Controls.Add(this.mobiletextBox);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.WorkerName);
            this.Controls.Add(this.WorkersGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkerInfo";
            this.Text = "WorkerInfo";
            this.Load += new System.EventHandler(this.WorkerInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView WorkersGridView;
        private System.Windows.Forms.Label WorkerName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.TextBox mobiletextBox;
        private System.Windows.Forms.ComboBox positioncomboBox;
        private System.Windows.Forms.ComboBox performancecomboBox;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
    }
}