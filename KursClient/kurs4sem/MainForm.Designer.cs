namespace kurs4sem
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.connectStaticLabel = new System.Windows.Forms.Label();
            this.connectDynamicLabel = new System.Windows.Forms.Label();
            this.mailDomain = new System.Windows.Forms.Label();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.themeLabel = new System.Windows.Forms.Label();
            this.whoLabel = new System.Windows.Forms.Label();
            this.sendMailLabel = new System.Windows.Forms.Label();
            this.mailDataGridView = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.disconnect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.alertLabel = new System.Windows.Forms.Label();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.whoTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.ForeColor = System.Drawing.Color.Black;
            this.mainLabel.Location = new System.Drawing.Point(7, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(293, 42);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Почтовый ящик";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(856, 442);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 41);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // connectStaticLabel
            // 
            this.connectStaticLabel.AutoSize = true;
            this.connectStaticLabel.BackColor = System.Drawing.Color.Transparent;
            this.connectStaticLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectStaticLabel.ForeColor = System.Drawing.Color.Black;
            this.connectStaticLabel.Location = new System.Drawing.Point(298, 47);
            this.connectStaticLabel.Name = "connectStaticLabel";
            this.connectStaticLabel.Size = new System.Drawing.Size(115, 22);
            this.connectStaticLabel.TabIndex = 32;
            this.connectStaticLabel.Text = "Подключен:";
            // 
            // connectDynamicLabel
            // 
            this.connectDynamicLabel.AutoSize = true;
            this.connectDynamicLabel.BackColor = System.Drawing.Color.Transparent;
            this.connectDynamicLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectDynamicLabel.ForeColor = System.Drawing.Color.Black;
            this.connectDynamicLabel.Location = new System.Drawing.Point(416, 46);
            this.connectDynamicLabel.Name = "connectDynamicLabel";
            this.connectDynamicLabel.Size = new System.Drawing.Size(129, 22);
            this.connectDynamicLabel.TabIndex = 33;
            this.connectDynamicLabel.Text = "пользователь";
            this.connectDynamicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailDomain
            // 
            this.mailDomain.AutoSize = true;
            this.mailDomain.BackColor = System.Drawing.Color.Transparent;
            this.mailDomain.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailDomain.ForeColor = System.Drawing.Color.Black;
            this.mailDomain.Location = new System.Drawing.Point(782, 74);
            this.mailDomain.Name = "mailDomain";
            this.mailDomain.Size = new System.Drawing.Size(135, 26);
            this.mailDomain.TabIndex = 41;
            this.mailDomain.Text = "@bobkin.ru";
            // 
            // sendMailButton
            // 
            this.sendMailButton.Location = new System.Drawing.Point(636, 442);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(176, 41);
            this.sendMailButton.TabIndex = 39;
            this.sendMailButton.Text = "Отправить";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.SendMailBtn_Click);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.BackColor = System.Drawing.Color.Transparent;
            this.themeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel.ForeColor = System.Drawing.Color.Black;
            this.themeLabel.Location = new System.Drawing.Point(554, 114);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(158, 26);
            this.themeLabel.TabIndex = 37;
            this.themeLabel.Text = "Тема письма:";
            // 
            // whoLabel
            // 
            this.whoLabel.AutoSize = true;
            this.whoLabel.BackColor = System.Drawing.Color.Transparent;
            this.whoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whoLabel.ForeColor = System.Drawing.Color.Black;
            this.whoLabel.Location = new System.Drawing.Point(554, 71);
            this.whoLabel.Name = "whoLabel";
            this.whoLabel.Size = new System.Drawing.Size(76, 26);
            this.whoLabel.TabIndex = 35;
            this.whoLabel.Text = "Кому:";
            // 
            // sendMailLabel
            // 
            this.sendMailLabel.AutoSize = true;
            this.sendMailLabel.BackColor = System.Drawing.Color.Transparent;
            this.sendMailLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMailLabel.ForeColor = System.Drawing.Color.Black;
            this.sendMailLabel.Location = new System.Drawing.Point(539, 9);
            this.sendMailLabel.Name = "sendMailLabel";
            this.sendMailLabel.Size = new System.Drawing.Size(335, 42);
            this.sendMailLabel.TabIndex = 42;
            this.sendMailLabel.Text = "Отправить письмо";
            // 
            // mailDataGridView
            // 
            this.mailDataGridView.AllowUserToAddRows = false;
            this.mailDataGridView.AllowUserToDeleteRows = false;
            this.mailDataGridView.AllowUserToResizeColumns = false;
            this.mailDataGridView.AllowUserToResizeRows = false;
            this.mailDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.mailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mailDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mailDataGridView.ColumnHeadersHeight = 24;
            this.mailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.identifier, this.name, this.namefrom, this.readButton, this.disconnect });
            this.mailDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mailDataGridView.EnableHeadersVisualStyles = false;
            this.mailDataGridView.GridColor = System.Drawing.Color.DarkKhaki;
            this.mailDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.mailDataGridView.Location = new System.Drawing.Point(13, 71);
            this.mailDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mailDataGridView.MultiSelect = false;
            this.mailDataGridView.Name = "mailDataGridView";
            this.mailDataGridView.ReadOnly = true;
            this.mailDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mailDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mailDataGridView.RowHeadersVisible = false;
            this.mailDataGridView.RowHeadersWidth = 40;
            this.mailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.mailDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.mailDataGridView.RowTemplate.Height = 24;
            this.mailDataGridView.RowTemplate.ReadOnly = true;
            this.mailDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mailDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mailDataGridView.ShowCellErrors = false;
            this.mailDataGridView.ShowCellToolTips = false;
            this.mailDataGridView.ShowEditingIcon = false;
            this.mailDataGridView.ShowRowErrors = false;
            this.mailDataGridView.Size = new System.Drawing.Size(520, 412);
            this.mailDataGridView.TabIndex = 43;
            this.mailDataGridView.TabStop = false;
            this.mailDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailDataGridView_CellContentClick);
            // 
            // identifier
            // 
            this.identifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.identifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.identifier.HeaderText = "ID";
            this.identifier.MaxInputLength = 20;
            this.identifier.MinimumWidth = 20;
            this.identifier.Name = "identifier";
            this.identifier.ReadOnly = true;
            this.identifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.identifier.Width = 40;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Тема письма";
            this.name.MaxInputLength = 20;
            this.name.MinimumWidth = 20;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // namefrom
            // 
            this.namefrom.HeaderText = "Отправитель";
            this.namefrom.Name = "namefrom";
            this.namefrom.ReadOnly = true;
            // 
            // readButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.readButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.readButton.HeaderText = "";
            this.readButton.Name = "readButton";
            this.readButton.ReadOnly = true;
            this.readButton.Text = "Читать";
            this.readButton.UseColumnTextForButtonValue = true;
            this.readButton.Width = 80;
            // 
            // disconnect
            // 
            this.disconnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.disconnect.DefaultCellStyle = dataGridViewCellStyle5;
            this.disconnect.HeaderText = "";
            this.disconnect.MinimumWidth = 20;
            this.disconnect.Name = "disconnect";
            this.disconnect.ReadOnly = true;
            this.disconnect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.disconnect.Text = "Удалить";
            this.disconnect.UseColumnTextForButtonValue = true;
            this.disconnect.Width = 80;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(11, 47);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(144, 22);
            this.totalLabel.TabIndex = 44;
            this.totalLabel.Text = "Всего писем: 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.alertLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertLabel.ForeColor = System.Drawing.Color.Crimson;
            this.alertLabel.Location = new System.Drawing.Point(590, 381);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 19);
            this.alertLabel.TabIndex = 45;
            // 
            // themeTextBox
            // 
            this.themeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.themeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeTextBox.Location = new System.Drawing.Point(721, 114);
            this.themeTextBox.MaxLength = 20;
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(381, 32);
            this.themeTextBox.TabIndex = 38;
            this.themeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // whoTextBox
            // 
            this.whoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.whoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whoTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whoTextBox.Location = new System.Drawing.Point(636, 71);
            this.whoTextBox.MaxLength = 10;
            this.whoTextBox.Name = "whoTextBox";
            this.whoTextBox.Size = new System.Drawing.Size(140, 32);
            this.whoTextBox.TabIndex = 36;
            this.whoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTextBox.Location = new System.Drawing.Point(552, 161);
            this.messageTextBox.MaxLength = 100;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(566, 265);
            this.messageTextBox.TabIndex = 46;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 513);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.whoTextBox);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.mailDataGridView);
            this.Controls.Add(this.sendMailLabel);
            this.Controls.Add(this.mailDomain);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.whoLabel);
            this.Controls.Add(this.connectDynamicLabel);
            this.Controls.Add(this.connectStaticLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.messageTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовый ящик";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label connectStaticLabel;
        private System.Windows.Forms.Label connectDynamicLabel;
        private System.Windows.Forms.Label mailDomain;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Label whoLabel;
        private System.Windows.Forms.Label sendMailLabel;
        private System.Windows.Forms.DataGridView mailDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefrom;
        private System.Windows.Forms.DataGridViewButtonColumn readButton;
        private System.Windows.Forms.DataGridViewButtonColumn disconnect;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.TextBox whoTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}

