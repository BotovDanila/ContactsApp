namespace ContactsAppUI
{
    partial class EditForm
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
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VkIdLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VkIdTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(47, 6);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(116, 30);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(47, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 30);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateLabel.Location = new System.Drawing.Point(47, 92);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(116, 30);
            this.BirthDateLabel.TabIndex = 2;
            this.BirthDateLabel.Text = "Birthdate";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(47, 135);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(116, 30);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(47, 178);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(116, 30);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail";
            // 
            // VkIdLabel
            // 
            this.VkIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VkIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VkIdLabel.Location = new System.Drawing.Point(47, 224);
            this.VkIdLabel.Name = "VkIdLabel";
            this.VkIdLabel.Size = new System.Drawing.Size(116, 30);
            this.VkIdLabel.TabIndex = 5;
            this.VkIdLabel.Text = "Vk.com";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameTextBox.Location = new System.Drawing.Point(230, 11);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(170, 20);
            this.SurnameTextBox.TabIndex = 6;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.Location = new System.Drawing.Point(230, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(170, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Location = new System.Drawing.Point(230, 183);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(170, 20);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // VkIdTextBox
            // 
            this.VkIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VkIdTextBox.Location = new System.Drawing.Point(230, 229);
            this.VkIdTextBox.Name = "VkIdTextBox";
            this.VkIdTextBox.Size = new System.Drawing.Size(170, 20);
            this.VkIdTextBox.TabIndex = 10;
            this.VkIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // BirthDateDateTimePicker
            // 
            this.BirthDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BirthDateDateTimePicker.Location = new System.Drawing.Point(230, 97);
            this.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            this.BirthDateDateTimePicker.Size = new System.Drawing.Size(170, 20);
            this.BirthDateDateTimePicker.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SurnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VkIdTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BirthDateDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EmailTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BirthDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PhoneLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmailLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.VkIdLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneMaskedTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 264);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(305, 297);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(407, 297);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(225, 140);
            this.PhoneMaskedTextBox.Mask = "+70000000000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(179, 20);
            this.PhoneMaskedTextBox.TabIndex = 12;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 332);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditForm";
            this.Text = "Add/Edit contact";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label VkIdLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VkIdTextBox;
        private System.Windows.Forms.DateTimePicker BirthDateDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}