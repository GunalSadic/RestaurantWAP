namespace RestaurantV2
{
    partial class AddRegistrationForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.creatorBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(172, 78);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id:";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(116, 127);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(75, 13);
            this.creatorLabel.TabIndex = 1;
            this.creatorLabel.Text = "Creator Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(157, 170);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(197, 75);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 3;
            this.idBox.Validating += new System.ComponentModel.CancelEventHandler(this.idBox_Validating);
            this.idBox.Validated += new System.EventHandler(this.idBox_Validated);
            // 
            // creatorBox
            // 
            this.creatorBox.Location = new System.Drawing.Point(197, 124);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.Size = new System.Drawing.Size(100, 20);
            this.creatorBox.TabIndex = 4;
            this.creatorBox.Validating += new System.ComponentModel.CancelEventHandler(this.creatorBox_Validating);
            this.creatorBox.Validated += new System.EventHandler(this.creatorBox_Validated);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(197, 163);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 5;
            this.priceBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceBox_Validating);
            this.priceBox.Validated += new System.EventHandler(this.priceBox_Validated);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(197, 224);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // AddRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 322);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.creatorBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "AddRegistrationForm";
            this.Text = "AddRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox creatorBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}