using System.ComponentModel;
using System.Windows.Forms;

namespace SmartHomeController
{
    partial class Logo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 2000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 50;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Mx437 Phoenix BIOS-2y", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(18, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ver. ";
			// 
			// Logo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SmartHomeController.Properties.Resources.SmartHomeController;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(633, 478);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Logo";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Smart Home Controller";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(33)))));
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Timer timer1;
        private Timer timer2;
		private Label label1;
	}
}