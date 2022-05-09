namespace RestaurantV2
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
            this.addResBtn = new System.Windows.Forms.Button();
            this.registrationView = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creatorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addResBtn
            // 
            this.addResBtn.Location = new System.Drawing.Point(66, 322);
            this.addResBtn.Name = "addResBtn";
            this.addResBtn.Size = new System.Drawing.Size(106, 50);
            this.addResBtn.TabIndex = 0;
            this.addResBtn.Text = "Add Reservation";
            this.addResBtn.UseVisualStyleBackColor = true;
            this.addResBtn.Click += new System.EventHandler(this.addResBtn_Click);
            // 
            // registrationView
            // 
            this.registrationView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.creatorCol,
            this.priceCol});
            this.registrationView.FullRowSelect = true;
            this.registrationView.HideSelection = false;
            this.registrationView.Location = new System.Drawing.Point(66, 138);
            this.registrationView.Name = "registrationView";
            this.registrationView.Size = new System.Drawing.Size(301, 97);
            this.registrationView.TabIndex = 1;
            this.registrationView.UseCompatibleStateImageBehavior = false;
            this.registrationView.View = System.Windows.Forms.View.Details;
            this.registrationView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.registrationView_MouseDoubleClick);
            // 
            // idCol
            // 
            this.idCol.Text = "Id";
            // 
            // creatorCol
            // 
            this.creatorCol.Text = "Creator Name";
            this.creatorCol.Width = 120;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Price";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrationView);
            this.Controls.Add(this.addResBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addResBtn;
        private System.Windows.Forms.ListView registrationView;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader creatorCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
    }
}

