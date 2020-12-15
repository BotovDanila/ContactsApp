namespace ContactsAppUI
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.FindTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonsLeftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EditButton = new System.Windows.Forms.Button();
            this.LeftHalfTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RigftHalfTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VkIdLabel = new System.Windows.Forms.Label();
            this.VkIdTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.FindTableLayout.SuspendLayout();
            this.ContactsTableLayout.SuspendLayout();
            this.ButtonsLeftTableLayout.SuspendLayout();
            this.LeftHalfTableLayout.SuspendLayout();
            this.MainWindowMenuStrip.SuspendLayout();
            this.RigftHalfTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindTableLayout
            // 
            this.FindTableLayout.ColumnCount = 2;
            this.FindTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.47619F));
            this.FindTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.52381F));
            this.FindTableLayout.Controls.Add(this.FindLabel, 0, 0);
            this.FindTableLayout.Controls.Add(this.FindTextBox, 1, 0);
            this.FindTableLayout.Location = new System.Drawing.Point(3, 3);
            this.FindTableLayout.Name = "FindTableLayout";
            this.FindTableLayout.RowCount = 1;
            this.FindTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FindTableLayout.Size = new System.Drawing.Size(228, 28);
            this.FindTableLayout.TabIndex = 0;
            this.FindTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.FindTableLayout_Paint);
            // 
            // FindLabel
            // 
            this.FindLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(3, 7);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(27, 13);
            this.FindLabel.TabIndex = 1;
            this.FindLabel.Text = "Find";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(95, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(110, 20);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            this.FindTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindTextBox_KeyDown);
            // 
            // ContactsTableLayout
            // 
            this.ContactsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsTableLayout.ColumnCount = 1;
            this.ContactsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.Controls.Add(this.ContactsListBox, 0, 0);
            this.ContactsTableLayout.Location = new System.Drawing.Point(3, 41);
            this.ContactsTableLayout.Name = "ContactsTableLayout";
            this.ContactsTableLayout.RowCount = 1;
            this.ContactsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.Size = new System.Drawing.Size(217, 282);
            this.ContactsTableLayout.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 3);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(211, 264);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox1_SelectedIndexChanged);
            this.ContactsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContactsListBox_KeyDown);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveButton.BackgroundImage")));
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.Location = new System.Drawing.Point(177, 13);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(25, 27);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Location = new System.Drawing.Point(24, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(28, 27);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ButtonsLeftTableLayout
            // 
            this.ButtonsLeftTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonsLeftTableLayout.ColumnCount = 3;
            this.ButtonsLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsLeftTableLayout.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsLeftTableLayout.Controls.Add(this.RemoveButton, 2, 0);
            this.ButtonsLeftTableLayout.Controls.Add(this.EditButton, 1, 0);
            this.ButtonsLeftTableLayout.Location = new System.Drawing.Point(3, 329);
            this.ButtonsLeftTableLayout.Name = "ButtonsLeftTableLayout";
            this.ButtonsLeftTableLayout.RowCount = 1;
            this.ButtonsLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLeftTableLayout.Size = new System.Drawing.Size(228, 53);
            this.ButtonsLeftTableLayout.TabIndex = 4;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton.Location = new System.Drawing.Point(100, 13);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(28, 27);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LeftHalfTableLayout
            // 
            this.LeftHalfTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftHalfTableLayout.ColumnCount = 1;
            this.LeftHalfTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftHalfTableLayout.Controls.Add(this.FindTableLayout, 0, 0);
            this.LeftHalfTableLayout.Controls.Add(this.ContactsTableLayout, 0, 1);
            this.LeftHalfTableLayout.Controls.Add(this.ButtonsLeftTableLayout, 0, 2);
            this.LeftHalfTableLayout.Location = new System.Drawing.Point(12, 36);
            this.LeftHalfTableLayout.Name = "LeftHalfTableLayout";
            this.LeftHalfTableLayout.RowCount = 3;
            this.LeftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.LeftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LeftHalfTableLayout.Size = new System.Drawing.Size(234, 385);
            this.LeftHalfTableLayout.TabIndex = 5;
            // 
            // MainWindowMenuStrip
            // 
            this.MainWindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainWindowMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowMenuStrip.Name = "MainWindowMenuStrip";
            this.MainWindowMenuStrip.Size = new System.Drawing.Size(847, 24);
            this.MainWindowMenuStrip.TabIndex = 6;
            this.MainWindowMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // RigftHalfTableLayout
            // 
            this.RigftHalfTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RigftHalfTableLayout.ColumnCount = 2;
            this.RigftHalfTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.RigftHalfTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RigftHalfTableLayout.Controls.Add(this.VkIdLabel, 0, 5);
            this.RigftHalfTableLayout.Controls.Add(this.VkIdTextBox, 1, 5);
            this.RigftHalfTableLayout.Controls.Add(this.SurnameLabel, 0, 0);
            this.RigftHalfTableLayout.Controls.Add(this.EmailTextBox, 1, 4);
            this.RigftHalfTableLayout.Controls.Add(this.EmailLabel, 0, 4);
            this.RigftHalfTableLayout.Controls.Add(this.NameLabel, 0, 1);
            this.RigftHalfTableLayout.Controls.Add(this.PhoneLabel, 0, 3);
            this.RigftHalfTableLayout.Controls.Add(this.NameTextBox, 1, 1);
            this.RigftHalfTableLayout.Controls.Add(this.BirthDateLabel, 0, 2);
            this.RigftHalfTableLayout.Controls.Add(this.SurnameTextBox, 1, 0);
            this.RigftHalfTableLayout.Controls.Add(this.BirthDateDateTimePicker, 1, 2);
            this.RigftHalfTableLayout.Controls.Add(this.PhoneMaskedTextBox1, 1, 3);
            this.RigftHalfTableLayout.Location = new System.Drawing.Point(345, 31);
            this.RigftHalfTableLayout.Name = "RigftHalfTableLayout";
            this.RigftHalfTableLayout.RowCount = 6;
            this.RigftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RigftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RigftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RigftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RigftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RigftHalfTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RigftHalfTableLayout.Size = new System.Drawing.Size(476, 331);
            this.RigftHalfTableLayout.TabIndex = 7;
            // 
            // VkIdLabel
            // 
            this.VkIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VkIdLabel.AutoSize = true;
            this.VkIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VkIdLabel.Location = new System.Drawing.Point(23, 294);
            this.VkIdLabel.Name = "VkIdLabel";
            this.VkIdLabel.Size = new System.Drawing.Size(54, 17);
            this.VkIdLabel.TabIndex = 13;
            this.VkIdLabel.Text = "Vk.com";
            // 
            // VkIdTextBox
            // 
            this.VkIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkIdTextBox.Location = new System.Drawing.Point(103, 293);
            this.VkIdTextBox.Name = "VkIdTextBox";
            this.VkIdTextBox.Size = new System.Drawing.Size(370, 20);
            this.VkIdTextBox.TabIndex = 13;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SurnameLabel.Location = new System.Drawing.Point(17, 19);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(65, 17);
            this.SurnameLabel.TabIndex = 8;
            this.SurnameLabel.Text = "Surname";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(103, 237);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(370, 20);
            this.EmailTextBox.TabIndex = 12;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmailLabel.Location = new System.Drawing.Point(26, 239);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(47, 17);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "E-mail";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(27, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PhoneLabel.Location = new System.Drawing.Point(25, 184);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 17);
            this.PhoneLabel.TabIndex = 11;
            this.PhoneLabel.Text = "Phone";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(103, 72);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(370, 20);
            this.NameTextBox.TabIndex = 9;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BirthDateLabel.Location = new System.Drawing.Point(16, 129);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(67, 17);
            this.BirthDateLabel.TabIndex = 10;
            this.BirthDateLabel.Text = "BirthDate";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(103, 17);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(370, 20);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // BirthDateDateTimePicker
            // 
            this.BirthDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDateDateTimePicker.Location = new System.Drawing.Point(103, 127);
            this.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            this.BirthDateDateTimePicker.Size = new System.Drawing.Size(370, 20);
            this.BirthDateDateTimePicker.TabIndex = 14;
            // 
            // PhoneMaskedTextBox1
            // 
            this.PhoneMaskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneMaskedTextBox1.Location = new System.Drawing.Point(103, 182);
            this.PhoneMaskedTextBox1.Mask = "+7000000000";
            this.PhoneMaskedTextBox1.Name = "PhoneMaskedTextBox1";
            this.PhoneMaskedTextBox1.Size = new System.Drawing.Size(370, 20);
            this.PhoneMaskedTextBox1.TabIndex = 15;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.Location = new System.Drawing.Point(342, 383);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(57, 16);
            this.BirthdayLabel.TabIndex = 8;
            this.BirthdayLabel.Text = "Birthday";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.RigftHalfTableLayout);
            this.Controls.Add(this.LeftHalfTableLayout);
            this.Controls.Add(this.MainWindowMenuStrip);
            this.MainMenuStrip = this.MainWindowMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Main_Form";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.FindTableLayout.ResumeLayout(false);
            this.FindTableLayout.PerformLayout();
            this.ContactsTableLayout.ResumeLayout(false);
            this.ButtonsLeftTableLayout.ResumeLayout(false);
            this.LeftHalfTableLayout.ResumeLayout(false);
            this.MainWindowMenuStrip.ResumeLayout(false);
            this.MainWindowMenuStrip.PerformLayout();
            this.RigftHalfTableLayout.ResumeLayout(false);
            this.RigftHalfTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FindTableLayout;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TableLayoutPanel ContactsTableLayout;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TableLayoutPanel ButtonsLeftTableLayout;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TableLayoutPanel LeftHalfTableLayout;
        private System.Windows.Forms.MenuStrip MainWindowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel RigftHalfTableLayout;
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
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label BirthdayLabel;
    }
}

