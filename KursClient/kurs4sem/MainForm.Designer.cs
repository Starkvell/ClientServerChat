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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainlabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendmailbtn = new System.Windows.Forms.Button();
            this.ThemetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WhotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailDataGridView = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.disconnect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.alertlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.BackColor = System.Drawing.Color.Transparent;
            this.mainlabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainlabel.ForeColor = System.Drawing.Color.Black;
            this.mainlabel.Location = new System.Drawing.Point(7, 9);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(293, 42);
            this.mainlabel.TabIndex = 0;
            this.mainlabel.Text = "Почтовый ящик";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(856, 442);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(166, 41);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Выход";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Подключен:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(416, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "пользователь";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(782, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "@bobkin.ru";
            // 
            // sendmailbtn
            // 
            this.sendmailbtn.Location = new System.Drawing.Point(636, 442);
            this.sendmailbtn.Name = "sendmailbtn";
            this.sendmailbtn.Size = new System.Drawing.Size(176, 41);
            this.sendmailbtn.TabIndex = 39;
            this.sendmailbtn.Text = "Отправить";
            this.sendmailbtn.UseVisualStyleBackColor = true;
            this.sendmailbtn.Click += new System.EventHandler(this.SendMailBtn_Click);
            // 
            // ThemetextBox
            // 
            this.ThemetextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemetextBox.Location = new System.Drawing.Point(721, 114);
            this.ThemetextBox.MaxLength = 20;
            this.ThemetextBox.Name = "ThemetextBox";
            this.ThemetextBox.Size = new System.Drawing.Size(381, 32);
            this.ThemetextBox.TabIndex = 38;
            this.ThemetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(554, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Тема письма:";
            // 
            // WhotextBox
            // 
            this.WhotextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhotextBox.Location = new System.Drawing.Point(636, 71);
            this.WhotextBox.MaxLength = 10;
            this.WhotextBox.Name = "WhotextBox";
            this.WhotextBox.Size = new System.Drawing.Size(140, 32);
            this.WhotextBox.TabIndex = 36;
            this.WhotextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(554, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "Кому:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(559, 152);
            this.MessageTextBox.MaxLength = 100;
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(556, 260);
            this.MessageTextBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(539, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 42);
            this.label6.TabIndex = 42;
            this.label6.Text = "Отправить письмо";
            // 
            // mailDataGridView
            // 
            this.mailDataGridView.AllowUserToAddRows = false;
            this.mailDataGridView.AllowUserToDeleteRows = false;
            this.mailDataGridView.AllowUserToResizeColumns = false;
            this.mailDataGridView.AllowUserToResizeRows = false;
            this.mailDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.mailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mailDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mailDataGridView.ColumnHeadersHeight = 24;
            this.mailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifier,
            this.name,
            this.namefrom,
            this.ReadButton,
            this.disconnect});
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
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window;
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
            // ReadButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReadButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.ReadButton.HeaderText = "";
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.ReadOnly = true;
            this.ReadButton.Text = "Читать";
            this.ReadButton.UseColumnTextForButtonValue = true;
            this.ReadButton.Width = 80;
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
            this.totalLabel.Location = new System.Drawing.Point(10, 47);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(144, 22);
            this.totalLabel.TabIndex = 44;
            this.totalLabel.Text = "Всего писем: 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alertlabel
            // 
            this.alertlabel.AutoSize = true;
            this.alertlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertlabel.ForeColor = System.Drawing.Color.Maroon;
            this.alertlabel.Location = new System.Drawing.Point(647, 525);
            this.alertlabel.Name = "alertlabel";
            this.alertlabel.Size = new System.Drawing.Size(0, 16);
            this.alertlabel.TabIndex = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 510);
            this.Controls.Add(this.alertlabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.mailDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendmailbtn);
            this.Controls.Add(this.ThemetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WhotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.mainlabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовый ящик";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendmailbtn;
        private System.Windows.Forms.TextBox ThemetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WhotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView mailDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label alertlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefrom;
        private System.Windows.Forms.DataGridViewButtonColumn ReadButton;
        private System.Windows.Forms.DataGridViewButtonColumn disconnect;
    }
}

