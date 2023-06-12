namespace kurs4sem
{
    partial class MailDetail
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.whoTextBox = new System.Windows.Forms.TextBox();
            this.whoLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.themeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTextBox.Location = new System.Drawing.Point(12, 124);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(489, 285);
            this.messageTextBox.TabIndex = 0;
            // 
            // themeTextBox
            // 
            this.themeTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeTextBox.Location = new System.Drawing.Point(176, 79);
            this.themeTextBox.MaxLength = 20;
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.ReadOnly = true;
            this.themeTextBox.Size = new System.Drawing.Size(325, 29);
            this.themeTextBox.TabIndex = 45;
            this.themeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // whoTextBox
            // 
            this.whoTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whoTextBox.Location = new System.Drawing.Point(176, 39);
            this.whoTextBox.MaxLength = 10;
            this.whoTextBox.Name = "whoTextBox";
            this.whoTextBox.ReadOnly = true;
            this.whoTextBox.Size = new System.Drawing.Size(325, 29);
            this.whoTextBox.TabIndex = 43;
            this.whoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // whoLabel
            // 
            this.whoLabel.AutoSize = true;
            this.whoLabel.BackColor = System.Drawing.Color.Transparent;
            this.whoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoLabel.ForeColor = System.Drawing.Color.Black;
            this.whoLabel.Location = new System.Drawing.Point(7, 38);
            this.whoLabel.Name = "whoLabel";
            this.whoLabel.Size = new System.Drawing.Size(163, 26);
            this.whoLabel.TabIndex = 42;
            this.whoLabel.Text = "Отправитель:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(213, 428);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.BackColor = System.Drawing.Color.Transparent;
            this.themeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel.ForeColor = System.Drawing.Color.Black;
            this.themeLabel.Location = new System.Drawing.Point(7, 78);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(158, 26);
            this.themeLabel.TabIndex = 44;
            this.themeLabel.Text = "Тема письма:";
            // 
            // MailDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 482);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.whoTextBox);
            this.Controls.Add(this.whoLabel);
            this.Controls.Add(this.messageTextBox);
            this.MaximizeBox = false;
            this.Name = "MailDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробности письма от ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.TextBox whoTextBox;
        private System.Windows.Forms.Label whoLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label themeLabel;
    }
}