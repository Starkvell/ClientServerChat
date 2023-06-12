namespace kurs4sem
{
    partial class LoginForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.mailDomain = new System.Windows.Forms.Label();
            this.alertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(41, 108);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Black;
            this.mainLabel.Location = new System.Drawing.Point(48, 43);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(269, 31);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Введите вашу почту:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(120, 225);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(128, 35);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailDomain
            // 
            this.mailDomain.AutoSize = true;
            this.mailDomain.BackColor = System.Drawing.Color.Transparent;
            this.mailDomain.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailDomain.ForeColor = System.Drawing.Color.Black;
            this.mailDomain.Location = new System.Drawing.Point(235, 116);
            this.mailDomain.Name = "mailDomain";
            this.mailDomain.Size = new System.Drawing.Size(114, 24);
            this.mailDomain.TabIndex = 3;
            this.mailDomain.Text = "@bobkin.ru";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.BackColor = System.Drawing.Color.Transparent;
            this.alertLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertLabel.ForeColor = System.Drawing.Color.Crimson;
            this.alertLabel.Location = new System.Drawing.Point(12, 164);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 19);
            this.alertLabel.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(367, 297);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.mailDomain);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логин";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label mailDomain;
        private System.Windows.Forms.Label alertLabel;
    }
}