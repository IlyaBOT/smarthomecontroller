using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using SmartHomeController.Properties;

namespace SmartHomeController
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.параметрыПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cOMПортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.скоростьПередачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
			this.отключениеОтКонтроллераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2TrackBar3 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar4 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.guna2TrackBar8 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar7 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label8 = new System.Windows.Forms.Label();
			this.guna2TrackBar6 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.guna2TrackBar5 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.guna2TrackBar9 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar10 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label13 = new System.Windows.Forms.Label();
			this.guna2TrackBar11 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label14 = new System.Windows.Forms.Label();
			this.guna2TrackBar12 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label15 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
			this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem59 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem63 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem67 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem68 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem69 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem70 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem71 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem72 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem73 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem56 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem57 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem58 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem74 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem75 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem61 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem62 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem65 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem66 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton7 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem64 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem76 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem78 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem77 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem79 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem80 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem81 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem82 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem83 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem84 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem85 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem86 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem87 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem88 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem89 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem90 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem91 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem92 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem93 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem94 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem95 = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 413);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(812, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(101, 19);
			this.toolStripStatusLabel2.Text = "Состояние:";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 19);
			this.toolStripStatusLabel1.Text = "Отключён";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton6,
            this.toolStripDropDownButton7,
            this.toolStripSeparator1,
            this.toolStripDropDownButton3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(812, 26);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыПодключенияToolStripMenuItem,
            this.отключениеОтКонтроллераToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.toolStripDropDownButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.ShowDropDownArrow = false;
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(90, 23);
			this.toolStripDropDownButton1.Text = "Действия";
			this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
			// 
			// параметрыПодключенияToolStripMenuItem
			// 
			this.параметрыПодключенияToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.параметрыПодключенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMПортToolStripMenuItem,
            this.скоростьПередачиToolStripMenuItem});
			this.параметрыПодключенияToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.параметрыПодключенияToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.параметрыПодключенияToolStripMenuItem.Name = "параметрыПодключенияToolStripMenuItem";
			this.параметрыПодключенияToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
			this.параметрыПодключенияToolStripMenuItem.Text = "Параметры подключения";
			// 
			// cOMПортToolStripMenuItem
			// 
			this.cOMПортToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cOMПортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
			this.cOMПортToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.cOMПортToolStripMenuItem.Name = "cOMПортToolStripMenuItem";
			this.cOMПортToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.cOMПортToolStripMenuItem.Text = "COM-Порт";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.BackColor = System.Drawing.Color.White;
			this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.toolStripComboBox1.ForeColor = System.Drawing.Color.Black;
			this.toolStripComboBox1.Items.AddRange(new object[] {
            "NULL"});
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
			// 
			// скоростьПередачиToolStripMenuItem
			// 
			this.скоростьПередачиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.скоростьПередачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
			this.скоростьПередачиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.скоростьПередачиToolStripMenuItem.Name = "скоростьПередачиToolStripMenuItem";
			this.скоростьПередачиToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.скоростьПередачиToolStripMenuItem.Text = "Скорость передачи";
			// 
			// toolStripComboBox2
			// 
			this.toolStripComboBox2.BackColor = System.Drawing.Color.White;
			this.toolStripComboBox2.ForeColor = System.Drawing.Color.Black;
			this.toolStripComboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
			this.toolStripComboBox2.Name = "toolStripComboBox2";
			this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
			// 
			// отключениеОтКонтроллераToolStripMenuItem
			// 
			this.отключениеОтКонтроллераToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.отключениеОтКонтроллераToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.отключениеОтКонтроллераToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.отключениеОтКонтроллераToolStripMenuItem.Name = "отключениеОтКонтроллераToolStripMenuItem";
			this.отключениеОтКонтроллераToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
			this.отключениеОтКонтроллераToolStripMenuItem.Text = "Подключение к контроллеру";
			this.отключениеОтКонтроллераToolStripMenuItem.Click += new System.EventHandler(this.отключениеОтКонтроллераToolStripMenuItem_Click);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.настройкиToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.выходToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.ForeColor = System.Drawing.Color.DimGray;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton4
			// 
			this.toolStripDropDownButton4.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8,
            this.toolStripMenuItem11});
			this.toolStripDropDownButton4.Enabled = false;
			this.toolStripDropDownButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton4.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
			this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
			this.toolStripDropDownButton4.ShowDropDownArrow = false;
			this.toolStripDropDownButton4.Size = new System.Drawing.Size(111, 23);
			this.toolStripDropDownButton4.Text = "Освещение";
			this.toolStripDropDownButton4.Visible = false;
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.toolStripMenuItem2.Enabled = false;
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem2.Text = "Освещение 1";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem3.Text = "Включить";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem4.Text = "Выключить";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
			this.toolStripMenuItem5.Enabled = false;
			this.toolStripMenuItem5.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem5.Text = "Освещение 2";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem6.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem6.Text = "Включить";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem7.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem7.Text = "Выключить";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
			this.toolStripMenuItem8.Enabled = false;
			this.toolStripMenuItem8.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem8.Text = "Освещение 3";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem9.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem9.Text = "Включить";
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem10.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem10.Text = "Выключить";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
			this.toolStripMenuItem11.Enabled = false;
			this.toolStripMenuItem11.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem11.Text = "Освещение 4";
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem12.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem12.Text = "Включить";
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem13.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem13.Text = "Выключить";
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.toolStripMenuItem16,
            this.toolStripMenuItem15});
			this.toolStripDropDownButton2.Enabled = false;
			this.toolStripDropDownButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.ShowDropDownArrow = false;
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(75, 23);
			this.toolStripDropDownButton2.Text = "Спикер";
			this.toolStripDropDownButton2.ToolTipText = "Пищалка";
			this.toolStripDropDownButton2.Visible = false;
			// 
			// toolStripMenuItem17
			// 
			this.toolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem21,
            this.toolStripMenuItem20,
            this.toolStripMenuItem19,
            this.toolStripMenuItem18,
            this.toolStripMenuItem14});
			this.toolStripMenuItem17.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem17.Name = "toolStripMenuItem17";
			this.toolStripMenuItem17.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem17.Text = "Писк BIOS";
			// 
			// toolStripMenuItem21
			// 
			this.toolStripMenuItem21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem21.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem21.Name = "toolStripMenuItem21";
			this.toolStripMenuItem21.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem21.Text = "1 пик";
			this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStripMenuItem21_Click);
			// 
			// toolStripMenuItem20
			// 
			this.toolStripMenuItem20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem20.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem20.Name = "toolStripMenuItem20";
			this.toolStripMenuItem20.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem20.Text = "2 пика";
			this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
			// 
			// toolStripMenuItem19
			// 
			this.toolStripMenuItem19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem19.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem19.Name = "toolStripMenuItem19";
			this.toolStripMenuItem19.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem19.Text = "3 пика";
			this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
			// 
			// toolStripMenuItem18
			// 
			this.toolStripMenuItem18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem18.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem18.Name = "toolStripMenuItem18";
			this.toolStripMenuItem18.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem18.Text = "4 пика";
			this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem14.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem14.Text = "5 пиков";
			this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
			// 
			// toolStripMenuItem16
			// 
			this.toolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem23,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.toolStripMenuItem28});
			this.toolStripMenuItem16.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem16.Name = "toolStripMenuItem16";
			this.toolStripMenuItem16.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem16.Text = "Писк 1 кГц";
			// 
			// toolStripMenuItem23
			// 
			this.toolStripMenuItem23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem23.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem23.Name = "toolStripMenuItem23";
			this.toolStripMenuItem23.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem23.Text = "100 Мс";
			this.toolStripMenuItem23.Click += new System.EventHandler(this.toolStripMenuItem23_Click);
			// 
			// toolStripMenuItem25
			// 
			this.toolStripMenuItem25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem25.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem25.Name = "toolStripMenuItem25";
			this.toolStripMenuItem25.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem25.Text = "250 Мс";
			this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
			// 
			// toolStripMenuItem26
			// 
			this.toolStripMenuItem26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem26.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem26.Name = "toolStripMenuItem26";
			this.toolStripMenuItem26.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem26.Text = "500 Мс";
			this.toolStripMenuItem26.Click += new System.EventHandler(this.toolStripMenuItem26_Click);
			// 
			// toolStripMenuItem27
			// 
			this.toolStripMenuItem27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem27.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem27.Name = "toolStripMenuItem27";
			this.toolStripMenuItem27.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem27.Text = "1 Секунда";
			this.toolStripMenuItem27.Click += new System.EventHandler(this.toolStripMenuItem27_Click);
			// 
			// toolStripMenuItem28
			// 
			this.toolStripMenuItem28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem28.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem28.Name = "toolStripMenuItem28";
			this.toolStripMenuItem28.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem28.Text = "2 Секунды";
			this.toolStripMenuItem28.Click += new System.EventHandler(this.toolStripMenuItem28_Click);
			// 
			// toolStripMenuItem15
			// 
			this.toolStripMenuItem15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem24,
            this.toolStripMenuItem30,
            this.toolStripMenuItem31,
            this.toolStripMenuItem32,
            this.toolStripMenuItem33});
			this.toolStripMenuItem15.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			this.toolStripMenuItem15.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem15.Text = "Писк 2 кГц";
			// 
			// toolStripMenuItem24
			// 
			this.toolStripMenuItem24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem24.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem24.Name = "toolStripMenuItem24";
			this.toolStripMenuItem24.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem24.Text = "100 Мс";
			this.toolStripMenuItem24.Click += new System.EventHandler(this.toolStripMenuItem24_Click);
			// 
			// toolStripMenuItem30
			// 
			this.toolStripMenuItem30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem30.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem30.Name = "toolStripMenuItem30";
			this.toolStripMenuItem30.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem30.Text = "250 Мс";
			this.toolStripMenuItem30.Click += new System.EventHandler(this.toolStripMenuItem30_Click);
			// 
			// toolStripMenuItem31
			// 
			this.toolStripMenuItem31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem31.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem31.Name = "toolStripMenuItem31";
			this.toolStripMenuItem31.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem31.Text = "500 Мс";
			this.toolStripMenuItem31.Click += new System.EventHandler(this.toolStripMenuItem31_Click);
			// 
			// toolStripMenuItem32
			// 
			this.toolStripMenuItem32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem32.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem32.Name = "toolStripMenuItem32";
			this.toolStripMenuItem32.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem32.Text = "1 Секунда";
			this.toolStripMenuItem32.Click += new System.EventHandler(this.toolStripMenuItem32_Click);
			// 
			// toolStripMenuItem33
			// 
			this.toolStripMenuItem33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem33.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem33.Name = "toolStripMenuItem33";
			this.toolStripMenuItem33.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem33.Text = "2 Секунды";
			this.toolStripMenuItem33.Click += new System.EventHandler(this.toolStripMenuItem33_Click);
			// 
			// toolStripDropDownButton5
			// 
			this.toolStripDropDownButton5.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem45,
            this.toolStripMenuItem41,
            this.toolStripMenuItem34,
            this.toolStripMenuItem29});
			this.toolStripDropDownButton5.Enabled = false;
			this.toolStripDropDownButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton5.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
			this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
			this.toolStripDropDownButton5.ShowDropDownArrow = false;
			this.toolStripDropDownButton5.Size = new System.Drawing.Size(134, 23);
			this.toolStripDropDownButton5.Text = "Электромотор";
			this.toolStripDropDownButton5.ToolTipText = "Пищалка";
			this.toolStripDropDownButton5.Visible = false;
			// 
			// toolStripMenuItem45
			// 
			this.toolStripMenuItem45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem45.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem46,
            this.toolStripMenuItem47,
            this.toolStripMenuItem48});
			this.toolStripMenuItem45.Enabled = false;
			this.toolStripMenuItem45.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem45.Name = "toolStripMenuItem45";
			this.toolStripMenuItem45.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem45.Text = "Мотор 1";
			// 
			// toolStripMenuItem46
			// 
			this.toolStripMenuItem46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem46.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem46.Name = "toolStripMenuItem46";
			this.toolStripMenuItem46.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem46.Text = "Включить";
			this.toolStripMenuItem46.Click += new System.EventHandler(this.toolStripMenuItem46_Click);
			// 
			// toolStripMenuItem47
			// 
			this.toolStripMenuItem47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem47.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem47.Name = "toolStripMenuItem47";
			this.toolStripMenuItem47.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem47.Text = "Половина скорости";
			this.toolStripMenuItem47.Click += new System.EventHandler(this.toolStripMenuItem47_Click);
			// 
			// toolStripMenuItem48
			// 
			this.toolStripMenuItem48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem48.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem48.Name = "toolStripMenuItem48";
			this.toolStripMenuItem48.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem48.Text = "Выключить";
			this.toolStripMenuItem48.Click += new System.EventHandler(this.toolStripMenuItem48_Click);
			// 
			// toolStripMenuItem41
			// 
			this.toolStripMenuItem41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem41.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem42,
            this.toolStripMenuItem43,
            this.toolStripMenuItem44});
			this.toolStripMenuItem41.Enabled = false;
			this.toolStripMenuItem41.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem41.Name = "toolStripMenuItem41";
			this.toolStripMenuItem41.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem41.Text = "Мотор 2";
			// 
			// toolStripMenuItem42
			// 
			this.toolStripMenuItem42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem42.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem42.Name = "toolStripMenuItem42";
			this.toolStripMenuItem42.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem42.Text = "Включить";
			// 
			// toolStripMenuItem43
			// 
			this.toolStripMenuItem43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem43.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem43.Name = "toolStripMenuItem43";
			this.toolStripMenuItem43.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem43.Text = "Половина скорости";
			// 
			// toolStripMenuItem44
			// 
			this.toolStripMenuItem44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem44.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem44.Name = "toolStripMenuItem44";
			this.toolStripMenuItem44.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem44.Text = "Выключить";
			// 
			// toolStripMenuItem34
			// 
			this.toolStripMenuItem34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem34.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem37,
            this.toolStripMenuItem39,
            this.toolStripMenuItem40});
			this.toolStripMenuItem34.Enabled = false;
			this.toolStripMenuItem34.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem34.Name = "toolStripMenuItem34";
			this.toolStripMenuItem34.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem34.Text = "Мотор 3";
			// 
			// toolStripMenuItem37
			// 
			this.toolStripMenuItem37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem37.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem37.Name = "toolStripMenuItem37";
			this.toolStripMenuItem37.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem37.Text = "Включить";
			// 
			// toolStripMenuItem39
			// 
			this.toolStripMenuItem39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem39.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem39.Name = "toolStripMenuItem39";
			this.toolStripMenuItem39.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem39.Text = "Половина скорости";
			// 
			// toolStripMenuItem40
			// 
			this.toolStripMenuItem40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem40.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem40.Name = "toolStripMenuItem40";
			this.toolStripMenuItem40.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem40.Text = "Выключить";
			// 
			// toolStripMenuItem29
			// 
			this.toolStripMenuItem29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem29.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem36,
            this.toolStripMenuItem35,
            this.toolStripMenuItem38});
			this.toolStripMenuItem29.Enabled = false;
			this.toolStripMenuItem29.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem29.Name = "toolStripMenuItem29";
			this.toolStripMenuItem29.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem29.Text = "Мотор 4";
			// 
			// toolStripMenuItem36
			// 
			this.toolStripMenuItem36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem36.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem36.Name = "toolStripMenuItem36";
			this.toolStripMenuItem36.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem36.Text = "Включить";
			// 
			// toolStripMenuItem35
			// 
			this.toolStripMenuItem35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem35.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem35.Name = "toolStripMenuItem35";
			this.toolStripMenuItem35.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem35.Text = "Половина скорости";
			// 
			// toolStripMenuItem38
			// 
			this.toolStripMenuItem38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem38.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem38.Name = "toolStripMenuItem38";
			this.toolStripMenuItem38.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem38.Text = "Выключить";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton3
			// 
			this.toolStripDropDownButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem22});
			this.toolStripDropDownButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton3.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
			this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			this.toolStripDropDownButton3.ShowDropDownArrow = false;
			this.toolStripDropDownButton3.Size = new System.Drawing.Size(81, 23);
			this.toolStripDropDownButton3.Text = "Помощь";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem1.Text = "О программе";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem22
			// 
			this.toolStripMenuItem22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem22.Enabled = false;
			this.toolStripMenuItem22.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem22.Name = "toolStripMenuItem22";
			this.toolStripMenuItem22.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem22.Text = "Помощь";
			this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// timer1
			// 
			this.timer1.Interval = 16;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// guna2TrackBar1
			// 
			this.guna2TrackBar1.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar1.Enabled = false;
			this.guna2TrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar1.LargeChange = 4;
			this.guna2TrackBar1.Location = new System.Drawing.Point(191, 22);
			this.guna2TrackBar1.Maximum = 1023;
			this.guna2TrackBar1.Name = "guna2TrackBar1";
			this.guna2TrackBar1.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar1.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar1.TabIndex = 2;
			this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar1.Value = 0;
			this.guna2TrackBar1.Visible = false;
			this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.guna2TrackBar3);
			this.groupBox1.Controls.Add(this.guna2TrackBar4);
			this.groupBox1.Controls.Add(this.guna2TrackBar2);
			this.groupBox1.Controls.Add(this.guna2TrackBar1);
			this.groupBox1.Enabled = false;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 143);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Освещение";
			this.groupBox1.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(6, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Освещение 4";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(6, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Освещение 3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Освещение 2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Освещение 1";
			// 
			// guna2TrackBar3
			// 
			this.guna2TrackBar3.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar3.Enabled = false;
			this.guna2TrackBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar3.LargeChange = 4;
			this.guna2TrackBar3.Location = new System.Drawing.Point(191, 109);
			this.guna2TrackBar3.Maximum = 1023;
			this.guna2TrackBar3.Name = "guna2TrackBar3";
			this.guna2TrackBar3.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar3.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar3.TabIndex = 5;
			this.guna2TrackBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar3.Value = 0;
			this.guna2TrackBar3.Visible = false;
			// 
			// guna2TrackBar4
			// 
			this.guna2TrackBar4.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar4.Enabled = false;
			this.guna2TrackBar4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar4.LargeChange = 4;
			this.guna2TrackBar4.Location = new System.Drawing.Point(191, 80);
			this.guna2TrackBar4.Maximum = 1023;
			this.guna2TrackBar4.Name = "guna2TrackBar4";
			this.guna2TrackBar4.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar4.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar4.TabIndex = 4;
			this.guna2TrackBar4.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar4.Value = 0;
			this.guna2TrackBar4.Visible = false;
			// 
			// guna2TrackBar2
			// 
			this.guna2TrackBar2.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar2.Enabled = false;
			this.guna2TrackBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar2.LargeChange = 4;
			this.guna2TrackBar2.Location = new System.Drawing.Point(191, 51);
			this.guna2TrackBar2.Maximum = 1023;
			this.guna2TrackBar2.Name = "guna2TrackBar2";
			this.guna2TrackBar2.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar2.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar2.TabIndex = 3;
			this.guna2TrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar2.Value = 0;
			this.guna2TrackBar2.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.guna2NumericUpDown2);
			this.groupBox2.Controls.Add(this.guna2NumericUpDown1);
			this.groupBox2.Controls.Add(this.guna2Button1);
			this.groupBox2.Enabled = false;
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(12, 178);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(394, 83);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Спикер";
			this.groupBox2.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(104, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 19);
			this.label6.TabIndex = 11;
			this.label6.Text = "Время (в мс)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(6, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Частота";
			// 
			// guna2NumericUpDown2
			// 
			this.guna2NumericUpDown2.BackColor = System.Drawing.Color.Transparent;
			this.guna2NumericUpDown2.BorderColor = System.Drawing.Color.Transparent;
			this.guna2NumericUpDown2.BorderRadius = 8;
			this.guna2NumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2NumericUpDown2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2NumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2NumericUpDown2.ForeColor = System.Drawing.Color.Black;
			this.guna2NumericUpDown2.Location = new System.Drawing.Point(120, 49);
			this.guna2NumericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.guna2NumericUpDown2.Name = "guna2NumericUpDown2";
			this.guna2NumericUpDown2.Size = new System.Drawing.Size(80, 24);
			this.guna2NumericUpDown2.TabIndex = 2;
			this.guna2NumericUpDown2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2NumericUpDown2.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
			// 
			// guna2NumericUpDown1
			// 
			this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
			this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.Transparent;
			this.guna2NumericUpDown1.BorderRadius = 8;
			this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2NumericUpDown1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.Black;
			this.guna2NumericUpDown1.Location = new System.Drawing.Point(10, 49);
			this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
			this.guna2NumericUpDown1.Size = new System.Drawing.Size(80, 24);
			this.guna2NumericUpDown1.TabIndex = 1;
			this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2NumericUpDown1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 16;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(222, 23);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(166, 50);
			this.guna2Button1.TabIndex = 0;
			this.guna2Button1.Text = "Пищим";
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.guna2TrackBar8);
			this.groupBox3.Controls.Add(this.guna2TrackBar7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.guna2TrackBar6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.guna2TrackBar5);
			this.groupBox3.Enabled = false;
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(12, 267);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(394, 145);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Электродвигатели и электромоторы";
			this.groupBox3.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(6, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Мотор 3";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(6, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(90, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Мотор 4";
			// 
			// guna2TrackBar8
			// 
			this.guna2TrackBar8.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar8.Enabled = false;
			this.guna2TrackBar8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar8.LargeChange = 4;
			this.guna2TrackBar8.Location = new System.Drawing.Point(191, 112);
			this.guna2TrackBar8.Maximum = 1023;
			this.guna2TrackBar8.Name = "guna2TrackBar8";
			this.guna2TrackBar8.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar8.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar8.TabIndex = 17;
			this.guna2TrackBar8.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar8.Value = 0;
			this.guna2TrackBar8.Visible = false;
			// 
			// guna2TrackBar7
			// 
			this.guna2TrackBar7.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar7.Enabled = false;
			this.guna2TrackBar7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar7.LargeChange = 4;
			this.guna2TrackBar7.Location = new System.Drawing.Point(191, 83);
			this.guna2TrackBar7.Maximum = 1023;
			this.guna2TrackBar7.Name = "guna2TrackBar7";
			this.guna2TrackBar7.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar7.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar7.TabIndex = 16;
			this.guna2TrackBar7.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar7.Value = 0;
			this.guna2TrackBar7.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(6, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Мотор 2";
			// 
			// guna2TrackBar6
			// 
			this.guna2TrackBar6.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar6.Enabled = false;
			this.guna2TrackBar6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar6.LargeChange = 4;
			this.guna2TrackBar6.Location = new System.Drawing.Point(191, 55);
			this.guna2TrackBar6.Maximum = 1023;
			this.guna2TrackBar6.Name = "guna2TrackBar6";
			this.guna2TrackBar6.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar6.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar6.TabIndex = 9;
			this.guna2TrackBar6.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar6.Value = 0;
			this.guna2TrackBar6.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(6, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Мотор 1";
			// 
			// guna2TrackBar5
			// 
			this.guna2TrackBar5.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar5.Enabled = false;
			this.guna2TrackBar5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar5.LargeChange = 4;
			this.guna2TrackBar5.Location = new System.Drawing.Point(191, 26);
			this.guna2TrackBar5.Maximum = 1023;
			this.guna2TrackBar5.Name = "guna2TrackBar5";
			this.guna2TrackBar5.Size = new System.Drawing.Size(197, 23);
			this.guna2TrackBar5.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar5.TabIndex = 7;
			this.guna2TrackBar5.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar5.Value = 0;
			this.guna2TrackBar5.Visible = false;
			this.guna2TrackBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar5_Scroll);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.guna2TrackBar9);
			this.groupBox4.Controls.Add(this.guna2TrackBar10);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.guna2TrackBar11);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.guna2TrackBar12);
			this.groupBox4.Enabled = false;
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(412, 29);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(394, 143);
			this.groupBox4.TabIndex = 20;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Сервоприводы";
			this.groupBox4.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(6, 83);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(157, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Сервопривод 3";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(6, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(157, 23);
			this.label12.TabIndex = 18;
			this.label12.Text = "Сервопривод 4";
			// 
			// guna2TrackBar9
			// 
			this.guna2TrackBar9.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar9.Enabled = false;
			this.guna2TrackBar9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar9.LargeChange = 4;
			this.guna2TrackBar9.Location = new System.Drawing.Point(202, 112);
			this.guna2TrackBar9.Maximum = 180;
			this.guna2TrackBar9.Name = "guna2TrackBar9";
			this.guna2TrackBar9.Size = new System.Drawing.Size(186, 23);
			this.guna2TrackBar9.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar9.TabIndex = 17;
			this.guna2TrackBar9.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar9.Value = 0;
			this.guna2TrackBar9.Visible = false;
			// 
			// guna2TrackBar10
			// 
			this.guna2TrackBar10.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar10.Enabled = false;
			this.guna2TrackBar10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar10.LargeChange = 4;
			this.guna2TrackBar10.Location = new System.Drawing.Point(202, 83);
			this.guna2TrackBar10.Maximum = 180;
			this.guna2TrackBar10.Name = "guna2TrackBar10";
			this.guna2TrackBar10.Size = new System.Drawing.Size(186, 23);
			this.guna2TrackBar10.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar10.TabIndex = 16;
			this.guna2TrackBar10.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar10.Value = 0;
			this.guna2TrackBar10.Visible = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(6, 55);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(157, 23);
			this.label13.TabIndex = 10;
			this.label13.Text = "Сервопривод 2";
			// 
			// guna2TrackBar11
			// 
			this.guna2TrackBar11.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar11.Enabled = false;
			this.guna2TrackBar11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar11.LargeChange = 4;
			this.guna2TrackBar11.Location = new System.Drawing.Point(202, 55);
			this.guna2TrackBar11.Maximum = 180;
			this.guna2TrackBar11.Name = "guna2TrackBar11";
			this.guna2TrackBar11.Size = new System.Drawing.Size(186, 23);
			this.guna2TrackBar11.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar11.TabIndex = 9;
			this.guna2TrackBar11.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar11.Value = 0;
			this.guna2TrackBar11.Visible = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(6, 26);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(157, 23);
			this.label14.TabIndex = 8;
			this.label14.Text = "Сервопривод 1";
			// 
			// guna2TrackBar12
			// 
			this.guna2TrackBar12.BackColor = System.Drawing.Color.Transparent;
			this.guna2TrackBar12.Enabled = false;
			this.guna2TrackBar12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2TrackBar12.LargeChange = 4;
			this.guna2TrackBar12.Location = new System.Drawing.Point(202, 26);
			this.guna2TrackBar12.Maximum = 180;
			this.guna2TrackBar12.Name = "guna2TrackBar12";
			this.guna2TrackBar12.Size = new System.Drawing.Size(186, 23);
			this.guna2TrackBar12.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.guna2TrackBar12.TabIndex = 7;
			this.guna2TrackBar12.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2TrackBar12.Value = 0;
			this.guna2TrackBar12.Visible = false;
			this.guna2TrackBar12.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar12_Scroll);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label15.Enabled = false;
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(577, 413);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(143, 23);
			this.label15.TabIndex = 21;
			this.label15.Text = "Версия 0.0.0.0";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label15.Visible = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Smart Home Controller";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem49,
            this.toolStripMenuItem50});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
			// 
			// toolStripMenuItem49
			// 
			this.toolStripMenuItem49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem49.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem49.Name = "toolStripMenuItem49";
			this.toolStripMenuItem49.Size = new System.Drawing.Size(135, 22);
			this.toolStripMenuItem49.Text = "Развернуть";
			this.toolStripMenuItem49.Click += new System.EventHandler(this.toolStripMenuItem49_Click);
			// 
			// toolStripMenuItem50
			// 
			this.toolStripMenuItem50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem50.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem50.Name = "toolStripMenuItem50";
			this.toolStripMenuItem50.Size = new System.Drawing.Size(135, 22);
			this.toolStripMenuItem50.Text = "Закрыть";
			this.toolStripMenuItem50.Click += new System.EventHandler(this.toolStripMenuItem50_Click);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 512;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox5.Controls.Add(this.guna2Button14);
			this.groupBox5.Controls.Add(this.guna2Button15);
			this.groupBox5.Controls.Add(this.guna2Button12);
			this.groupBox5.Controls.Add(this.guna2Button13);
			this.groupBox5.Controls.Add(this.guna2Button10);
			this.groupBox5.Controls.Add(this.guna2Button11);
			this.groupBox5.Controls.Add(this.guna2Button8);
			this.groupBox5.Controls.Add(this.guna2Button9);
			this.groupBox5.Controls.Add(this.guna2Button6);
			this.groupBox5.Controls.Add(this.guna2Button7);
			this.groupBox5.Controls.Add(this.guna2Button4);
			this.groupBox5.Controls.Add(this.guna2Button5);
			this.groupBox5.Controls.Add(this.guna2Button3);
			this.groupBox5.Controls.Add(this.guna2Button2);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.Controls.Add(this.label20);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Controls.Add(this.label17);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Enabled = false;
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox5.ForeColor = System.Drawing.Color.White;
			this.groupBox5.Location = new System.Drawing.Point(412, 178);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(394, 232);
			this.groupBox5.TabIndex = 21;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Выключатель";
			this.groupBox5.Visible = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(6, 79);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(71, 23);
			this.label16.TabIndex = 19;
			this.label16.Text = "Реле 3";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(6, 108);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(71, 23);
			this.label17.TabIndex = 18;
			this.label17.Text = "Реле 4";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label18.Location = new System.Drawing.Point(6, 51);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(71, 23);
			this.label18.TabIndex = 10;
			this.label18.Text = "Реле 2";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(6, 22);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(71, 23);
			this.label19.TabIndex = 8;
			this.label19.Text = "Реле 1";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label20.Location = new System.Drawing.Point(6, 137);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(71, 23);
			this.label20.TabIndex = 23;
			this.label20.Text = "Реле 5";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label21.Location = new System.Drawing.Point(6, 166);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(71, 23);
			this.label21.TabIndex = 22;
			this.label21.Text = "Реле 6";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label22.Location = new System.Drawing.Point(6, 195);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(71, 23);
			this.label22.TabIndex = 25;
			this.label22.Text = "Реле 7";
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 8;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(202, 22);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(93, 23);
			this.guna2Button2.TabIndex = 26;
			this.guna2Button2.Text = "ВКЛ";
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
			// 
			// guna2Button3
			// 
			this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 8;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Location = new System.Drawing.Point(295, 22);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(93, 23);
			this.guna2Button3.TabIndex = 27;
			this.guna2Button3.Text = "ВЫКЛ";
			this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
			// 
			// guna2Button4
			// 
			this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button4.BorderRadius = 8;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Location = new System.Drawing.Point(295, 51);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new System.Drawing.Size(93, 23);
			this.guna2Button4.TabIndex = 29;
			this.guna2Button4.Text = "ВЫКЛ";
			this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
			// 
			// guna2Button5
			// 
			this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button5.BorderRadius = 8;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.Location = new System.Drawing.Point(202, 51);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new System.Drawing.Size(93, 23);
			this.guna2Button5.TabIndex = 28;
			this.guna2Button5.Text = "ВКЛ";
			this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
			// 
			// guna2Button6
			// 
			this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button6.BorderRadius = 8;
			this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button6.ForeColor = System.Drawing.Color.White;
			this.guna2Button6.Location = new System.Drawing.Point(295, 79);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new System.Drawing.Size(93, 23);
			this.guna2Button6.TabIndex = 31;
			this.guna2Button6.Text = "ВЫКЛ";
			this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
			// 
			// guna2Button7
			// 
			this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button7.BorderRadius = 8;
			this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button7.ForeColor = System.Drawing.Color.White;
			this.guna2Button7.Location = new System.Drawing.Point(202, 79);
			this.guna2Button7.Name = "guna2Button7";
			this.guna2Button7.Size = new System.Drawing.Size(93, 23);
			this.guna2Button7.TabIndex = 30;
			this.guna2Button7.Text = "ВКЛ";
			this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
			// 
			// guna2Button8
			// 
			this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button8.BorderRadius = 8;
			this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button8.ForeColor = System.Drawing.Color.White;
			this.guna2Button8.Location = new System.Drawing.Point(295, 108);
			this.guna2Button8.Name = "guna2Button8";
			this.guna2Button8.Size = new System.Drawing.Size(93, 23);
			this.guna2Button8.TabIndex = 33;
			this.guna2Button8.Text = "ВЫКЛ";
			this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
			// 
			// guna2Button9
			// 
			this.guna2Button9.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button9.BorderRadius = 8;
			this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button9.ForeColor = System.Drawing.Color.White;
			this.guna2Button9.Location = new System.Drawing.Point(202, 108);
			this.guna2Button9.Name = "guna2Button9";
			this.guna2Button9.Size = new System.Drawing.Size(93, 23);
			this.guna2Button9.TabIndex = 32;
			this.guna2Button9.Text = "ВКЛ";
			this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
			// 
			// guna2Button10
			// 
			this.guna2Button10.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button10.BorderRadius = 8;
			this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button10.ForeColor = System.Drawing.Color.White;
			this.guna2Button10.Location = new System.Drawing.Point(295, 137);
			this.guna2Button10.Name = "guna2Button10";
			this.guna2Button10.Size = new System.Drawing.Size(93, 23);
			this.guna2Button10.TabIndex = 35;
			this.guna2Button10.Text = "ВЫКЛ";
			this.guna2Button10.Click += new System.EventHandler(this.guna2Button10_Click);
			// 
			// guna2Button11
			// 
			this.guna2Button11.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button11.BorderRadius = 8;
			this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button11.ForeColor = System.Drawing.Color.White;
			this.guna2Button11.Location = new System.Drawing.Point(202, 137);
			this.guna2Button11.Name = "guna2Button11";
			this.guna2Button11.Size = new System.Drawing.Size(93, 23);
			this.guna2Button11.TabIndex = 34;
			this.guna2Button11.Text = "ВКЛ";
			this.guna2Button11.Click += new System.EventHandler(this.guna2Button11_Click);
			// 
			// guna2Button12
			// 
			this.guna2Button12.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button12.BorderRadius = 8;
			this.guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button12.ForeColor = System.Drawing.Color.White;
			this.guna2Button12.Location = new System.Drawing.Point(295, 166);
			this.guna2Button12.Name = "guna2Button12";
			this.guna2Button12.Size = new System.Drawing.Size(93, 23);
			this.guna2Button12.TabIndex = 37;
			this.guna2Button12.Text = "ВЫКЛ";
			this.guna2Button12.Click += new System.EventHandler(this.guna2Button12_Click);
			// 
			// guna2Button13
			// 
			this.guna2Button13.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button13.BorderRadius = 8;
			this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button13.ForeColor = System.Drawing.Color.White;
			this.guna2Button13.Location = new System.Drawing.Point(202, 166);
			this.guna2Button13.Name = "guna2Button13";
			this.guna2Button13.Size = new System.Drawing.Size(93, 23);
			this.guna2Button13.TabIndex = 36;
			this.guna2Button13.Text = "ВКЛ";
			this.guna2Button13.Click += new System.EventHandler(this.guna2Button13_Click);
			// 
			// guna2Button14
			// 
			this.guna2Button14.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button14.BorderRadius = 8;
			this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button14.ForeColor = System.Drawing.Color.White;
			this.guna2Button14.Location = new System.Drawing.Point(295, 195);
			this.guna2Button14.Name = "guna2Button14";
			this.guna2Button14.Size = new System.Drawing.Size(93, 23);
			this.guna2Button14.TabIndex = 39;
			this.guna2Button14.Text = "ВЫКЛ";
			this.guna2Button14.Click += new System.EventHandler(this.guna2Button14_Click);
			// 
			// guna2Button15
			// 
			this.guna2Button15.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button15.BorderRadius = 8;
			this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
			this.guna2Button15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2Button15.ForeColor = System.Drawing.Color.White;
			this.guna2Button15.Location = new System.Drawing.Point(202, 195);
			this.guna2Button15.Name = "guna2Button15";
			this.guna2Button15.Size = new System.Drawing.Size(93, 23);
			this.guna2Button15.TabIndex = 38;
			this.guna2Button15.Text = "ВКЛ";
			this.guna2Button15.Click += new System.EventHandler(this.guna2Button15_Click);
			// 
			// toolStripDropDownButton6
			// 
			this.toolStripDropDownButton6.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem51,
            this.toolStripMenuItem55,
            this.toolStripMenuItem59,
            this.toolStripMenuItem63});
			this.toolStripDropDownButton6.Enabled = false;
			this.toolStripDropDownButton6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton6.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
			this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
			this.toolStripDropDownButton6.ShowDropDownArrow = false;
			this.toolStripDropDownButton6.Size = new System.Drawing.Size(125, 23);
			this.toolStripDropDownButton6.Text = "Сервопривод";
			this.toolStripDropDownButton6.ToolTipText = "Пищалка";
			this.toolStripDropDownButton6.Visible = false;
			// 
			// toolStripMenuItem51
			// 
			this.toolStripMenuItem51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem51.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem67,
            this.toolStripMenuItem52,
            this.toolStripMenuItem53,
            this.toolStripMenuItem68,
            this.toolStripMenuItem54});
			this.toolStripMenuItem51.Enabled = false;
			this.toolStripMenuItem51.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem51.Name = "toolStripMenuItem51";
			this.toolStripMenuItem51.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem51.Text = "Сервопривод 1";
			// 
			// toolStripMenuItem52
			// 
			this.toolStripMenuItem52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem52.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem52.Name = "toolStripMenuItem52";
			this.toolStripMenuItem52.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem52.Text = "90°";
			// 
			// toolStripMenuItem53
			// 
			this.toolStripMenuItem53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem53.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem53.Name = "toolStripMenuItem53";
			this.toolStripMenuItem53.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem53.Text = "180°";
			// 
			// toolStripMenuItem54
			// 
			this.toolStripMenuItem54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem54.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem54.Name = "toolStripMenuItem54";
			this.toolStripMenuItem54.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem54.Text = "360°";
			// 
			// toolStripMenuItem55
			// 
			this.toolStripMenuItem55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem55.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem69,
            this.toolStripMenuItem70,
            this.toolStripMenuItem71,
            this.toolStripMenuItem72,
            this.toolStripMenuItem73});
			this.toolStripMenuItem55.Enabled = false;
			this.toolStripMenuItem55.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem55.Name = "toolStripMenuItem55";
			this.toolStripMenuItem55.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem55.Text = "Сервопривод 2";
			// 
			// toolStripMenuItem59
			// 
			this.toolStripMenuItem59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem59.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem56,
            this.toolStripMenuItem57,
            this.toolStripMenuItem58,
            this.toolStripMenuItem74,
            this.toolStripMenuItem75});
			this.toolStripMenuItem59.Enabled = false;
			this.toolStripMenuItem59.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem59.Name = "toolStripMenuItem59";
			this.toolStripMenuItem59.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem59.Text = "Сервопривод 3";
			// 
			// toolStripMenuItem63
			// 
			this.toolStripMenuItem63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem63.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem60,
            this.toolStripMenuItem61,
            this.toolStripMenuItem62,
            this.toolStripMenuItem65,
            this.toolStripMenuItem66});
			this.toolStripMenuItem63.Enabled = false;
			this.toolStripMenuItem63.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem63.Name = "toolStripMenuItem63";
			this.toolStripMenuItem63.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem63.Text = "Сервопривод 4";
			// 
			// toolStripMenuItem67
			// 
			this.toolStripMenuItem67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem67.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem67.Name = "toolStripMenuItem67";
			this.toolStripMenuItem67.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem67.Text = "0°";
			// 
			// toolStripMenuItem68
			// 
			this.toolStripMenuItem68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem68.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem68.Name = "toolStripMenuItem68";
			this.toolStripMenuItem68.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem68.Text = "270°";
			// 
			// toolStripMenuItem69
			// 
			this.toolStripMenuItem69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem69.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem69.Name = "toolStripMenuItem69";
			this.toolStripMenuItem69.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem69.Text = "0°";
			// 
			// toolStripMenuItem70
			// 
			this.toolStripMenuItem70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem70.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem70.Name = "toolStripMenuItem70";
			this.toolStripMenuItem70.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem70.Text = "90°";
			// 
			// toolStripMenuItem71
			// 
			this.toolStripMenuItem71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem71.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem71.Name = "toolStripMenuItem71";
			this.toolStripMenuItem71.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem71.Text = "180°";
			// 
			// toolStripMenuItem72
			// 
			this.toolStripMenuItem72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem72.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem72.Name = "toolStripMenuItem72";
			this.toolStripMenuItem72.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem72.Text = "270°";
			// 
			// toolStripMenuItem73
			// 
			this.toolStripMenuItem73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem73.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem73.Name = "toolStripMenuItem73";
			this.toolStripMenuItem73.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem73.Text = "360°";
			// 
			// toolStripMenuItem56
			// 
			this.toolStripMenuItem56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem56.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem56.Name = "toolStripMenuItem56";
			this.toolStripMenuItem56.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem56.Text = "0°";
			// 
			// toolStripMenuItem57
			// 
			this.toolStripMenuItem57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem57.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem57.Name = "toolStripMenuItem57";
			this.toolStripMenuItem57.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem57.Text = "90°";
			// 
			// toolStripMenuItem58
			// 
			this.toolStripMenuItem58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem58.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem58.Name = "toolStripMenuItem58";
			this.toolStripMenuItem58.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem58.Text = "180°";
			// 
			// toolStripMenuItem74
			// 
			this.toolStripMenuItem74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem74.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem74.Name = "toolStripMenuItem74";
			this.toolStripMenuItem74.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem74.Text = "270°";
			// 
			// toolStripMenuItem75
			// 
			this.toolStripMenuItem75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem75.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem75.Name = "toolStripMenuItem75";
			this.toolStripMenuItem75.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem75.Text = "360°";
			// 
			// toolStripMenuItem60
			// 
			this.toolStripMenuItem60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem60.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem60.Name = "toolStripMenuItem60";
			this.toolStripMenuItem60.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem60.Text = "0°";
			// 
			// toolStripMenuItem61
			// 
			this.toolStripMenuItem61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem61.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem61.Name = "toolStripMenuItem61";
			this.toolStripMenuItem61.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem61.Text = "90°";
			// 
			// toolStripMenuItem62
			// 
			this.toolStripMenuItem62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem62.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem62.Name = "toolStripMenuItem62";
			this.toolStripMenuItem62.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem62.Text = "180°";
			// 
			// toolStripMenuItem65
			// 
			this.toolStripMenuItem65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem65.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem65.Name = "toolStripMenuItem65";
			this.toolStripMenuItem65.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem65.Text = "270°";
			// 
			// toolStripMenuItem66
			// 
			this.toolStripMenuItem66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem66.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem66.Name = "toolStripMenuItem66";
			this.toolStripMenuItem66.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem66.Text = "360°";
			// 
			// toolStripDropDownButton7
			// 
			this.toolStripDropDownButton7.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem84,
            this.toolStripMenuItem87,
            this.toolStripMenuItem90,
            this.toolStripMenuItem93,
            this.toolStripMenuItem81,
            this.toolStripMenuItem77,
            this.toolStripMenuItem64});
			this.toolStripDropDownButton7.Enabled = false;
			this.toolStripDropDownButton7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton7.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton7.Image")));
			this.toolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton7.Name = "toolStripDropDownButton7";
			this.toolStripDropDownButton7.ShowDropDownArrow = false;
			this.toolStripDropDownButton7.Size = new System.Drawing.Size(121, 23);
			this.toolStripDropDownButton7.Text = "Выключатель";
			this.toolStripDropDownButton7.ToolTipText = "Пищалка";
			this.toolStripDropDownButton7.Visible = false;
			// 
			// toolStripMenuItem64
			// 
			this.toolStripMenuItem64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem64.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem76,
            this.toolStripMenuItem78});
			this.toolStripMenuItem64.Enabled = false;
			this.toolStripMenuItem64.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem64.Name = "toolStripMenuItem64";
			this.toolStripMenuItem64.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem64.Text = "Реле 7";
			// 
			// toolStripMenuItem76
			// 
			this.toolStripMenuItem76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem76.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem76.Name = "toolStripMenuItem76";
			this.toolStripMenuItem76.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem76.Text = "Включить";
			// 
			// toolStripMenuItem78
			// 
			this.toolStripMenuItem78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem78.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem78.Name = "toolStripMenuItem78";
			this.toolStripMenuItem78.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem78.Text = "Выключить";
			// 
			// toolStripMenuItem77
			// 
			this.toolStripMenuItem77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem77.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem79,
            this.toolStripMenuItem80});
			this.toolStripMenuItem77.Enabled = false;
			this.toolStripMenuItem77.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem77.Name = "toolStripMenuItem77";
			this.toolStripMenuItem77.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem77.Text = "Реле 6";
			// 
			// toolStripMenuItem79
			// 
			this.toolStripMenuItem79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem79.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem79.Name = "toolStripMenuItem79";
			this.toolStripMenuItem79.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem79.Text = "Включить";
			// 
			// toolStripMenuItem80
			// 
			this.toolStripMenuItem80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem80.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem80.Name = "toolStripMenuItem80";
			this.toolStripMenuItem80.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem80.Text = "Выключить";
			// 
			// toolStripMenuItem81
			// 
			this.toolStripMenuItem81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem81.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem82,
            this.toolStripMenuItem83});
			this.toolStripMenuItem81.Enabled = false;
			this.toolStripMenuItem81.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem81.Name = "toolStripMenuItem81";
			this.toolStripMenuItem81.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem81.Text = "Реле 5";
			// 
			// toolStripMenuItem82
			// 
			this.toolStripMenuItem82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem82.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem82.Name = "toolStripMenuItem82";
			this.toolStripMenuItem82.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem82.Text = "Включить";
			// 
			// toolStripMenuItem83
			// 
			this.toolStripMenuItem83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem83.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem83.Name = "toolStripMenuItem83";
			this.toolStripMenuItem83.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem83.Text = "Выключить";
			// 
			// toolStripMenuItem84
			// 
			this.toolStripMenuItem84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem84.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem85,
            this.toolStripMenuItem86});
			this.toolStripMenuItem84.Enabled = false;
			this.toolStripMenuItem84.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem84.Name = "toolStripMenuItem84";
			this.toolStripMenuItem84.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem84.Text = "Реле 1";
			// 
			// toolStripMenuItem85
			// 
			this.toolStripMenuItem85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem85.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem85.Name = "toolStripMenuItem85";
			this.toolStripMenuItem85.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem85.Text = "Включить";
			// 
			// toolStripMenuItem86
			// 
			this.toolStripMenuItem86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem86.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem86.Name = "toolStripMenuItem86";
			this.toolStripMenuItem86.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem86.Text = "Выключить";
			// 
			// toolStripMenuItem87
			// 
			this.toolStripMenuItem87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem87.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem88,
            this.toolStripMenuItem89});
			this.toolStripMenuItem87.Enabled = false;
			this.toolStripMenuItem87.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem87.Name = "toolStripMenuItem87";
			this.toolStripMenuItem87.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem87.Text = "Реле 2";
			// 
			// toolStripMenuItem88
			// 
			this.toolStripMenuItem88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem88.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem88.Name = "toolStripMenuItem88";
			this.toolStripMenuItem88.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem88.Text = "Включить";
			// 
			// toolStripMenuItem89
			// 
			this.toolStripMenuItem89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem89.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem89.Name = "toolStripMenuItem89";
			this.toolStripMenuItem89.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem89.Text = "Выключить";
			// 
			// toolStripMenuItem90
			// 
			this.toolStripMenuItem90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem90.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem91,
            this.toolStripMenuItem92});
			this.toolStripMenuItem90.Enabled = false;
			this.toolStripMenuItem90.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem90.Name = "toolStripMenuItem90";
			this.toolStripMenuItem90.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem90.Text = "Реле 3";
			// 
			// toolStripMenuItem91
			// 
			this.toolStripMenuItem91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem91.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem91.Name = "toolStripMenuItem91";
			this.toolStripMenuItem91.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem91.Text = "Включить";
			// 
			// toolStripMenuItem92
			// 
			this.toolStripMenuItem92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem92.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem92.Name = "toolStripMenuItem92";
			this.toolStripMenuItem92.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem92.Text = "Выключить";
			// 
			// toolStripMenuItem93
			// 
			this.toolStripMenuItem93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem93.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem94,
            this.toolStripMenuItem95});
			this.toolStripMenuItem93.Enabled = false;
			this.toolStripMenuItem93.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem93.Name = "toolStripMenuItem93";
			this.toolStripMenuItem93.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem93.Text = "Реле 4";
			// 
			// toolStripMenuItem94
			// 
			this.toolStripMenuItem94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem94.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem94.Name = "toolStripMenuItem94";
			this.toolStripMenuItem94.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem94.Text = "Включить";
			// 
			// toolStripMenuItem95
			// 
			this.toolStripMenuItem95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem95.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem95.Name = "toolStripMenuItem95";
			this.toolStripMenuItem95.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem95.Text = "Выключить";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(812, 437);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление системой умного дома";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem параметрыПодключенияToolStripMenuItem;
        private ToolStripMenuItem отключениеОтКонтроллераToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cOMПортToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem скоростьПередачиToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox2;
        private SerialPort serialPort1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem toolStripMenuItem1;
        private Timer timer1;
		private ToolStripDropDownButton toolStripDropDownButton2;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
		private GroupBox groupBox1;
		private Label label2;
		private Label label1;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar3;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar4;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
		private Label label3;
		private Label label4;
		private GroupBox groupBox2;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
		private Label label6;
		private Label label5;
		private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
		private ToolStripDropDownButton toolStripDropDownButton4;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripMenuItem toolStripMenuItem4;
		private ToolStripMenuItem toolStripMenuItem5;
		private ToolStripMenuItem toolStripMenuItem6;
		private ToolStripMenuItem toolStripMenuItem7;
		private ToolStripMenuItem toolStripMenuItem8;
		private ToolStripMenuItem toolStripMenuItem9;
		private ToolStripMenuItem toolStripMenuItem10;
		private ToolStripMenuItem toolStripMenuItem11;
		private ToolStripMenuItem toolStripMenuItem12;
		private ToolStripMenuItem toolStripMenuItem13;
		private ToolStripMenuItem toolStripMenuItem17;
		private ToolStripMenuItem toolStripMenuItem21;
		private ToolStripMenuItem toolStripMenuItem20;
		private ToolStripMenuItem toolStripMenuItem19;
		private ToolStripMenuItem toolStripMenuItem18;
		private ToolStripMenuItem toolStripMenuItem14;
		private ToolStripMenuItem toolStripMenuItem16;
		private ToolStripMenuItem toolStripMenuItem15;
		private ToolStripMenuItem toolStripMenuItem22;
		private ToolStripMenuItem toolStripMenuItem23;
		private ToolStripMenuItem toolStripMenuItem25;
		private ToolStripMenuItem toolStripMenuItem26;
		private ToolStripMenuItem toolStripMenuItem27;
		private ToolStripMenuItem toolStripMenuItem28;
		private ToolStripMenuItem toolStripMenuItem24;
		private ToolStripMenuItem toolStripMenuItem30;
		private ToolStripMenuItem toolStripMenuItem31;
		private ToolStripMenuItem toolStripMenuItem32;
		private ToolStripMenuItem toolStripMenuItem33;
		private GroupBox groupBox3;
		private Label label7;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar5;
		private Label label9;
		private Label label10;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar8;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar7;
		private Label label8;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar6;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private GroupBox groupBox4;
		private Label label11;
		private Label label12;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar9;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar10;
		private Label label13;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar11;
		private Label label14;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar12;
		private Label label15;
		private ToolStripDropDownButton toolStripDropDownButton5;
		private ToolStripMenuItem toolStripMenuItem29;
		private ToolStripMenuItem toolStripMenuItem45;
		private ToolStripMenuItem toolStripMenuItem46;
		private ToolStripMenuItem toolStripMenuItem47;
		private ToolStripMenuItem toolStripMenuItem48;
		private ToolStripMenuItem toolStripMenuItem41;
		private ToolStripMenuItem toolStripMenuItem42;
		private ToolStripMenuItem toolStripMenuItem43;
		private ToolStripMenuItem toolStripMenuItem44;
		private ToolStripMenuItem toolStripMenuItem34;
		private ToolStripMenuItem toolStripMenuItem37;
		private ToolStripMenuItem toolStripMenuItem39;
		private ToolStripMenuItem toolStripMenuItem40;
		private ToolStripMenuItem toolStripMenuItem36;
		private ToolStripMenuItem toolStripMenuItem35;
		private ToolStripMenuItem toolStripMenuItem38;
		private NotifyIcon notifyIcon1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem toolStripMenuItem49;
		private ToolStripMenuItem toolStripMenuItem50;
		private Timer timer2;
		private GroupBox groupBox5;
		private Label label22;
		private Label label20;
		private Label label21;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private Guna.UI2.WinForms.Guna2Button guna2Button14;
		private Guna.UI2.WinForms.Guna2Button guna2Button15;
		private Guna.UI2.WinForms.Guna2Button guna2Button12;
		private Guna.UI2.WinForms.Guna2Button guna2Button13;
		private Guna.UI2.WinForms.Guna2Button guna2Button10;
		private Guna.UI2.WinForms.Guna2Button guna2Button11;
		private Guna.UI2.WinForms.Guna2Button guna2Button8;
		private Guna.UI2.WinForms.Guna2Button guna2Button9;
		private Guna.UI2.WinForms.Guna2Button guna2Button6;
		private Guna.UI2.WinForms.Guna2Button guna2Button7;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private Guna.UI2.WinForms.Guna2Button guna2Button5;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private ToolStripDropDownButton toolStripDropDownButton6;
		private ToolStripMenuItem toolStripMenuItem51;
		private ToolStripMenuItem toolStripMenuItem67;
		private ToolStripMenuItem toolStripMenuItem52;
		private ToolStripMenuItem toolStripMenuItem53;
		private ToolStripMenuItem toolStripMenuItem68;
		private ToolStripMenuItem toolStripMenuItem54;
		private ToolStripMenuItem toolStripMenuItem55;
		private ToolStripMenuItem toolStripMenuItem59;
		private ToolStripMenuItem toolStripMenuItem63;
		private ToolStripMenuItem toolStripMenuItem69;
		private ToolStripMenuItem toolStripMenuItem70;
		private ToolStripMenuItem toolStripMenuItem71;
		private ToolStripMenuItem toolStripMenuItem72;
		private ToolStripMenuItem toolStripMenuItem73;
		private ToolStripMenuItem toolStripMenuItem56;
		private ToolStripMenuItem toolStripMenuItem57;
		private ToolStripMenuItem toolStripMenuItem58;
		private ToolStripMenuItem toolStripMenuItem74;
		private ToolStripMenuItem toolStripMenuItem75;
		private ToolStripMenuItem toolStripMenuItem60;
		private ToolStripMenuItem toolStripMenuItem61;
		private ToolStripMenuItem toolStripMenuItem62;
		private ToolStripMenuItem toolStripMenuItem65;
		private ToolStripMenuItem toolStripMenuItem66;
		private ToolStripDropDownButton toolStripDropDownButton7;
		private ToolStripMenuItem toolStripMenuItem64;
		private ToolStripMenuItem toolStripMenuItem84;
		private ToolStripMenuItem toolStripMenuItem85;
		private ToolStripMenuItem toolStripMenuItem86;
		private ToolStripMenuItem toolStripMenuItem87;
		private ToolStripMenuItem toolStripMenuItem88;
		private ToolStripMenuItem toolStripMenuItem89;
		private ToolStripMenuItem toolStripMenuItem90;
		private ToolStripMenuItem toolStripMenuItem91;
		private ToolStripMenuItem toolStripMenuItem92;
		private ToolStripMenuItem toolStripMenuItem93;
		private ToolStripMenuItem toolStripMenuItem94;
		private ToolStripMenuItem toolStripMenuItem95;
		private ToolStripMenuItem toolStripMenuItem81;
		private ToolStripMenuItem toolStripMenuItem82;
		private ToolStripMenuItem toolStripMenuItem83;
		private ToolStripMenuItem toolStripMenuItem77;
		private ToolStripMenuItem toolStripMenuItem79;
		private ToolStripMenuItem toolStripMenuItem80;
		private ToolStripMenuItem toolStripMenuItem76;
		private ToolStripMenuItem toolStripMenuItem78;
	}
}

