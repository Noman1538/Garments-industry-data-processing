namespace Form1
{
    partial class ProductUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdate));
            this.FirstOutdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.TargetOutputtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TargetInputtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PlanMantextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StyleChangestextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SMVtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LabeltextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProducttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderQuantitytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StyleNotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductIDtextBox = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstOutdateTimePicker
            // 
            this.FirstOutdateTimePicker.Location = new System.Drawing.Point(136, 423);
            this.FirstOutdateTimePicker.Name = "FirstOutdateTimePicker";
            this.FirstOutdateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.FirstOutdateTimePicker.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 582);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.UpdateProduct.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduct.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateProduct.Location = new System.Drawing.Point(29, 665);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(208, 40);
            this.UpdateProduct.TabIndex = 50;
            this.UpdateProduct.Text = "Update";
            this.UpdateProduct.UseVisualStyleBackColor = false;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // TargetOutputtextBox
            // 
            this.TargetOutputtextBox.Location = new System.Drawing.Point(136, 597);
            this.TargetOutputtextBox.Name = "TargetOutputtextBox";
            this.TargetOutputtextBox.Size = new System.Drawing.Size(114, 22);
            this.TargetOutputtextBox.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(20, 598);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Target Output";
            // 
            // TargetInputtextBox
            // 
            this.TargetInputtextBox.Location = new System.Drawing.Point(136, 555);
            this.TargetInputtextBox.Name = "TargetInputtextBox";
            this.TargetInputtextBox.Size = new System.Drawing.Size(114, 22);
            this.TargetInputtextBox.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(20, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Target Input";
            // 
            // PlanMantextBox
            // 
            this.PlanMantextBox.Location = new System.Drawing.Point(136, 511);
            this.PlanMantextBox.Name = "PlanMantextBox";
            this.PlanMantextBox.Size = new System.Drawing.Size(114, 22);
            this.PlanMantextBox.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SeaShell;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(20, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Plan Man";
            // 
            // StyleChangestextBox
            // 
            this.StyleChangestextBox.Location = new System.Drawing.Point(136, 463);
            this.StyleChangestextBox.Name = "StyleChangestextBox";
            this.StyleChangestextBox.Size = new System.Drawing.Size(114, 22);
            this.StyleChangestextBox.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(20, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Style Changes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SeaShell;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(20, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "First Out";
            // 
            // SMVtextBox
            // 
            this.SMVtextBox.Location = new System.Drawing.Point(136, 378);
            this.SMVtextBox.Name = "SMVtextBox";
            this.SMVtextBox.Size = new System.Drawing.Size(114, 22);
            this.SMVtextBox.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SeaShell;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(20, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "S.M.V.";
            // 
            // LabeltextBox
            // 
            this.LabeltextBox.Location = new System.Drawing.Point(136, 337);
            this.LabeltextBox.Name = "LabeltextBox";
            this.LabeltextBox.Size = new System.Drawing.Size(114, 22);
            this.LabeltextBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(20, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Label";
            // 
            // ProducttextBox
            // 
            this.ProducttextBox.Location = new System.Drawing.Point(136, 295);
            this.ProducttextBox.Name = "ProducttextBox";
            this.ProducttextBox.Size = new System.Drawing.Size(114, 22);
            this.ProducttextBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(20, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Product";
            // 
            // OrderQuantitytextBox
            // 
            this.OrderQuantitytextBox.Location = new System.Drawing.Point(136, 251);
            this.OrderQuantitytextBox.Name = "OrderQuantitytextBox";
            this.OrderQuantitytextBox.Size = new System.Drawing.Size(114, 22);
            this.OrderQuantitytextBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(20, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Order Quantity";
            // 
            // StyleNotextBox
            // 
            this.StyleNotextBox.Location = new System.Drawing.Point(136, 209);
            this.StyleNotextBox.Name = "StyleNotextBox";
            this.StyleNotextBox.Size = new System.Drawing.Size(114, 22);
            this.StyleNotextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Style No";
            // 
            // TeamIDtextBox
            // 
            this.TeamIDtextBox.Location = new System.Drawing.Point(136, 167);
            this.TeamIDtextBox.Name = "TeamIDtextBox";
            this.TeamIDtextBox.Size = new System.Drawing.Size(114, 22);
            this.TeamIDtextBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(20, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Team ID";
            // 
            // ProductIDtextBox
            // 
            this.ProductIDtextBox.Location = new System.Drawing.Point(136, 123);
            this.ProductIDtextBox.Name = "ProductIDtextBox";
            this.ProductIDtextBox.Size = new System.Drawing.Size(114, 22);
            this.ProductIDtextBox.TabIndex = 32;
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.BackColor = System.Drawing.Color.SeaShell;
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductID.Location = new System.Drawing.Point(20, 124);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(84, 17);
            this.ProductID.TabIndex = 31;
            this.ProductID.Text = "Product ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 28);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Form1.Properties.Resources.Prev_Page;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(1030, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 61;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 728);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.FirstOutdateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.TargetOutputtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TargetInputtextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PlanMantextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StyleChangestextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SMVtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LabeltextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProducttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderQuantitytextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StyleNotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamIDtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductIDtextBox);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductUpdate";
            this.Text = "ProductUpdate";
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FirstOutdateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.TextBox TargetOutputtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TargetInputtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PlanMantextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StyleChangestextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SMVtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LabeltextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProducttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderQuantitytextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StyleNotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TeamIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductIDtextBox;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}