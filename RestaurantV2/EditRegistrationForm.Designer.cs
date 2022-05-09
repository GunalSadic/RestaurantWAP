namespace RestaurantV2
{
    partial class EditRegistrationForm
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
            this.editBtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.creatorBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(151, 196);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 23);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(151, 135);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 12;
            this.priceBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceBox_Validating);
            this.priceBox.Validated += new System.EventHandler(this.priceBox_Validated);
            // 
            // creatorBox
            // 
            this.creatorBox.Location = new System.Drawing.Point(151, 96);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.Size = new System.Drawing.Size(100, 20);
            this.creatorBox.TabIndex = 11;
            this.creatorBox.Validating += new System.ComponentModel.CancelEventHandler(this.creatorBox_Validating);
            this.creatorBox.Validated += new System.EventHandler(this.creatorBox_Validated);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(151, 47);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 10;
            this.idBox.Validating += new System.ComponentModel.CancelEventHandler(this.idBox_Validating);
            this.idBox.Validated += new System.EventHandler(this.idBox_Validated);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(111, 142);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price:";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(70, 99);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(75, 13);
            this.creatorLabel.TabIndex = 8;
            this.creatorLabel.Text = "Creator Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(126, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "Id:";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // EditRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 297);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.creatorBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "EditRegistrationForm";
            this.Text = "EditRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox creatorBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}