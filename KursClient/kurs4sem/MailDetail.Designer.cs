﻿namespace kurs4sem
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
            this.MSGtextBox = new System.Windows.Forms.TextBox();
            this.ThemetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WhotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MSGtextBox
            // 
            this.MSGtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSGtextBox.Location = new System.Drawing.Point(12, 124);
            this.MSGtextBox.Multiline = true;
            this.MSGtextBox.Name = "MSGtextBox";
            this.MSGtextBox.ReadOnly = true;
            this.MSGtextBox.Size = new System.Drawing.Size(489, 285);
            this.MSGtextBox.TabIndex = 0;
            // 
            // ThemetextBox
            // 
            this.ThemetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemetextBox.Location = new System.Drawing.Point(191, 76);
            this.ThemetextBox.MaxLength = 20;
            this.ThemetextBox.Name = "ThemetextBox";
            this.ThemetextBox.ReadOnly = true;
            this.ThemetextBox.Size = new System.Drawing.Size(279, 31);
            this.ThemetextBox.TabIndex = 45;
            this.ThemetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(24, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "Тема письма:";
            // 
            // WhotextBox
            // 
            this.WhotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhotextBox.Location = new System.Drawing.Point(191, 33);
            this.WhotextBox.MaxLength = 10;
            this.WhotextBox.Name = "WhotextBox";
            this.WhotextBox.ReadOnly = true;
            this.WhotextBox.Size = new System.Drawing.Size(279, 31);
            this.WhotextBox.TabIndex = 43;
            this.WhotextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(24, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Отправитель:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MailDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(513, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThemetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WhotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MSGtextBox);
            this.MaximizeBox = false;
            this.Name = "MailDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MSGtextBox;
        private System.Windows.Forms.TextBox ThemetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WhotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}