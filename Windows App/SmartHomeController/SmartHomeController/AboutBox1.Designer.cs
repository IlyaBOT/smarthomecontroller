using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartHomeController.Properties;

namespace SmartHomeController
{
    partial class AboutBox1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBoxDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDescription.ForeColor = System.Drawing.Color.White;
			this.textBoxDescription.Location = new System.Drawing.Point(140, 83);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(457, 253);
			this.textBoxDescription.TabIndex = 32;
			this.textBoxDescription.TabStop = false;
			this.textBoxDescription.Text = "Описание\r\n";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(375, 337);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(222, 28);
			this.button1.TabIndex = 33;
			this.button1.Text = "&ОК";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(140, 337);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(229, 28);
			this.button2.TabIndex = 34;
			this.button2.Text = "Разработчики";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(6, 12);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(128, 353);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.logoPictureBox.TabIndex = 28;
			this.logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelProductName.ForeColor = System.Drawing.Color.White;
			this.labelProductName.Location = new System.Drawing.Point(140, 9);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(139, 16);
			this.labelProductName.TabIndex = 35;
			this.labelProductName.Text = "Название продукта";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelVersion.ForeColor = System.Drawing.Color.White;
			this.labelVersion.Location = new System.Drawing.Point(140, 26);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(55, 16);
			this.labelVersion.TabIndex = 36;
			this.labelVersion.Text = "Версия";
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AutoSize = true;
			this.labelCompanyName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCompanyName.ForeColor = System.Drawing.Color.White;
			this.labelCompanyName.Location = new System.Drawing.Point(140, 60);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(162, 16);
			this.labelCompanyName.TabIndex = 38;
			this.labelCompanyName.Text = "Название организации";
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCopyright.ForeColor = System.Drawing.Color.White;
			this.labelCopyright.Location = new System.Drawing.Point(140, 43);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(125, 16);
			this.labelCopyright.TabIndex = 37;
			this.labelCopyright.Text = "Авторские права";
			// 
			// AboutBox1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(609, 372);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.labelCompanyName);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox1";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutBox1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox1_FormClosing);
			this.Load += new System.EventHandler(this.AboutBox1_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private PictureBox logoPictureBox;
		private TextBox textBoxDescription;
		private Button button1;
		private Button button2;
		private Label labelProductName;
		private Label labelVersion;
		private Label labelCompanyName;
		private Label labelCopyright;
	}
}
