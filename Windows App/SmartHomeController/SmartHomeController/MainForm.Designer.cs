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
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label15 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.guna2TrackBar9 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar10 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label13 = new System.Windows.Forms.Label();
			this.guna2TrackBar11 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label14 = new System.Windows.Forms.Label();
			this.guna2TrackBar12 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2TrackBar3 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar4 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.label22 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.materialComboBox4 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.guna2TrackBar8 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2TrackBar7 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label8 = new System.Windows.Forms.Label();
			this.guna2TrackBar6 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.guna2TrackBar5 = new Guna.UI2.WinForms.Guna2TrackBar();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton8 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem96 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem97 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem98 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem99 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton10 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem113 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem114 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem115 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem116 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem117 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem118 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem119 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem120 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem121 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem122 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem123 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem124 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem125 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem126 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem127 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem128 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem129 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem130 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton14 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem192 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem193 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem171 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem172 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem173 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem174 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem175 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem176 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem177 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem178 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem179 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem180 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem181 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem182 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem183 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem184 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem185 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem186 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem187 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem188 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem189 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem190 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem191 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton13 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem147 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem148 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem149 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem150 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem151 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem152 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem153 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem154 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem155 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem156 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem157 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem158 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem159 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem160 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem161 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem162 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem163 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem164 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem165 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem166 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem167 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem168 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem169 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem170 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton12 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem131 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem132 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem133 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem134 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem135 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem136 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem137 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem138 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem139 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem140 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem141 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem142 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem143 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem144 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem145 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem146 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton11 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem101 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem102 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem103 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem104 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem105 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem106 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem107 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem108 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem109 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem110 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem111 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem112 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton9 = new System.Windows.Forms.ToolStripDropDownButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton15 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem194 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem195 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem196 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox6 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem197 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem198 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton16 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem199 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem200 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem201 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem202 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem203 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem204 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem205 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem206 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem207 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem208 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem209 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem210 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton17 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem211 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem212 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem213 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem214 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem215 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem216 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem217 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem218 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem219 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem220 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem221 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem222 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem223 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem224 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem225 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem226 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem227 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem228 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton18 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem229 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem230 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem231 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem232 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem233 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem234 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem235 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem236 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem237 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem238 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem239 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem240 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem241 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem242 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem243 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem244 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton19 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem245 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem246 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem247 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem248 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem249 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem250 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem251 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem252 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem253 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem254 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem255 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem256 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem257 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem258 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem259 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem260 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem261 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem262 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem263 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem264 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem265 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem266 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem267 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem268 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton20 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem269 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem270 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem271 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem272 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem273 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem274 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem275 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem276 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem277 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem278 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem279 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem280 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem281 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem282 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem283 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem284 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem285 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem286 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem287 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem288 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem289 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton21 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem290 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem291 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem56 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem57 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem58 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem59 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem61 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem62 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem63 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem64 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem65 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem66 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem67 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem68 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem69 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem70 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem71 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem72 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem73 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem74 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem75 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem76 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem77 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem78 = new System.Windows.Forms.ToolStripMenuItem();
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
			this.toolStripMenuItem292 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem293 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem294 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton7 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem295 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem296 = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage0 = new System.Windows.Forms.TabPage();
			this.connect_materialButton3 = new MaterialSkin.Controls.MaterialButton();
			this.materialComboBox5 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialComboBox6 = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.materialTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
			this.toolStrip3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabPage0.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(3, 660);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1091, 24);
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
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// timer1
			// 
			this.timer1.Interval = 16;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(842, 661);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(143, 23);
			this.label15.TabIndex = 21;
			this.label15.Text = "Версия 0.0.0.0";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// materialTabControl1
			// 
			this.materialTabControl1.Controls.Add(this.tabPage0);
			this.materialTabControl1.Controls.Add(this.tabPage1);
			this.materialTabControl1.Controls.Add(this.tabPage4);
			this.materialTabControl1.Controls.Add(this.tabPage3);
			this.materialTabControl1.Controls.Add(this.tabPage2);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Multiline = true;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(1053, 517);
			this.materialTabControl1.TabIndex = 22;
			this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.toolStrip1);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1045, 491);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Освещение";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			this.groupBox4.Location = new System.Drawing.Point(416, 46);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(394, 143);
			this.groupBox4.TabIndex = 33;
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
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.materialSlider1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.guna2TrackBar3);
			this.groupBox1.Controls.Add(this.guna2TrackBar4);
			this.groupBox1.Controls.Add(this.guna2TrackBar2);
			this.groupBox1.Enabled = false;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(16, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 143);
			this.groupBox1.TabIndex = 30;
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
			// materialSlider1
			// 
			this.materialSlider1.Depth = 0;
			this.materialSlider1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.materialSlider1.ForeColor = System.Drawing.Color.White;
			this.materialSlider1.Location = new System.Drawing.Point(191, 9);
			this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSlider1.Name = "materialSlider1";
			this.materialSlider1.RangeMax = 1023;
			this.materialSlider1.ShowText = false;
			this.materialSlider1.Size = new System.Drawing.Size(197, 40);
			this.materialSlider1.TabIndex = 41;
			this.materialSlider1.Text = "materialSlider1";
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
			this.groupBox5.Location = new System.Drawing.Point(645, 253);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(394, 232);
			this.groupBox5.TabIndex = 29;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Выключатель";
			this.groupBox5.Visible = false;
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
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.materialComboBox4);
			this.tabPage2.Controls.Add(this.materialComboBox3);
			this.tabPage2.Controls.Add(this.materialComboBox2);
			this.tabPage2.Controls.Add(this.materialComboBox1);
			this.tabPage2.Controls.Add(this.materialButton2);
			this.tabPage2.Controls.Add(this.materialLabel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1045, 491);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Настройки";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// materialComboBox4
			// 
			this.materialComboBox4.AutoResize = false;
			this.materialComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox4.Depth = 0;
			this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox4.DropDownHeight = 174;
			this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox4.DropDownWidth = 121;
			this.materialComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox4.FormattingEnabled = true;
			this.materialComboBox4.IntegralHeight = false;
			this.materialComboBox4.ItemHeight = 43;
			this.materialComboBox4.Location = new System.Drawing.Point(132, 191);
			this.materialComboBox4.MaxDropDownItems = 4;
			this.materialComboBox4.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox4.Name = "materialComboBox4";
			this.materialComboBox4.Size = new System.Drawing.Size(298, 49);
			this.materialComboBox4.StartIndex = 0;
			this.materialComboBox4.TabIndex = 5;
			// 
			// materialComboBox3
			// 
			this.materialComboBox3.AutoResize = false;
			this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox3.Depth = 0;
			this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox3.DropDownHeight = 174;
			this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox3.DropDownWidth = 121;
			this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox3.FormattingEnabled = true;
			this.materialComboBox3.IntegralHeight = false;
			this.materialComboBox3.ItemHeight = 43;
			this.materialComboBox3.Location = new System.Drawing.Point(132, 136);
			this.materialComboBox3.MaxDropDownItems = 4;
			this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox3.Name = "materialComboBox3";
			this.materialComboBox3.Size = new System.Drawing.Size(298, 49);
			this.materialComboBox3.StartIndex = 0;
			this.materialComboBox3.TabIndex = 4;
			// 
			// materialComboBox2
			// 
			this.materialComboBox2.AutoResize = false;
			this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox2.Depth = 0;
			this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox2.DropDownHeight = 174;
			this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox2.DropDownWidth = 121;
			this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox2.FormattingEnabled = true;
			this.materialComboBox2.IntegralHeight = false;
			this.materialComboBox2.ItemHeight = 43;
			this.materialComboBox2.Items.AddRange(new object[] {
            "Тёмная",
            "Светлая"});
			this.materialComboBox2.Location = new System.Drawing.Point(132, 81);
			this.materialComboBox2.MaxDropDownItems = 4;
			this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox2.Name = "materialComboBox2";
			this.materialComboBox2.Size = new System.Drawing.Size(298, 49);
			this.materialComboBox2.StartIndex = 0;
			this.materialComboBox2.TabIndex = 3;
			// 
			// materialComboBox1
			// 
			this.materialComboBox1.AutoResize = false;
			this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox1.Depth = 0;
			this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox1.DropDownHeight = 174;
			this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox1.DropDownWidth = 121;
			this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox1.FormattingEnabled = true;
			this.materialComboBox1.IntegralHeight = false;
			this.materialComboBox1.ItemHeight = 43;
			this.materialComboBox1.Items.AddRange(new object[] {
            "Русский",
            "English"});
			this.materialComboBox1.Location = new System.Drawing.Point(132, 26);
			this.materialComboBox1.MaxDropDownItems = 4;
			this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox1.Name = "materialComboBox1";
			this.materialComboBox1.Size = new System.Drawing.Size(298, 49);
			this.materialComboBox1.StartIndex = 0;
			this.materialComboBox1.TabIndex = 2;
			// 
			// materialButton2
			// 
			this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButton2.Depth = 0;
			this.materialButton2.HighEmphasis = true;
			this.materialButton2.Icon = null;
			this.materialButton2.Location = new System.Drawing.Point(584, 433);
			this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton2.Name = "materialButton2";
			this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButton2.Size = new System.Drawing.Size(201, 36);
			this.materialButton2.TabIndex = 1;
			this.materialButton2.Text = "Сохранить настройки";
			this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton2.UseAccentColor = false;
			this.materialButton2.UseVisualStyleBackColor = true;
			this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.materialLabel1.Location = new System.Drawing.Point(21, 26);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(84, 19);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Освещение";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.toolStrip3);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1045, 491);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Электродвигатели";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox2);
			this.tabPage4.Controls.Add(this.toolStrip2);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1045, 491);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Спикер";
			this.tabPage4.UseVisualStyleBackColor = true;
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
			this.groupBox3.Location = new System.Drawing.Point(217, 203);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(394, 145);
			this.groupBox3.TabIndex = 33;
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
			// 
			// toolStrip2
			// 
			this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton8,
            this.toolStripSeparator3,
            this.toolStripDropDownButton9,
            this.toolStripDropDownButton10,
            this.toolStripDropDownButton11,
            this.toolStripDropDownButton12,
            this.toolStripDropDownButton13,
            this.toolStripSeparator4,
            this.toolStripDropDownButton14});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(1045, 26);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripDropDownButton8
			// 
			this.toolStripDropDownButton8.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem96,
            this.toolStripMenuItem99,
            this.toolStripMenuItem100});
			this.toolStripDropDownButton8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton8.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton8.Image")));
			this.toolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton8.Name = "toolStripDropDownButton8";
			this.toolStripDropDownButton8.ShowDropDownArrow = false;
			this.toolStripDropDownButton8.Size = new System.Drawing.Size(90, 23);
			this.toolStripDropDownButton8.Text = "Действия";
			// 
			// toolStripMenuItem96
			// 
			this.toolStripMenuItem96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem96.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem97,
            this.toolStripMenuItem98});
			this.toolStripMenuItem96.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem96.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem96.Name = "toolStripMenuItem96";
			this.toolStripMenuItem96.Size = new System.Drawing.Size(265, 22);
			this.toolStripMenuItem96.Text = "Параметры подключения";
			// 
			// toolStripMenuItem97
			// 
			this.toolStripMenuItem97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem97.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
			this.toolStripMenuItem97.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem97.Name = "toolStripMenuItem97";
			this.toolStripMenuItem97.Size = new System.Drawing.Size(208, 22);
			this.toolStripMenuItem97.Text = "COM-Порт";
			// 
			// toolStripComboBox3
			// 
			this.toolStripComboBox3.BackColor = System.Drawing.Color.White;
			this.toolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.toolStripComboBox3.ForeColor = System.Drawing.Color.Black;
			this.toolStripComboBox3.Items.AddRange(new object[] {
            "NULL"});
			this.toolStripComboBox3.Name = "toolStripComboBox3";
			this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
			// 
			// toolStripMenuItem98
			// 
			this.toolStripMenuItem98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem98.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox4});
			this.toolStripMenuItem98.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripMenuItem98.Name = "toolStripMenuItem98";
			this.toolStripMenuItem98.Size = new System.Drawing.Size(208, 22);
			this.toolStripMenuItem98.Text = "Скорость передачи";
			// 
			// toolStripComboBox4
			// 
			this.toolStripComboBox4.BackColor = System.Drawing.Color.White;
			this.toolStripComboBox4.ForeColor = System.Drawing.Color.Black;
			this.toolStripComboBox4.Items.AddRange(new object[] {
            "9600",
            "115200"});
			this.toolStripComboBox4.Name = "toolStripComboBox4";
			this.toolStripComboBox4.Size = new System.Drawing.Size(121, 23);
			// 
			// toolStripMenuItem99
			// 
			this.toolStripMenuItem99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem99.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem99.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem99.Name = "toolStripMenuItem99";
			this.toolStripMenuItem99.Size = new System.Drawing.Size(265, 22);
			this.toolStripMenuItem99.Text = "Подключение к контроллеру";
			// 
			// toolStripMenuItem100
			// 
			this.toolStripMenuItem100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem100.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem100.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem100.Name = "toolStripMenuItem100";
			this.toolStripMenuItem100.Size = new System.Drawing.Size(265, 22);
			this.toolStripMenuItem100.Text = "Выход";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.ForeColor = System.Drawing.Color.DimGray;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton10
			// 
			this.toolStripDropDownButton10.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem113,
            this.toolStripMenuItem119,
            this.toolStripMenuItem125});
			this.toolStripDropDownButton10.Enabled = false;
			this.toolStripDropDownButton10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton10.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton10.Image")));
			this.toolStripDropDownButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton10.Name = "toolStripDropDownButton10";
			this.toolStripDropDownButton10.ShowDropDownArrow = false;
			this.toolStripDropDownButton10.Size = new System.Drawing.Size(75, 23);
			this.toolStripDropDownButton10.Text = "Спикер";
			this.toolStripDropDownButton10.ToolTipText = "Пищалка";
			this.toolStripDropDownButton10.Visible = false;
			// 
			// toolStripMenuItem113
			// 
			this.toolStripMenuItem113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem113.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem114,
            this.toolStripMenuItem115,
            this.toolStripMenuItem116,
            this.toolStripMenuItem117,
            this.toolStripMenuItem118});
			this.toolStripMenuItem113.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem113.Name = "toolStripMenuItem113";
			this.toolStripMenuItem113.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem113.Text = "Писк BIOS";
			// 
			// toolStripMenuItem114
			// 
			this.toolStripMenuItem114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem114.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem114.Name = "toolStripMenuItem114";
			this.toolStripMenuItem114.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem114.Text = "1 пик";
			// 
			// toolStripMenuItem115
			// 
			this.toolStripMenuItem115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem115.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem115.Name = "toolStripMenuItem115";
			this.toolStripMenuItem115.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem115.Text = "2 пика";
			// 
			// toolStripMenuItem116
			// 
			this.toolStripMenuItem116.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem116.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem116.Name = "toolStripMenuItem116";
			this.toolStripMenuItem116.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem116.Text = "3 пика";
			// 
			// toolStripMenuItem117
			// 
			this.toolStripMenuItem117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem117.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem117.Name = "toolStripMenuItem117";
			this.toolStripMenuItem117.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem117.Text = "4 пика";
			// 
			// toolStripMenuItem118
			// 
			this.toolStripMenuItem118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem118.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem118.Name = "toolStripMenuItem118";
			this.toolStripMenuItem118.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem118.Text = "5 пиков";
			// 
			// toolStripMenuItem119
			// 
			this.toolStripMenuItem119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem119.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem120,
            this.toolStripMenuItem121,
            this.toolStripMenuItem122,
            this.toolStripMenuItem123,
            this.toolStripMenuItem124});
			this.toolStripMenuItem119.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem119.Name = "toolStripMenuItem119";
			this.toolStripMenuItem119.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem119.Text = "Писк 1 кГц";
			// 
			// toolStripMenuItem120
			// 
			this.toolStripMenuItem120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem120.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem120.Name = "toolStripMenuItem120";
			this.toolStripMenuItem120.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem120.Text = "100 Мс";
			// 
			// toolStripMenuItem121
			// 
			this.toolStripMenuItem121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem121.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem121.Name = "toolStripMenuItem121";
			this.toolStripMenuItem121.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem121.Text = "250 Мс";
			// 
			// toolStripMenuItem122
			// 
			this.toolStripMenuItem122.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem122.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem122.Name = "toolStripMenuItem122";
			this.toolStripMenuItem122.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem122.Text = "500 Мс";
			// 
			// toolStripMenuItem123
			// 
			this.toolStripMenuItem123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem123.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem123.Name = "toolStripMenuItem123";
			this.toolStripMenuItem123.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem123.Text = "1 Секунда";
			// 
			// toolStripMenuItem124
			// 
			this.toolStripMenuItem124.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem124.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem124.Name = "toolStripMenuItem124";
			this.toolStripMenuItem124.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem124.Text = "2 Секунды";
			// 
			// toolStripMenuItem125
			// 
			this.toolStripMenuItem125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem125.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem126,
            this.toolStripMenuItem127,
            this.toolStripMenuItem128,
            this.toolStripMenuItem129,
            this.toolStripMenuItem130});
			this.toolStripMenuItem125.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem125.Name = "toolStripMenuItem125";
			this.toolStripMenuItem125.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem125.Text = "Писк 2 кГц";
			// 
			// toolStripMenuItem126
			// 
			this.toolStripMenuItem126.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem126.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem126.Name = "toolStripMenuItem126";
			this.toolStripMenuItem126.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem126.Text = "100 Мс";
			// 
			// toolStripMenuItem127
			// 
			this.toolStripMenuItem127.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem127.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem127.Name = "toolStripMenuItem127";
			this.toolStripMenuItem127.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem127.Text = "250 Мс";
			// 
			// toolStripMenuItem128
			// 
			this.toolStripMenuItem128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem128.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem128.Name = "toolStripMenuItem128";
			this.toolStripMenuItem128.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem128.Text = "500 Мс";
			// 
			// toolStripMenuItem129
			// 
			this.toolStripMenuItem129.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem129.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem129.Name = "toolStripMenuItem129";
			this.toolStripMenuItem129.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem129.Text = "1 Секунда";
			// 
			// toolStripMenuItem130
			// 
			this.toolStripMenuItem130.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem130.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem130.Name = "toolStripMenuItem130";
			this.toolStripMenuItem130.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem130.Text = "2 Секунды";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton14
			// 
			this.toolStripDropDownButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripDropDownButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem192,
            this.toolStripMenuItem193});
			this.toolStripDropDownButton14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton14.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton14.Image")));
			this.toolStripDropDownButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton14.Name = "toolStripDropDownButton14";
			this.toolStripDropDownButton14.ShowDropDownArrow = false;
			this.toolStripDropDownButton14.Size = new System.Drawing.Size(81, 23);
			this.toolStripDropDownButton14.Text = "Помощь";
			// 
			// toolStripMenuItem192
			// 
			this.toolStripMenuItem192.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem192.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem192.Name = "toolStripMenuItem192";
			this.toolStripMenuItem192.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem192.Text = "О программе";
			// 
			// toolStripMenuItem193
			// 
			this.toolStripMenuItem193.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem193.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem193.Name = "toolStripMenuItem193";
			this.toolStripMenuItem193.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem193.Text = "Помощь";
			// 
			// toolStripMenuItem171
			// 
			this.toolStripMenuItem171.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem171.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem172,
            this.toolStripMenuItem173});
			this.toolStripMenuItem171.Enabled = false;
			this.toolStripMenuItem171.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem171.Name = "toolStripMenuItem171";
			this.toolStripMenuItem171.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem171.Text = "Реле 1";
			// 
			// toolStripMenuItem172
			// 
			this.toolStripMenuItem172.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem172.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem172.Name = "toolStripMenuItem172";
			this.toolStripMenuItem172.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem172.Text = "Включить";
			// 
			// toolStripMenuItem173
			// 
			this.toolStripMenuItem173.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem173.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem173.Name = "toolStripMenuItem173";
			this.toolStripMenuItem173.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem173.Text = "Выключить";
			// 
			// toolStripMenuItem174
			// 
			this.toolStripMenuItem174.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem174.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem175,
            this.toolStripMenuItem176});
			this.toolStripMenuItem174.Enabled = false;
			this.toolStripMenuItem174.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem174.Name = "toolStripMenuItem174";
			this.toolStripMenuItem174.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem174.Text = "Реле 2";
			// 
			// toolStripMenuItem175
			// 
			this.toolStripMenuItem175.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem175.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem175.Name = "toolStripMenuItem175";
			this.toolStripMenuItem175.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem175.Text = "Включить";
			// 
			// toolStripMenuItem176
			// 
			this.toolStripMenuItem176.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem176.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem176.Name = "toolStripMenuItem176";
			this.toolStripMenuItem176.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem176.Text = "Выключить";
			// 
			// toolStripMenuItem177
			// 
			this.toolStripMenuItem177.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem177.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem178,
            this.toolStripMenuItem179});
			this.toolStripMenuItem177.Enabled = false;
			this.toolStripMenuItem177.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem177.Name = "toolStripMenuItem177";
			this.toolStripMenuItem177.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem177.Text = "Реле 3";
			// 
			// toolStripMenuItem178
			// 
			this.toolStripMenuItem178.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem178.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem178.Name = "toolStripMenuItem178";
			this.toolStripMenuItem178.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem178.Text = "Включить";
			// 
			// toolStripMenuItem179
			// 
			this.toolStripMenuItem179.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem179.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem179.Name = "toolStripMenuItem179";
			this.toolStripMenuItem179.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem179.Text = "Выключить";
			// 
			// toolStripMenuItem180
			// 
			this.toolStripMenuItem180.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem180.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem181,
            this.toolStripMenuItem182});
			this.toolStripMenuItem180.Enabled = false;
			this.toolStripMenuItem180.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem180.Name = "toolStripMenuItem180";
			this.toolStripMenuItem180.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem180.Text = "Реле 4";
			// 
			// toolStripMenuItem181
			// 
			this.toolStripMenuItem181.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem181.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem181.Name = "toolStripMenuItem181";
			this.toolStripMenuItem181.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem181.Text = "Включить";
			// 
			// toolStripMenuItem182
			// 
			this.toolStripMenuItem182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem182.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem182.Name = "toolStripMenuItem182";
			this.toolStripMenuItem182.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem182.Text = "Выключить";
			// 
			// toolStripMenuItem183
			// 
			this.toolStripMenuItem183.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem183.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem184,
            this.toolStripMenuItem185});
			this.toolStripMenuItem183.Enabled = false;
			this.toolStripMenuItem183.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem183.Name = "toolStripMenuItem183";
			this.toolStripMenuItem183.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem183.Text = "Реле 5";
			// 
			// toolStripMenuItem184
			// 
			this.toolStripMenuItem184.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem184.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem184.Name = "toolStripMenuItem184";
			this.toolStripMenuItem184.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem184.Text = "Включить";
			// 
			// toolStripMenuItem185
			// 
			this.toolStripMenuItem185.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem185.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem185.Name = "toolStripMenuItem185";
			this.toolStripMenuItem185.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem185.Text = "Выключить";
			// 
			// toolStripMenuItem186
			// 
			this.toolStripMenuItem186.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem186.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem187,
            this.toolStripMenuItem188});
			this.toolStripMenuItem186.Enabled = false;
			this.toolStripMenuItem186.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem186.Name = "toolStripMenuItem186";
			this.toolStripMenuItem186.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem186.Text = "Реле 6";
			// 
			// toolStripMenuItem187
			// 
			this.toolStripMenuItem187.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem187.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem187.Name = "toolStripMenuItem187";
			this.toolStripMenuItem187.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem187.Text = "Включить";
			// 
			// toolStripMenuItem188
			// 
			this.toolStripMenuItem188.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem188.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem188.Name = "toolStripMenuItem188";
			this.toolStripMenuItem188.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem188.Text = "Выключить";
			// 
			// toolStripMenuItem189
			// 
			this.toolStripMenuItem189.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem189.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem190,
            this.toolStripMenuItem191});
			this.toolStripMenuItem189.Enabled = false;
			this.toolStripMenuItem189.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem189.Name = "toolStripMenuItem189";
			this.toolStripMenuItem189.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem189.Text = "Реле 7";
			// 
			// toolStripMenuItem190
			// 
			this.toolStripMenuItem190.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem190.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem190.Name = "toolStripMenuItem190";
			this.toolStripMenuItem190.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem190.Text = "Включить";
			// 
			// toolStripMenuItem191
			// 
			this.toolStripMenuItem191.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem191.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem191.Name = "toolStripMenuItem191";
			this.toolStripMenuItem191.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem191.Text = "Выключить";
			// 
			// toolStripDropDownButton13
			// 
			this.toolStripDropDownButton13.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem171,
            this.toolStripMenuItem174,
            this.toolStripMenuItem177,
            this.toolStripMenuItem180,
            this.toolStripMenuItem183,
            this.toolStripMenuItem186,
            this.toolStripMenuItem189});
			this.toolStripDropDownButton13.Enabled = false;
			this.toolStripDropDownButton13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton13.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton13.Image")));
			this.toolStripDropDownButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton13.Name = "toolStripDropDownButton13";
			this.toolStripDropDownButton13.ShowDropDownArrow = false;
			this.toolStripDropDownButton13.Size = new System.Drawing.Size(121, 23);
			this.toolStripDropDownButton13.Text = "Выключатель";
			this.toolStripDropDownButton13.ToolTipText = "Пищалка";
			this.toolStripDropDownButton13.Visible = false;
			// 
			// toolStripMenuItem147
			// 
			this.toolStripMenuItem147.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem147.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem148,
            this.toolStripMenuItem149,
            this.toolStripMenuItem150,
            this.toolStripMenuItem151,
            this.toolStripMenuItem152});
			this.toolStripMenuItem147.Enabled = false;
			this.toolStripMenuItem147.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem147.Name = "toolStripMenuItem147";
			this.toolStripMenuItem147.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem147.Text = "Сервопривод 1";
			// 
			// toolStripMenuItem148
			// 
			this.toolStripMenuItem148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem148.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem148.Name = "toolStripMenuItem148";
			this.toolStripMenuItem148.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem148.Text = "0°";
			// 
			// toolStripMenuItem149
			// 
			this.toolStripMenuItem149.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem149.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem149.Name = "toolStripMenuItem149";
			this.toolStripMenuItem149.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem149.Text = "90°";
			// 
			// toolStripMenuItem150
			// 
			this.toolStripMenuItem150.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem150.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem150.Name = "toolStripMenuItem150";
			this.toolStripMenuItem150.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem150.Text = "180°";
			// 
			// toolStripMenuItem151
			// 
			this.toolStripMenuItem151.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem151.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem151.Name = "toolStripMenuItem151";
			this.toolStripMenuItem151.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem151.Text = "270°";
			// 
			// toolStripMenuItem152
			// 
			this.toolStripMenuItem152.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem152.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem152.Name = "toolStripMenuItem152";
			this.toolStripMenuItem152.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem152.Text = "360°";
			// 
			// toolStripMenuItem153
			// 
			this.toolStripMenuItem153.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem153.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem154,
            this.toolStripMenuItem155,
            this.toolStripMenuItem156,
            this.toolStripMenuItem157,
            this.toolStripMenuItem158});
			this.toolStripMenuItem153.Enabled = false;
			this.toolStripMenuItem153.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem153.Name = "toolStripMenuItem153";
			this.toolStripMenuItem153.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem153.Text = "Сервопривод 2";
			// 
			// toolStripMenuItem154
			// 
			this.toolStripMenuItem154.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem154.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem154.Name = "toolStripMenuItem154";
			this.toolStripMenuItem154.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem154.Text = "0°";
			// 
			// toolStripMenuItem155
			// 
			this.toolStripMenuItem155.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem155.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem155.Name = "toolStripMenuItem155";
			this.toolStripMenuItem155.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem155.Text = "90°";
			// 
			// toolStripMenuItem156
			// 
			this.toolStripMenuItem156.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem156.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem156.Name = "toolStripMenuItem156";
			this.toolStripMenuItem156.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem156.Text = "180°";
			// 
			// toolStripMenuItem157
			// 
			this.toolStripMenuItem157.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem157.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem157.Name = "toolStripMenuItem157";
			this.toolStripMenuItem157.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem157.Text = "270°";
			// 
			// toolStripMenuItem158
			// 
			this.toolStripMenuItem158.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem158.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem158.Name = "toolStripMenuItem158";
			this.toolStripMenuItem158.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem158.Text = "360°";
			// 
			// toolStripMenuItem159
			// 
			this.toolStripMenuItem159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem159.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem160,
            this.toolStripMenuItem161,
            this.toolStripMenuItem162,
            this.toolStripMenuItem163,
            this.toolStripMenuItem164});
			this.toolStripMenuItem159.Enabled = false;
			this.toolStripMenuItem159.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem159.Name = "toolStripMenuItem159";
			this.toolStripMenuItem159.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem159.Text = "Сервопривод 3";
			// 
			// toolStripMenuItem160
			// 
			this.toolStripMenuItem160.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem160.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem160.Name = "toolStripMenuItem160";
			this.toolStripMenuItem160.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem160.Text = "0°";
			// 
			// toolStripMenuItem161
			// 
			this.toolStripMenuItem161.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem161.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem161.Name = "toolStripMenuItem161";
			this.toolStripMenuItem161.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem161.Text = "90°";
			// 
			// toolStripMenuItem162
			// 
			this.toolStripMenuItem162.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem162.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem162.Name = "toolStripMenuItem162";
			this.toolStripMenuItem162.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem162.Text = "180°";
			// 
			// toolStripMenuItem163
			// 
			this.toolStripMenuItem163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem163.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem163.Name = "toolStripMenuItem163";
			this.toolStripMenuItem163.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem163.Text = "270°";
			// 
			// toolStripMenuItem164
			// 
			this.toolStripMenuItem164.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem164.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem164.Name = "toolStripMenuItem164";
			this.toolStripMenuItem164.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem164.Text = "360°";
			// 
			// toolStripMenuItem165
			// 
			this.toolStripMenuItem165.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem165.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem166,
            this.toolStripMenuItem167,
            this.toolStripMenuItem168,
            this.toolStripMenuItem169,
            this.toolStripMenuItem170});
			this.toolStripMenuItem165.Enabled = false;
			this.toolStripMenuItem165.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem165.Name = "toolStripMenuItem165";
			this.toolStripMenuItem165.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem165.Text = "Сервопривод 4";
			// 
			// toolStripMenuItem166
			// 
			this.toolStripMenuItem166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem166.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem166.Name = "toolStripMenuItem166";
			this.toolStripMenuItem166.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem166.Text = "0°";
			// 
			// toolStripMenuItem167
			// 
			this.toolStripMenuItem167.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem167.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem167.Name = "toolStripMenuItem167";
			this.toolStripMenuItem167.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem167.Text = "90°";
			// 
			// toolStripMenuItem168
			// 
			this.toolStripMenuItem168.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem168.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem168.Name = "toolStripMenuItem168";
			this.toolStripMenuItem168.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem168.Text = "180°";
			// 
			// toolStripMenuItem169
			// 
			this.toolStripMenuItem169.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem169.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem169.Name = "toolStripMenuItem169";
			this.toolStripMenuItem169.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem169.Text = "270°";
			// 
			// toolStripMenuItem170
			// 
			this.toolStripMenuItem170.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem170.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem170.Name = "toolStripMenuItem170";
			this.toolStripMenuItem170.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem170.Text = "360°";
			// 
			// toolStripDropDownButton12
			// 
			this.toolStripDropDownButton12.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem147,
            this.toolStripMenuItem153,
            this.toolStripMenuItem159,
            this.toolStripMenuItem165});
			this.toolStripDropDownButton12.Enabled = false;
			this.toolStripDropDownButton12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton12.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton12.Image")));
			this.toolStripDropDownButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton12.Name = "toolStripDropDownButton12";
			this.toolStripDropDownButton12.ShowDropDownArrow = false;
			this.toolStripDropDownButton12.Size = new System.Drawing.Size(125, 23);
			this.toolStripDropDownButton12.Text = "Сервопривод";
			this.toolStripDropDownButton12.ToolTipText = "Пищалка";
			this.toolStripDropDownButton12.Visible = false;
			// 
			// toolStripMenuItem131
			// 
			this.toolStripMenuItem131.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem131.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem132,
            this.toolStripMenuItem133,
            this.toolStripMenuItem134});
			this.toolStripMenuItem131.Enabled = false;
			this.toolStripMenuItem131.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem131.Name = "toolStripMenuItem131";
			this.toolStripMenuItem131.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem131.Text = "Мотор 1";
			// 
			// toolStripMenuItem132
			// 
			this.toolStripMenuItem132.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem132.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem132.Name = "toolStripMenuItem132";
			this.toolStripMenuItem132.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem132.Text = "Включить";
			// 
			// toolStripMenuItem133
			// 
			this.toolStripMenuItem133.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem133.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem133.Name = "toolStripMenuItem133";
			this.toolStripMenuItem133.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem133.Text = "Половина скорости";
			// 
			// toolStripMenuItem134
			// 
			this.toolStripMenuItem134.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem134.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem134.Name = "toolStripMenuItem134";
			this.toolStripMenuItem134.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem134.Text = "Выключить";
			// 
			// toolStripMenuItem135
			// 
			this.toolStripMenuItem135.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem135.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem136,
            this.toolStripMenuItem137,
            this.toolStripMenuItem138});
			this.toolStripMenuItem135.Enabled = false;
			this.toolStripMenuItem135.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem135.Name = "toolStripMenuItem135";
			this.toolStripMenuItem135.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem135.Text = "Мотор 2";
			// 
			// toolStripMenuItem136
			// 
			this.toolStripMenuItem136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem136.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem136.Name = "toolStripMenuItem136";
			this.toolStripMenuItem136.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem136.Text = "Включить";
			// 
			// toolStripMenuItem137
			// 
			this.toolStripMenuItem137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem137.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem137.Name = "toolStripMenuItem137";
			this.toolStripMenuItem137.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem137.Text = "Половина скорости";
			// 
			// toolStripMenuItem138
			// 
			this.toolStripMenuItem138.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem138.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem138.Name = "toolStripMenuItem138";
			this.toolStripMenuItem138.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem138.Text = "Выключить";
			// 
			// toolStripMenuItem139
			// 
			this.toolStripMenuItem139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem139.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem140,
            this.toolStripMenuItem141,
            this.toolStripMenuItem142});
			this.toolStripMenuItem139.Enabled = false;
			this.toolStripMenuItem139.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem139.Name = "toolStripMenuItem139";
			this.toolStripMenuItem139.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem139.Text = "Мотор 3";
			// 
			// toolStripMenuItem140
			// 
			this.toolStripMenuItem140.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem140.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem140.Name = "toolStripMenuItem140";
			this.toolStripMenuItem140.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem140.Text = "Включить";
			// 
			// toolStripMenuItem141
			// 
			this.toolStripMenuItem141.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem141.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem141.Name = "toolStripMenuItem141";
			this.toolStripMenuItem141.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem141.Text = "Половина скорости";
			// 
			// toolStripMenuItem142
			// 
			this.toolStripMenuItem142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem142.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem142.Name = "toolStripMenuItem142";
			this.toolStripMenuItem142.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem142.Text = "Выключить";
			// 
			// toolStripMenuItem143
			// 
			this.toolStripMenuItem143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem143.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem144,
            this.toolStripMenuItem145,
            this.toolStripMenuItem146});
			this.toolStripMenuItem143.Enabled = false;
			this.toolStripMenuItem143.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem143.Name = "toolStripMenuItem143";
			this.toolStripMenuItem143.Size = new System.Drawing.Size(180, 24);
			this.toolStripMenuItem143.Text = "Мотор 4";
			// 
			// toolStripMenuItem144
			// 
			this.toolStripMenuItem144.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem144.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem144.Name = "toolStripMenuItem144";
			this.toolStripMenuItem144.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem144.Text = "Включить";
			// 
			// toolStripMenuItem145
			// 
			this.toolStripMenuItem145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem145.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem145.Name = "toolStripMenuItem145";
			this.toolStripMenuItem145.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem145.Text = "Половина скорости";
			// 
			// toolStripMenuItem146
			// 
			this.toolStripMenuItem146.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem146.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem146.Name = "toolStripMenuItem146";
			this.toolStripMenuItem146.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem146.Text = "Выключить";
			// 
			// toolStripDropDownButton11
			// 
			this.toolStripDropDownButton11.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem131,
            this.toolStripMenuItem135,
            this.toolStripMenuItem139,
            this.toolStripMenuItem143});
			this.toolStripDropDownButton11.Enabled = false;
			this.toolStripDropDownButton11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton11.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton11.Image")));
			this.toolStripDropDownButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton11.Name = "toolStripDropDownButton11";
			this.toolStripDropDownButton11.ShowDropDownArrow = false;
			this.toolStripDropDownButton11.Size = new System.Drawing.Size(134, 23);
			this.toolStripDropDownButton11.Text = "Электромотор";
			this.toolStripDropDownButton11.ToolTipText = "Пищалка";
			this.toolStripDropDownButton11.Visible = false;
			// 
			// toolStripMenuItem101
			// 
			this.toolStripMenuItem101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem101.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem102,
            this.toolStripMenuItem103});
			this.toolStripMenuItem101.Enabled = false;
			this.toolStripMenuItem101.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem101.Name = "toolStripMenuItem101";
			this.toolStripMenuItem101.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem101.Text = "Освещение 1";
			// 
			// toolStripMenuItem102
			// 
			this.toolStripMenuItem102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem102.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem102.Name = "toolStripMenuItem102";
			this.toolStripMenuItem102.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem102.Text = "Включить";
			// 
			// toolStripMenuItem103
			// 
			this.toolStripMenuItem103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem103.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem103.Name = "toolStripMenuItem103";
			this.toolStripMenuItem103.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem103.Text = "Выключить";
			// 
			// toolStripMenuItem104
			// 
			this.toolStripMenuItem104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem104.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem105,
            this.toolStripMenuItem106});
			this.toolStripMenuItem104.Enabled = false;
			this.toolStripMenuItem104.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem104.Name = "toolStripMenuItem104";
			this.toolStripMenuItem104.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem104.Text = "Освещение 2";
			// 
			// toolStripMenuItem105
			// 
			this.toolStripMenuItem105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem105.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem105.Name = "toolStripMenuItem105";
			this.toolStripMenuItem105.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem105.Text = "Включить";
			// 
			// toolStripMenuItem106
			// 
			this.toolStripMenuItem106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem106.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem106.Name = "toolStripMenuItem106";
			this.toolStripMenuItem106.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem106.Text = "Выключить";
			// 
			// toolStripMenuItem107
			// 
			this.toolStripMenuItem107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem107.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem108,
            this.toolStripMenuItem109});
			this.toolStripMenuItem107.Enabled = false;
			this.toolStripMenuItem107.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem107.Name = "toolStripMenuItem107";
			this.toolStripMenuItem107.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem107.Text = "Освещение 3";
			// 
			// toolStripMenuItem108
			// 
			this.toolStripMenuItem108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem108.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem108.Name = "toolStripMenuItem108";
			this.toolStripMenuItem108.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem108.Text = "Включить";
			// 
			// toolStripMenuItem109
			// 
			this.toolStripMenuItem109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem109.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem109.Name = "toolStripMenuItem109";
			this.toolStripMenuItem109.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem109.Text = "Выключить";
			// 
			// toolStripMenuItem110
			// 
			this.toolStripMenuItem110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem110.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem111,
            this.toolStripMenuItem112});
			this.toolStripMenuItem110.Enabled = false;
			this.toolStripMenuItem110.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem110.Name = "toolStripMenuItem110";
			this.toolStripMenuItem110.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem110.Text = "Освещение 4";
			// 
			// toolStripMenuItem111
			// 
			this.toolStripMenuItem111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem111.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem111.Name = "toolStripMenuItem111";
			this.toolStripMenuItem111.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem111.Text = "Включить";
			// 
			// toolStripMenuItem112
			// 
			this.toolStripMenuItem112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem112.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem112.Name = "toolStripMenuItem112";
			this.toolStripMenuItem112.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem112.Text = "Выключить";
			// 
			// toolStripDropDownButton9
			// 
			this.toolStripDropDownButton9.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem101,
            this.toolStripMenuItem104,
            this.toolStripMenuItem107,
            this.toolStripMenuItem110});
			this.toolStripDropDownButton9.Enabled = false;
			this.toolStripDropDownButton9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton9.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton9.Image")));
			this.toolStripDropDownButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton9.Name = "toolStripDropDownButton9";
			this.toolStripDropDownButton9.ShowDropDownArrow = false;
			this.toolStripDropDownButton9.Size = new System.Drawing.Size(111, 23);
			this.toolStripDropDownButton9.Text = "Освещение";
			this.toolStripDropDownButton9.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox2.Controls.Add(this.materialButton1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.guna2NumericUpDown2);
			this.groupBox2.Controls.Add(this.guna2NumericUpDown1);
			this.groupBox2.Enabled = false;
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(24, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(394, 83);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Спикер";
			this.groupBox2.Visible = false;
			// 
			// materialButton1
			// 
			this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButton1.Depth = 0;
			this.materialButton1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new System.Drawing.Point(255, 29);
			this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButton1.Size = new System.Drawing.Size(80, 36);
			this.materialButton1.TabIndex = 40;
			this.materialButton1.Text = "Пищим";
			this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = true;
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
			// toolStrip3
			// 
			this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton15,
            this.toolStripSeparator5,
            this.toolStripDropDownButton16,
            this.toolStripDropDownButton17,
            this.toolStripDropDownButton18,
            this.toolStripDropDownButton19,
            this.toolStripDropDownButton20,
            this.toolStripSeparator6,
            this.toolStripDropDownButton21});
			this.toolStrip3.Location = new System.Drawing.Point(0, 0);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(1045, 26);
			this.toolStrip3.TabIndex = 34;
			this.toolStrip3.Text = "toolStrip3";
			// 
			// toolStripDropDownButton15
			// 
			this.toolStripDropDownButton15.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem194,
            this.toolStripMenuItem197,
            this.toolStripMenuItem198});
			this.toolStripDropDownButton15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton15.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton15.Image")));
			this.toolStripDropDownButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton15.Name = "toolStripDropDownButton15";
			this.toolStripDropDownButton15.ShowDropDownArrow = false;
			this.toolStripDropDownButton15.Size = new System.Drawing.Size(90, 23);
			this.toolStripDropDownButton15.Text = "Действия";
			// 
			// toolStripMenuItem194
			// 
			this.toolStripMenuItem194.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem194.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem195,
            this.toolStripMenuItem196});
			this.toolStripMenuItem194.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem194.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem194.Name = "toolStripMenuItem194";
			this.toolStripMenuItem194.Size = new System.Drawing.Size(265, 22);
			this.toolStripMenuItem194.Text = "Параметры подключения";
			// 
			// toolStripMenuItem195
			// 
			this.toolStripMenuItem195.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem195.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox5});
			this.toolStripMenuItem195.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem195.Name = "toolStripMenuItem195";
			this.toolStripMenuItem195.Size = new System.Drawing.Size(208, 22);
			this.toolStripMenuItem195.Text = "COM-Порт";
			// 
			// toolStripComboBox5
			// 
			this.toolStripComboBox5.BackColor = System.Drawing.Color.White;
			this.toolStripComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.toolStripComboBox5.ForeColor = System.Drawing.Color.Black;
			this.toolStripComboBox5.Items.AddRange(new object[] {
            "NULL"});
			this.toolStripComboBox5.Name = "toolStripComboBox5";
			this.toolStripComboBox5.Size = new System.Drawing.Size(121, 23);
			// 
			// toolStripMenuItem196
			// 
			this.toolStripMenuItem196.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem196.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox6});
			this.toolStripMenuItem196.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripMenuItem196.Name = "toolStripMenuItem196";
			this.toolStripMenuItem196.Size = new System.Drawing.Size(208, 22);
			this.toolStripMenuItem196.Text = "Скорость передачи";
			// 
			// toolStripComboBox6
			// 
			this.toolStripComboBox6.BackColor = System.Drawing.Color.White;
			this.toolStripComboBox6.ForeColor = System.Drawing.Color.Black;
			this.toolStripComboBox6.Items.AddRange(new object[] {
            "9600",
            "115200"});
			this.toolStripComboBox6.Name = "toolStripComboBox6";
			this.toolStripComboBox6.Size = new System.Drawing.Size(121, 23);
			// 
			// toolStripMenuItem197
			// 
			this.toolStripMenuItem197.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem197.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem197.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem197.Name = "toolStripMenuItem197";
			this.toolStripMenuItem197.Size = new System.Drawing.Size(265, 22);
			this.toolStripMenuItem197.Text = "Подключение к контроллеру";
			// 
			// toolStripMenuItem198
			// 
			this.toolStripMenuItem198.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem198.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem198.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem198.Name = "toolStripMenuItem198";
			this.toolStripMenuItem198.Size = new System.Drawing.Size(265, 22);
			this.toolStripMenuItem198.Text = "Выход";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.ForeColor = System.Drawing.Color.DimGray;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton16
			// 
			this.toolStripDropDownButton16.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem199,
            this.toolStripMenuItem202,
            this.toolStripMenuItem205,
            this.toolStripMenuItem208});
			this.toolStripDropDownButton16.Enabled = false;
			this.toolStripDropDownButton16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton16.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton16.Image")));
			this.toolStripDropDownButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton16.Name = "toolStripDropDownButton16";
			this.toolStripDropDownButton16.ShowDropDownArrow = false;
			this.toolStripDropDownButton16.Size = new System.Drawing.Size(111, 23);
			this.toolStripDropDownButton16.Text = "Освещение";
			this.toolStripDropDownButton16.Visible = false;
			// 
			// toolStripMenuItem199
			// 
			this.toolStripMenuItem199.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem199.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem200,
            this.toolStripMenuItem201});
			this.toolStripMenuItem199.Enabled = false;
			this.toolStripMenuItem199.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem199.Name = "toolStripMenuItem199";
			this.toolStripMenuItem199.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem199.Text = "Освещение 1";
			// 
			// toolStripMenuItem200
			// 
			this.toolStripMenuItem200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem200.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem200.Name = "toolStripMenuItem200";
			this.toolStripMenuItem200.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem200.Text = "Включить";
			// 
			// toolStripMenuItem201
			// 
			this.toolStripMenuItem201.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem201.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem201.Name = "toolStripMenuItem201";
			this.toolStripMenuItem201.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem201.Text = "Выключить";
			// 
			// toolStripMenuItem202
			// 
			this.toolStripMenuItem202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem202.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem203,
            this.toolStripMenuItem204});
			this.toolStripMenuItem202.Enabled = false;
			this.toolStripMenuItem202.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem202.Name = "toolStripMenuItem202";
			this.toolStripMenuItem202.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem202.Text = "Освещение 2";
			// 
			// toolStripMenuItem203
			// 
			this.toolStripMenuItem203.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem203.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem203.Name = "toolStripMenuItem203";
			this.toolStripMenuItem203.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem203.Text = "Включить";
			// 
			// toolStripMenuItem204
			// 
			this.toolStripMenuItem204.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem204.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem204.Name = "toolStripMenuItem204";
			this.toolStripMenuItem204.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem204.Text = "Выключить";
			// 
			// toolStripMenuItem205
			// 
			this.toolStripMenuItem205.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem205.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem206,
            this.toolStripMenuItem207});
			this.toolStripMenuItem205.Enabled = false;
			this.toolStripMenuItem205.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem205.Name = "toolStripMenuItem205";
			this.toolStripMenuItem205.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem205.Text = "Освещение 3";
			// 
			// toolStripMenuItem206
			// 
			this.toolStripMenuItem206.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem206.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem206.Name = "toolStripMenuItem206";
			this.toolStripMenuItem206.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem206.Text = "Включить";
			// 
			// toolStripMenuItem207
			// 
			this.toolStripMenuItem207.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem207.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem207.Name = "toolStripMenuItem207";
			this.toolStripMenuItem207.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem207.Text = "Выключить";
			// 
			// toolStripMenuItem208
			// 
			this.toolStripMenuItem208.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem208.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem209,
            this.toolStripMenuItem210});
			this.toolStripMenuItem208.Enabled = false;
			this.toolStripMenuItem208.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem208.Name = "toolStripMenuItem208";
			this.toolStripMenuItem208.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem208.Text = "Освещение 4";
			// 
			// toolStripMenuItem209
			// 
			this.toolStripMenuItem209.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem209.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem209.Name = "toolStripMenuItem209";
			this.toolStripMenuItem209.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem209.Text = "Включить";
			// 
			// toolStripMenuItem210
			// 
			this.toolStripMenuItem210.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem210.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem210.Name = "toolStripMenuItem210";
			this.toolStripMenuItem210.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem210.Text = "Выключить";
			// 
			// toolStripDropDownButton17
			// 
			this.toolStripDropDownButton17.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem211,
            this.toolStripMenuItem217,
            this.toolStripMenuItem223});
			this.toolStripDropDownButton17.Enabled = false;
			this.toolStripDropDownButton17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton17.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton17.Image")));
			this.toolStripDropDownButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton17.Name = "toolStripDropDownButton17";
			this.toolStripDropDownButton17.ShowDropDownArrow = false;
			this.toolStripDropDownButton17.Size = new System.Drawing.Size(75, 23);
			this.toolStripDropDownButton17.Text = "Спикер";
			this.toolStripDropDownButton17.ToolTipText = "Пищалка";
			this.toolStripDropDownButton17.Visible = false;
			// 
			// toolStripMenuItem211
			// 
			this.toolStripMenuItem211.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem211.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem212,
            this.toolStripMenuItem213,
            this.toolStripMenuItem214,
            this.toolStripMenuItem215,
            this.toolStripMenuItem216});
			this.toolStripMenuItem211.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem211.Name = "toolStripMenuItem211";
			this.toolStripMenuItem211.Size = new System.Drawing.Size(162, 24);
			this.toolStripMenuItem211.Text = "Писк BIOS";
			// 
			// toolStripMenuItem212
			// 
			this.toolStripMenuItem212.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem212.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem212.Name = "toolStripMenuItem212";
			this.toolStripMenuItem212.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem212.Text = "1 пик";
			// 
			// toolStripMenuItem213
			// 
			this.toolStripMenuItem213.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem213.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem213.Name = "toolStripMenuItem213";
			this.toolStripMenuItem213.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem213.Text = "2 пика";
			// 
			// toolStripMenuItem214
			// 
			this.toolStripMenuItem214.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem214.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem214.Name = "toolStripMenuItem214";
			this.toolStripMenuItem214.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem214.Text = "3 пика";
			// 
			// toolStripMenuItem215
			// 
			this.toolStripMenuItem215.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem215.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem215.Name = "toolStripMenuItem215";
			this.toolStripMenuItem215.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem215.Text = "4 пика";
			// 
			// toolStripMenuItem216
			// 
			this.toolStripMenuItem216.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem216.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem216.Name = "toolStripMenuItem216";
			this.toolStripMenuItem216.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem216.Text = "5 пиков";
			// 
			// toolStripMenuItem217
			// 
			this.toolStripMenuItem217.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem217.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem218,
            this.toolStripMenuItem219,
            this.toolStripMenuItem220,
            this.toolStripMenuItem221,
            this.toolStripMenuItem222});
			this.toolStripMenuItem217.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem217.Name = "toolStripMenuItem217";
			this.toolStripMenuItem217.Size = new System.Drawing.Size(162, 24);
			this.toolStripMenuItem217.Text = "Писк 1 кГц";
			// 
			// toolStripMenuItem218
			// 
			this.toolStripMenuItem218.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem218.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem218.Name = "toolStripMenuItem218";
			this.toolStripMenuItem218.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem218.Text = "100 Мс";
			// 
			// toolStripMenuItem219
			// 
			this.toolStripMenuItem219.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem219.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem219.Name = "toolStripMenuItem219";
			this.toolStripMenuItem219.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem219.Text = "250 Мс";
			// 
			// toolStripMenuItem220
			// 
			this.toolStripMenuItem220.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem220.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem220.Name = "toolStripMenuItem220";
			this.toolStripMenuItem220.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem220.Text = "500 Мс";
			// 
			// toolStripMenuItem221
			// 
			this.toolStripMenuItem221.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem221.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem221.Name = "toolStripMenuItem221";
			this.toolStripMenuItem221.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem221.Text = "1 Секунда";
			// 
			// toolStripMenuItem222
			// 
			this.toolStripMenuItem222.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem222.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem222.Name = "toolStripMenuItem222";
			this.toolStripMenuItem222.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem222.Text = "2 Секунды";
			// 
			// toolStripMenuItem223
			// 
			this.toolStripMenuItem223.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem223.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem224,
            this.toolStripMenuItem225,
            this.toolStripMenuItem226,
            this.toolStripMenuItem227,
            this.toolStripMenuItem228});
			this.toolStripMenuItem223.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem223.Name = "toolStripMenuItem223";
			this.toolStripMenuItem223.Size = new System.Drawing.Size(162, 24);
			this.toolStripMenuItem223.Text = "Писк 2 кГц";
			// 
			// toolStripMenuItem224
			// 
			this.toolStripMenuItem224.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem224.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem224.Name = "toolStripMenuItem224";
			this.toolStripMenuItem224.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem224.Text = "100 Мс";
			// 
			// toolStripMenuItem225
			// 
			this.toolStripMenuItem225.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem225.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem225.Name = "toolStripMenuItem225";
			this.toolStripMenuItem225.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem225.Text = "250 Мс";
			// 
			// toolStripMenuItem226
			// 
			this.toolStripMenuItem226.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem226.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem226.Name = "toolStripMenuItem226";
			this.toolStripMenuItem226.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem226.Text = "500 Мс";
			// 
			// toolStripMenuItem227
			// 
			this.toolStripMenuItem227.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem227.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem227.Name = "toolStripMenuItem227";
			this.toolStripMenuItem227.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem227.Text = "1 Секунда";
			// 
			// toolStripMenuItem228
			// 
			this.toolStripMenuItem228.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem228.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem228.Name = "toolStripMenuItem228";
			this.toolStripMenuItem228.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem228.Text = "2 Секунды";
			// 
			// toolStripDropDownButton18
			// 
			this.toolStripDropDownButton18.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton18.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem229,
            this.toolStripMenuItem233,
            this.toolStripMenuItem237,
            this.toolStripMenuItem241});
			this.toolStripDropDownButton18.Enabled = false;
			this.toolStripDropDownButton18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton18.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton18.Image")));
			this.toolStripDropDownButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton18.Name = "toolStripDropDownButton18";
			this.toolStripDropDownButton18.ShowDropDownArrow = false;
			this.toolStripDropDownButton18.Size = new System.Drawing.Size(134, 23);
			this.toolStripDropDownButton18.Text = "Электромотор";
			this.toolStripDropDownButton18.ToolTipText = "Пищалка";
			this.toolStripDropDownButton18.Visible = false;
			// 
			// toolStripMenuItem229
			// 
			this.toolStripMenuItem229.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem229.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem230,
            this.toolStripMenuItem231,
            this.toolStripMenuItem232});
			this.toolStripMenuItem229.Enabled = false;
			this.toolStripMenuItem229.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem229.Name = "toolStripMenuItem229";
			this.toolStripMenuItem229.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem229.Text = "Мотор 1";
			// 
			// toolStripMenuItem230
			// 
			this.toolStripMenuItem230.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem230.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem230.Name = "toolStripMenuItem230";
			this.toolStripMenuItem230.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem230.Text = "Включить";
			// 
			// toolStripMenuItem231
			// 
			this.toolStripMenuItem231.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem231.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem231.Name = "toolStripMenuItem231";
			this.toolStripMenuItem231.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem231.Text = "Половина скорости";
			// 
			// toolStripMenuItem232
			// 
			this.toolStripMenuItem232.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem232.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem232.Name = "toolStripMenuItem232";
			this.toolStripMenuItem232.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem232.Text = "Выключить";
			// 
			// toolStripMenuItem233
			// 
			this.toolStripMenuItem233.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem233.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem234,
            this.toolStripMenuItem235,
            this.toolStripMenuItem236});
			this.toolStripMenuItem233.Enabled = false;
			this.toolStripMenuItem233.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem233.Name = "toolStripMenuItem233";
			this.toolStripMenuItem233.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem233.Text = "Мотор 2";
			// 
			// toolStripMenuItem234
			// 
			this.toolStripMenuItem234.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem234.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem234.Name = "toolStripMenuItem234";
			this.toolStripMenuItem234.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem234.Text = "Включить";
			// 
			// toolStripMenuItem235
			// 
			this.toolStripMenuItem235.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem235.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem235.Name = "toolStripMenuItem235";
			this.toolStripMenuItem235.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem235.Text = "Половина скорости";
			// 
			// toolStripMenuItem236
			// 
			this.toolStripMenuItem236.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem236.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem236.Name = "toolStripMenuItem236";
			this.toolStripMenuItem236.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem236.Text = "Выключить";
			// 
			// toolStripMenuItem237
			// 
			this.toolStripMenuItem237.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem237.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem238,
            this.toolStripMenuItem239,
            this.toolStripMenuItem240});
			this.toolStripMenuItem237.Enabled = false;
			this.toolStripMenuItem237.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem237.Name = "toolStripMenuItem237";
			this.toolStripMenuItem237.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem237.Text = "Мотор 3";
			// 
			// toolStripMenuItem238
			// 
			this.toolStripMenuItem238.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem238.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem238.Name = "toolStripMenuItem238";
			this.toolStripMenuItem238.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem238.Text = "Включить";
			// 
			// toolStripMenuItem239
			// 
			this.toolStripMenuItem239.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem239.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem239.Name = "toolStripMenuItem239";
			this.toolStripMenuItem239.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem239.Text = "Половина скорости";
			// 
			// toolStripMenuItem240
			// 
			this.toolStripMenuItem240.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem240.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem240.Name = "toolStripMenuItem240";
			this.toolStripMenuItem240.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem240.Text = "Выключить";
			// 
			// toolStripMenuItem241
			// 
			this.toolStripMenuItem241.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem241.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem242,
            this.toolStripMenuItem243,
            this.toolStripMenuItem244});
			this.toolStripMenuItem241.Enabled = false;
			this.toolStripMenuItem241.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem241.Name = "toolStripMenuItem241";
			this.toolStripMenuItem241.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem241.Text = "Мотор 4";
			// 
			// toolStripMenuItem242
			// 
			this.toolStripMenuItem242.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem242.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem242.Name = "toolStripMenuItem242";
			this.toolStripMenuItem242.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem242.Text = "Включить";
			// 
			// toolStripMenuItem243
			// 
			this.toolStripMenuItem243.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem243.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem243.Name = "toolStripMenuItem243";
			this.toolStripMenuItem243.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem243.Text = "Половина скорости";
			// 
			// toolStripMenuItem244
			// 
			this.toolStripMenuItem244.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem244.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem244.Name = "toolStripMenuItem244";
			this.toolStripMenuItem244.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem244.Text = "Выключить";
			// 
			// toolStripDropDownButton19
			// 
			this.toolStripDropDownButton19.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton19.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem245,
            this.toolStripMenuItem251,
            this.toolStripMenuItem257,
            this.toolStripMenuItem263});
			this.toolStripDropDownButton19.Enabled = false;
			this.toolStripDropDownButton19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton19.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton19.Image")));
			this.toolStripDropDownButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton19.Name = "toolStripDropDownButton19";
			this.toolStripDropDownButton19.ShowDropDownArrow = false;
			this.toolStripDropDownButton19.Size = new System.Drawing.Size(125, 23);
			this.toolStripDropDownButton19.Text = "Сервопривод";
			this.toolStripDropDownButton19.ToolTipText = "Пищалка";
			this.toolStripDropDownButton19.Visible = false;
			// 
			// toolStripMenuItem245
			// 
			this.toolStripMenuItem245.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem245.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem246,
            this.toolStripMenuItem247,
            this.toolStripMenuItem248,
            this.toolStripMenuItem249,
            this.toolStripMenuItem250});
			this.toolStripMenuItem245.Enabled = false;
			this.toolStripMenuItem245.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem245.Name = "toolStripMenuItem245";
			this.toolStripMenuItem245.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem245.Text = "Сервопривод 1";
			// 
			// toolStripMenuItem246
			// 
			this.toolStripMenuItem246.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem246.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem246.Name = "toolStripMenuItem246";
			this.toolStripMenuItem246.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem246.Text = "0°";
			// 
			// toolStripMenuItem247
			// 
			this.toolStripMenuItem247.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem247.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem247.Name = "toolStripMenuItem247";
			this.toolStripMenuItem247.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem247.Text = "90°";
			// 
			// toolStripMenuItem248
			// 
			this.toolStripMenuItem248.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem248.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem248.Name = "toolStripMenuItem248";
			this.toolStripMenuItem248.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem248.Text = "180°";
			// 
			// toolStripMenuItem249
			// 
			this.toolStripMenuItem249.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem249.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem249.Name = "toolStripMenuItem249";
			this.toolStripMenuItem249.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem249.Text = "270°";
			// 
			// toolStripMenuItem250
			// 
			this.toolStripMenuItem250.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem250.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem250.Name = "toolStripMenuItem250";
			this.toolStripMenuItem250.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem250.Text = "360°";
			// 
			// toolStripMenuItem251
			// 
			this.toolStripMenuItem251.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem251.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem252,
            this.toolStripMenuItem253,
            this.toolStripMenuItem254,
            this.toolStripMenuItem255,
            this.toolStripMenuItem256});
			this.toolStripMenuItem251.Enabled = false;
			this.toolStripMenuItem251.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem251.Name = "toolStripMenuItem251";
			this.toolStripMenuItem251.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem251.Text = "Сервопривод 2";
			// 
			// toolStripMenuItem252
			// 
			this.toolStripMenuItem252.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem252.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem252.Name = "toolStripMenuItem252";
			this.toolStripMenuItem252.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem252.Text = "0°";
			// 
			// toolStripMenuItem253
			// 
			this.toolStripMenuItem253.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem253.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem253.Name = "toolStripMenuItem253";
			this.toolStripMenuItem253.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem253.Text = "90°";
			// 
			// toolStripMenuItem254
			// 
			this.toolStripMenuItem254.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem254.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem254.Name = "toolStripMenuItem254";
			this.toolStripMenuItem254.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem254.Text = "180°";
			// 
			// toolStripMenuItem255
			// 
			this.toolStripMenuItem255.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem255.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem255.Name = "toolStripMenuItem255";
			this.toolStripMenuItem255.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem255.Text = "270°";
			// 
			// toolStripMenuItem256
			// 
			this.toolStripMenuItem256.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem256.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem256.Name = "toolStripMenuItem256";
			this.toolStripMenuItem256.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem256.Text = "360°";
			// 
			// toolStripMenuItem257
			// 
			this.toolStripMenuItem257.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem257.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem258,
            this.toolStripMenuItem259,
            this.toolStripMenuItem260,
            this.toolStripMenuItem261,
            this.toolStripMenuItem262});
			this.toolStripMenuItem257.Enabled = false;
			this.toolStripMenuItem257.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem257.Name = "toolStripMenuItem257";
			this.toolStripMenuItem257.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem257.Text = "Сервопривод 3";
			// 
			// toolStripMenuItem258
			// 
			this.toolStripMenuItem258.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem258.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem258.Name = "toolStripMenuItem258";
			this.toolStripMenuItem258.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem258.Text = "0°";
			// 
			// toolStripMenuItem259
			// 
			this.toolStripMenuItem259.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem259.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem259.Name = "toolStripMenuItem259";
			this.toolStripMenuItem259.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem259.Text = "90°";
			// 
			// toolStripMenuItem260
			// 
			this.toolStripMenuItem260.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem260.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem260.Name = "toolStripMenuItem260";
			this.toolStripMenuItem260.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem260.Text = "180°";
			// 
			// toolStripMenuItem261
			// 
			this.toolStripMenuItem261.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem261.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem261.Name = "toolStripMenuItem261";
			this.toolStripMenuItem261.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem261.Text = "270°";
			// 
			// toolStripMenuItem262
			// 
			this.toolStripMenuItem262.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem262.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem262.Name = "toolStripMenuItem262";
			this.toolStripMenuItem262.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem262.Text = "360°";
			// 
			// toolStripMenuItem263
			// 
			this.toolStripMenuItem263.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem263.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem264,
            this.toolStripMenuItem265,
            this.toolStripMenuItem266,
            this.toolStripMenuItem267,
            this.toolStripMenuItem268});
			this.toolStripMenuItem263.Enabled = false;
			this.toolStripMenuItem263.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem263.Name = "toolStripMenuItem263";
			this.toolStripMenuItem263.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem263.Text = "Сервопривод 4";
			// 
			// toolStripMenuItem264
			// 
			this.toolStripMenuItem264.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem264.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem264.Name = "toolStripMenuItem264";
			this.toolStripMenuItem264.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem264.Text = "0°";
			// 
			// toolStripMenuItem265
			// 
			this.toolStripMenuItem265.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem265.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem265.Name = "toolStripMenuItem265";
			this.toolStripMenuItem265.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem265.Text = "90°";
			// 
			// toolStripMenuItem266
			// 
			this.toolStripMenuItem266.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem266.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem266.Name = "toolStripMenuItem266";
			this.toolStripMenuItem266.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem266.Text = "180°";
			// 
			// toolStripMenuItem267
			// 
			this.toolStripMenuItem267.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem267.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem267.Name = "toolStripMenuItem267";
			this.toolStripMenuItem267.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem267.Text = "270°";
			// 
			// toolStripMenuItem268
			// 
			this.toolStripMenuItem268.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem268.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem268.Name = "toolStripMenuItem268";
			this.toolStripMenuItem268.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem268.Text = "360°";
			// 
			// toolStripDropDownButton20
			// 
			this.toolStripDropDownButton20.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton20.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem269,
            this.toolStripMenuItem272,
            this.toolStripMenuItem275,
            this.toolStripMenuItem278,
            this.toolStripMenuItem281,
            this.toolStripMenuItem284,
            this.toolStripMenuItem287});
			this.toolStripDropDownButton20.Enabled = false;
			this.toolStripDropDownButton20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton20.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton20.Image")));
			this.toolStripDropDownButton20.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton20.Name = "toolStripDropDownButton20";
			this.toolStripDropDownButton20.ShowDropDownArrow = false;
			this.toolStripDropDownButton20.Size = new System.Drawing.Size(121, 23);
			this.toolStripDropDownButton20.Text = "Выключатель";
			this.toolStripDropDownButton20.ToolTipText = "Пищалка";
			this.toolStripDropDownButton20.Visible = false;
			// 
			// toolStripMenuItem269
			// 
			this.toolStripMenuItem269.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem269.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem270,
            this.toolStripMenuItem271});
			this.toolStripMenuItem269.Enabled = false;
			this.toolStripMenuItem269.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem269.Name = "toolStripMenuItem269";
			this.toolStripMenuItem269.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem269.Text = "Реле 1";
			// 
			// toolStripMenuItem270
			// 
			this.toolStripMenuItem270.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem270.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem270.Name = "toolStripMenuItem270";
			this.toolStripMenuItem270.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem270.Text = "Включить";
			// 
			// toolStripMenuItem271
			// 
			this.toolStripMenuItem271.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem271.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem271.Name = "toolStripMenuItem271";
			this.toolStripMenuItem271.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem271.Text = "Выключить";
			// 
			// toolStripMenuItem272
			// 
			this.toolStripMenuItem272.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem272.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem273,
            this.toolStripMenuItem274});
			this.toolStripMenuItem272.Enabled = false;
			this.toolStripMenuItem272.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem272.Name = "toolStripMenuItem272";
			this.toolStripMenuItem272.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem272.Text = "Реле 2";
			// 
			// toolStripMenuItem273
			// 
			this.toolStripMenuItem273.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem273.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem273.Name = "toolStripMenuItem273";
			this.toolStripMenuItem273.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem273.Text = "Включить";
			// 
			// toolStripMenuItem274
			// 
			this.toolStripMenuItem274.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem274.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem274.Name = "toolStripMenuItem274";
			this.toolStripMenuItem274.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem274.Text = "Выключить";
			// 
			// toolStripMenuItem275
			// 
			this.toolStripMenuItem275.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem275.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem276,
            this.toolStripMenuItem277});
			this.toolStripMenuItem275.Enabled = false;
			this.toolStripMenuItem275.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem275.Name = "toolStripMenuItem275";
			this.toolStripMenuItem275.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem275.Text = "Реле 3";
			// 
			// toolStripMenuItem276
			// 
			this.toolStripMenuItem276.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem276.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem276.Name = "toolStripMenuItem276";
			this.toolStripMenuItem276.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem276.Text = "Включить";
			// 
			// toolStripMenuItem277
			// 
			this.toolStripMenuItem277.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem277.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem277.Name = "toolStripMenuItem277";
			this.toolStripMenuItem277.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem277.Text = "Выключить";
			// 
			// toolStripMenuItem278
			// 
			this.toolStripMenuItem278.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem278.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem279,
            this.toolStripMenuItem280});
			this.toolStripMenuItem278.Enabled = false;
			this.toolStripMenuItem278.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem278.Name = "toolStripMenuItem278";
			this.toolStripMenuItem278.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem278.Text = "Реле 4";
			// 
			// toolStripMenuItem279
			// 
			this.toolStripMenuItem279.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem279.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem279.Name = "toolStripMenuItem279";
			this.toolStripMenuItem279.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem279.Text = "Включить";
			// 
			// toolStripMenuItem280
			// 
			this.toolStripMenuItem280.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem280.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem280.Name = "toolStripMenuItem280";
			this.toolStripMenuItem280.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem280.Text = "Выключить";
			// 
			// toolStripMenuItem281
			// 
			this.toolStripMenuItem281.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem281.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem282,
            this.toolStripMenuItem283});
			this.toolStripMenuItem281.Enabled = false;
			this.toolStripMenuItem281.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem281.Name = "toolStripMenuItem281";
			this.toolStripMenuItem281.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem281.Text = "Реле 5";
			// 
			// toolStripMenuItem282
			// 
			this.toolStripMenuItem282.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem282.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem282.Name = "toolStripMenuItem282";
			this.toolStripMenuItem282.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem282.Text = "Включить";
			// 
			// toolStripMenuItem283
			// 
			this.toolStripMenuItem283.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem283.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem283.Name = "toolStripMenuItem283";
			this.toolStripMenuItem283.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem283.Text = "Выключить";
			// 
			// toolStripMenuItem284
			// 
			this.toolStripMenuItem284.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem284.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem285,
            this.toolStripMenuItem286});
			this.toolStripMenuItem284.Enabled = false;
			this.toolStripMenuItem284.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem284.Name = "toolStripMenuItem284";
			this.toolStripMenuItem284.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem284.Text = "Реле 6";
			// 
			// toolStripMenuItem285
			// 
			this.toolStripMenuItem285.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem285.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem285.Name = "toolStripMenuItem285";
			this.toolStripMenuItem285.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem285.Text = "Включить";
			// 
			// toolStripMenuItem286
			// 
			this.toolStripMenuItem286.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem286.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem286.Name = "toolStripMenuItem286";
			this.toolStripMenuItem286.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem286.Text = "Выключить";
			// 
			// toolStripMenuItem287
			// 
			this.toolStripMenuItem287.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem287.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem288,
            this.toolStripMenuItem289});
			this.toolStripMenuItem287.Enabled = false;
			this.toolStripMenuItem287.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem287.Name = "toolStripMenuItem287";
			this.toolStripMenuItem287.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem287.Text = "Реле 7";
			// 
			// toolStripMenuItem288
			// 
			this.toolStripMenuItem288.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem288.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem288.Name = "toolStripMenuItem288";
			this.toolStripMenuItem288.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem288.Text = "Включить";
			// 
			// toolStripMenuItem289
			// 
			this.toolStripMenuItem289.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem289.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem289.Name = "toolStripMenuItem289";
			this.toolStripMenuItem289.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem289.Text = "Выключить";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton21
			// 
			this.toolStripDropDownButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripDropDownButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem290,
            this.toolStripMenuItem291});
			this.toolStripDropDownButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton21.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton21.Image")));
			this.toolStripDropDownButton21.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton21.Name = "toolStripDropDownButton21";
			this.toolStripDropDownButton21.ShowDropDownArrow = false;
			this.toolStripDropDownButton21.Size = new System.Drawing.Size(81, 23);
			this.toolStripDropDownButton21.Text = "Помощь";
			// 
			// toolStripMenuItem290
			// 
			this.toolStripMenuItem290.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem290.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem290.Name = "toolStripMenuItem290";
			this.toolStripMenuItem290.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem290.Text = "О программе";
			// 
			// toolStripMenuItem291
			// 
			this.toolStripMenuItem291.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem291.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem291.Name = "toolStripMenuItem291";
			this.toolStripMenuItem291.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem291.Text = "Помощь";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton6,
            this.toolStripSeparator2,
            this.toolStripDropDownButton7});
			this.toolStrip1.Location = new System.Drawing.Point(3, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1039, 26);
			this.toolStrip1.TabIndex = 34;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
			this.toolStripDropDownButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.ShowDropDownArrow = false;
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(90, 23);
			this.toolStripDropDownButton1.Text = "Действия";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem5.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem5.Text = "Выход";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.DimGray;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem9,
            this.toolStripMenuItem12,
            this.toolStripMenuItem15});
			this.toolStripDropDownButton2.Enabled = false;
			this.toolStripDropDownButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.ShowDropDownArrow = false;
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(111, 23);
			this.toolStripDropDownButton2.Text = "Освещение";
			this.toolStripDropDownButton2.Visible = false;
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
			this.toolStripMenuItem6.Enabled = false;
			this.toolStripMenuItem6.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem6.Text = "Освещение 1";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem7.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem7.Text = "Включить";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem8.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem8.Text = "Выключить";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
			this.toolStripMenuItem9.Enabled = false;
			this.toolStripMenuItem9.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem9.Text = "Освещение 2";
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem10.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem10.Text = "Включить";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem11.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem11.Text = "Выключить";
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
			this.toolStripMenuItem12.Enabled = false;
			this.toolStripMenuItem12.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem12.Text = "Освещение 3";
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem13.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem13.Text = "Включить";
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem14.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem14.Text = "Выключить";
			// 
			// toolStripMenuItem15
			// 
			this.toolStripMenuItem15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
			this.toolStripMenuItem15.Enabled = false;
			this.toolStripMenuItem15.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			this.toolStripMenuItem15.Size = new System.Drawing.Size(189, 24);
			this.toolStripMenuItem15.Text = "Освещение 4";
			// 
			// toolStripMenuItem16
			// 
			this.toolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem16.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem16.Name = "toolStripMenuItem16";
			this.toolStripMenuItem16.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem16.Text = "Включить";
			// 
			// toolStripMenuItem17
			// 
			this.toolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem17.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem17.Name = "toolStripMenuItem17";
			this.toolStripMenuItem17.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem17.Text = "Выключить";
			// 
			// toolStripDropDownButton3
			// 
			this.toolStripDropDownButton3.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18,
            this.toolStripMenuItem24,
            this.toolStripMenuItem30});
			this.toolStripDropDownButton3.Enabled = false;
			this.toolStripDropDownButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton3.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
			this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			this.toolStripDropDownButton3.ShowDropDownArrow = false;
			this.toolStripDropDownButton3.Size = new System.Drawing.Size(75, 23);
			this.toolStripDropDownButton3.Text = "Спикер";
			this.toolStripDropDownButton3.ToolTipText = "Пищалка";
			this.toolStripDropDownButton3.Visible = false;
			// 
			// toolStripMenuItem18
			// 
			this.toolStripMenuItem18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem18.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23});
			this.toolStripMenuItem18.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem18.Name = "toolStripMenuItem18";
			this.toolStripMenuItem18.Size = new System.Drawing.Size(162, 24);
			this.toolStripMenuItem18.Text = "Писк BIOS";
			// 
			// toolStripMenuItem19
			// 
			this.toolStripMenuItem19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem19.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem19.Name = "toolStripMenuItem19";
			this.toolStripMenuItem19.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem19.Text = "1 пик";
			// 
			// toolStripMenuItem20
			// 
			this.toolStripMenuItem20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem20.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem20.Name = "toolStripMenuItem20";
			this.toolStripMenuItem20.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem20.Text = "2 пика";
			// 
			// toolStripMenuItem21
			// 
			this.toolStripMenuItem21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem21.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem21.Name = "toolStripMenuItem21";
			this.toolStripMenuItem21.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem21.Text = "3 пика";
			// 
			// toolStripMenuItem22
			// 
			this.toolStripMenuItem22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem22.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem22.Name = "toolStripMenuItem22";
			this.toolStripMenuItem22.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem22.Text = "4 пика";
			// 
			// toolStripMenuItem23
			// 
			this.toolStripMenuItem23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem23.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem23.Name = "toolStripMenuItem23";
			this.toolStripMenuItem23.Size = new System.Drawing.Size(139, 24);
			this.toolStripMenuItem23.Text = "5 пиков";
			// 
			// toolStripMenuItem24
			// 
			this.toolStripMenuItem24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem24.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.toolStripMenuItem28,
            this.toolStripMenuItem29});
			this.toolStripMenuItem24.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem24.Name = "toolStripMenuItem24";
			this.toolStripMenuItem24.Size = new System.Drawing.Size(162, 24);
			this.toolStripMenuItem24.Text = "Писк 1 кГц";
			// 
			// toolStripMenuItem25
			// 
			this.toolStripMenuItem25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem25.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem25.Name = "toolStripMenuItem25";
			this.toolStripMenuItem25.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem25.Text = "100 Мс";
			// 
			// toolStripMenuItem26
			// 
			this.toolStripMenuItem26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem26.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem26.Name = "toolStripMenuItem26";
			this.toolStripMenuItem26.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem26.Text = "250 Мс";
			// 
			// toolStripMenuItem27
			// 
			this.toolStripMenuItem27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem27.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem27.Name = "toolStripMenuItem27";
			this.toolStripMenuItem27.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem27.Text = "500 Мс";
			// 
			// toolStripMenuItem28
			// 
			this.toolStripMenuItem28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem28.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem28.Name = "toolStripMenuItem28";
			this.toolStripMenuItem28.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem28.Text = "1 Секунда";
			// 
			// toolStripMenuItem29
			// 
			this.toolStripMenuItem29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem29.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem29.Name = "toolStripMenuItem29";
			this.toolStripMenuItem29.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem29.Text = "2 Секунды";
			// 
			// toolStripMenuItem30
			// 
			this.toolStripMenuItem30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem30.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem31,
            this.toolStripMenuItem32,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34,
            this.toolStripMenuItem35});
			this.toolStripMenuItem30.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem30.Name = "toolStripMenuItem30";
			this.toolStripMenuItem30.Size = new System.Drawing.Size(162, 24);
			this.toolStripMenuItem30.Text = "Писк 2 кГц";
			// 
			// toolStripMenuItem31
			// 
			this.toolStripMenuItem31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem31.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem31.Name = "toolStripMenuItem31";
			this.toolStripMenuItem31.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem31.Text = "100 Мс";
			// 
			// toolStripMenuItem32
			// 
			this.toolStripMenuItem32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem32.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem32.Name = "toolStripMenuItem32";
			this.toolStripMenuItem32.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem32.Text = "250 Мс";
			// 
			// toolStripMenuItem33
			// 
			this.toolStripMenuItem33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem33.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem33.Name = "toolStripMenuItem33";
			this.toolStripMenuItem33.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem33.Text = "500 Мс";
			// 
			// toolStripMenuItem34
			// 
			this.toolStripMenuItem34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem34.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem34.Name = "toolStripMenuItem34";
			this.toolStripMenuItem34.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem34.Text = "1 Секунда";
			// 
			// toolStripMenuItem35
			// 
			this.toolStripMenuItem35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem35.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem35.Name = "toolStripMenuItem35";
			this.toolStripMenuItem35.Size = new System.Drawing.Size(163, 24);
			this.toolStripMenuItem35.Text = "2 Секунды";
			// 
			// toolStripDropDownButton4
			// 
			this.toolStripDropDownButton4.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem36,
            this.toolStripMenuItem40,
            this.toolStripMenuItem44,
            this.toolStripMenuItem48});
			this.toolStripDropDownButton4.Enabled = false;
			this.toolStripDropDownButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton4.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
			this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
			this.toolStripDropDownButton4.ShowDropDownArrow = false;
			this.toolStripDropDownButton4.Size = new System.Drawing.Size(134, 23);
			this.toolStripDropDownButton4.Text = "Электромотор";
			this.toolStripDropDownButton4.ToolTipText = "Пищалка";
			this.toolStripDropDownButton4.Visible = false;
			// 
			// toolStripMenuItem36
			// 
			this.toolStripMenuItem36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem36.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem37,
            this.toolStripMenuItem38,
            this.toolStripMenuItem39});
			this.toolStripMenuItem36.Enabled = false;
			this.toolStripMenuItem36.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem36.Name = "toolStripMenuItem36";
			this.toolStripMenuItem36.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem36.Text = "Мотор 1";
			// 
			// toolStripMenuItem37
			// 
			this.toolStripMenuItem37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem37.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem37.Name = "toolStripMenuItem37";
			this.toolStripMenuItem37.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem37.Text = "Включить";
			// 
			// toolStripMenuItem38
			// 
			this.toolStripMenuItem38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem38.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem38.Name = "toolStripMenuItem38";
			this.toolStripMenuItem38.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem38.Text = "Половина скорости";
			// 
			// toolStripMenuItem39
			// 
			this.toolStripMenuItem39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem39.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem39.Name = "toolStripMenuItem39";
			this.toolStripMenuItem39.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem39.Text = "Выключить";
			// 
			// toolStripMenuItem40
			// 
			this.toolStripMenuItem40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem40.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem41,
            this.toolStripMenuItem42,
            this.toolStripMenuItem43});
			this.toolStripMenuItem40.Enabled = false;
			this.toolStripMenuItem40.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem40.Name = "toolStripMenuItem40";
			this.toolStripMenuItem40.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem40.Text = "Мотор 2";
			// 
			// toolStripMenuItem41
			// 
			this.toolStripMenuItem41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem41.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem41.Name = "toolStripMenuItem41";
			this.toolStripMenuItem41.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem41.Text = "Включить";
			// 
			// toolStripMenuItem42
			// 
			this.toolStripMenuItem42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem42.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem42.Name = "toolStripMenuItem42";
			this.toolStripMenuItem42.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem42.Text = "Половина скорости";
			// 
			// toolStripMenuItem43
			// 
			this.toolStripMenuItem43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem43.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem43.Name = "toolStripMenuItem43";
			this.toolStripMenuItem43.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem43.Text = "Выключить";
			// 
			// toolStripMenuItem44
			// 
			this.toolStripMenuItem44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem44.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem45,
            this.toolStripMenuItem46,
            this.toolStripMenuItem47});
			this.toolStripMenuItem44.Enabled = false;
			this.toolStripMenuItem44.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem44.Name = "toolStripMenuItem44";
			this.toolStripMenuItem44.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem44.Text = "Мотор 3";
			// 
			// toolStripMenuItem45
			// 
			this.toolStripMenuItem45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem45.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem45.Name = "toolStripMenuItem45";
			this.toolStripMenuItem45.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem45.Text = "Включить";
			// 
			// toolStripMenuItem46
			// 
			this.toolStripMenuItem46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem46.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem46.Name = "toolStripMenuItem46";
			this.toolStripMenuItem46.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem46.Text = "Половина скорости";
			// 
			// toolStripMenuItem47
			// 
			this.toolStripMenuItem47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem47.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem47.Name = "toolStripMenuItem47";
			this.toolStripMenuItem47.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem47.Text = "Выключить";
			// 
			// toolStripMenuItem48
			// 
			this.toolStripMenuItem48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem48.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem51,
            this.toolStripMenuItem52,
            this.toolStripMenuItem53});
			this.toolStripMenuItem48.Enabled = false;
			this.toolStripMenuItem48.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem48.Name = "toolStripMenuItem48";
			this.toolStripMenuItem48.Size = new System.Drawing.Size(144, 24);
			this.toolStripMenuItem48.Text = "Мотор 4";
			// 
			// toolStripMenuItem51
			// 
			this.toolStripMenuItem51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem51.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem51.Name = "toolStripMenuItem51";
			this.toolStripMenuItem51.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem51.Text = "Включить";
			// 
			// toolStripMenuItem52
			// 
			this.toolStripMenuItem52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem52.ForeColor = System.Drawing.Color.Yellow;
			this.toolStripMenuItem52.Name = "toolStripMenuItem52";
			this.toolStripMenuItem52.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem52.Text = "Половина скорости";
			// 
			// toolStripMenuItem53
			// 
			this.toolStripMenuItem53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem53.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem53.Name = "toolStripMenuItem53";
			this.toolStripMenuItem53.Size = new System.Drawing.Size(240, 24);
			this.toolStripMenuItem53.Text = "Выключить";
			// 
			// toolStripDropDownButton5
			// 
			this.toolStripDropDownButton5.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem54,
            this.toolStripMenuItem60,
            this.toolStripMenuItem66,
            this.toolStripMenuItem72});
			this.toolStripDropDownButton5.Enabled = false;
			this.toolStripDropDownButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton5.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
			this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
			this.toolStripDropDownButton5.ShowDropDownArrow = false;
			this.toolStripDropDownButton5.Size = new System.Drawing.Size(125, 23);
			this.toolStripDropDownButton5.Text = "Сервопривод";
			this.toolStripDropDownButton5.ToolTipText = "Пищалка";
			this.toolStripDropDownButton5.Visible = false;
			// 
			// toolStripMenuItem54
			// 
			this.toolStripMenuItem54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem54.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem55,
            this.toolStripMenuItem56,
            this.toolStripMenuItem57,
            this.toolStripMenuItem58,
            this.toolStripMenuItem59});
			this.toolStripMenuItem54.Enabled = false;
			this.toolStripMenuItem54.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem54.Name = "toolStripMenuItem54";
			this.toolStripMenuItem54.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem54.Text = "Сервопривод 1";
			// 
			// toolStripMenuItem55
			// 
			this.toolStripMenuItem55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem55.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem55.Name = "toolStripMenuItem55";
			this.toolStripMenuItem55.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem55.Text = "0°";
			// 
			// toolStripMenuItem56
			// 
			this.toolStripMenuItem56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem56.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem56.Name = "toolStripMenuItem56";
			this.toolStripMenuItem56.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem56.Text = "90°";
			// 
			// toolStripMenuItem57
			// 
			this.toolStripMenuItem57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem57.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem57.Name = "toolStripMenuItem57";
			this.toolStripMenuItem57.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem57.Text = "180°";
			// 
			// toolStripMenuItem58
			// 
			this.toolStripMenuItem58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem58.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem58.Name = "toolStripMenuItem58";
			this.toolStripMenuItem58.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem58.Text = "270°";
			// 
			// toolStripMenuItem59
			// 
			this.toolStripMenuItem59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem59.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem59.Name = "toolStripMenuItem59";
			this.toolStripMenuItem59.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem59.Text = "360°";
			// 
			// toolStripMenuItem60
			// 
			this.toolStripMenuItem60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem60.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem61,
            this.toolStripMenuItem62,
            this.toolStripMenuItem63,
            this.toolStripMenuItem64,
            this.toolStripMenuItem65});
			this.toolStripMenuItem60.Enabled = false;
			this.toolStripMenuItem60.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem60.Name = "toolStripMenuItem60";
			this.toolStripMenuItem60.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem60.Text = "Сервопривод 2";
			// 
			// toolStripMenuItem61
			// 
			this.toolStripMenuItem61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem61.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem61.Name = "toolStripMenuItem61";
			this.toolStripMenuItem61.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem61.Text = "0°";
			// 
			// toolStripMenuItem62
			// 
			this.toolStripMenuItem62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem62.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem62.Name = "toolStripMenuItem62";
			this.toolStripMenuItem62.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem62.Text = "90°";
			// 
			// toolStripMenuItem63
			// 
			this.toolStripMenuItem63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem63.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem63.Name = "toolStripMenuItem63";
			this.toolStripMenuItem63.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem63.Text = "180°";
			// 
			// toolStripMenuItem64
			// 
			this.toolStripMenuItem64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem64.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem64.Name = "toolStripMenuItem64";
			this.toolStripMenuItem64.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem64.Text = "270°";
			// 
			// toolStripMenuItem65
			// 
			this.toolStripMenuItem65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem65.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem65.Name = "toolStripMenuItem65";
			this.toolStripMenuItem65.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem65.Text = "360°";
			// 
			// toolStripMenuItem66
			// 
			this.toolStripMenuItem66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem66.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem67,
            this.toolStripMenuItem68,
            this.toolStripMenuItem69,
            this.toolStripMenuItem70,
            this.toolStripMenuItem71});
			this.toolStripMenuItem66.Enabled = false;
			this.toolStripMenuItem66.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem66.Name = "toolStripMenuItem66";
			this.toolStripMenuItem66.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem66.Text = "Сервопривод 3";
			// 
			// toolStripMenuItem67
			// 
			this.toolStripMenuItem67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem67.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem67.Name = "toolStripMenuItem67";
			this.toolStripMenuItem67.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem67.Text = "0°";
			// 
			// toolStripMenuItem68
			// 
			this.toolStripMenuItem68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem68.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem68.Name = "toolStripMenuItem68";
			this.toolStripMenuItem68.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem68.Text = "90°";
			// 
			// toolStripMenuItem69
			// 
			this.toolStripMenuItem69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem69.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem69.Name = "toolStripMenuItem69";
			this.toolStripMenuItem69.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem69.Text = "180°";
			// 
			// toolStripMenuItem70
			// 
			this.toolStripMenuItem70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem70.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem70.Name = "toolStripMenuItem70";
			this.toolStripMenuItem70.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem70.Text = "270°";
			// 
			// toolStripMenuItem71
			// 
			this.toolStripMenuItem71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem71.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem71.Name = "toolStripMenuItem71";
			this.toolStripMenuItem71.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem71.Text = "360°";
			// 
			// toolStripMenuItem72
			// 
			this.toolStripMenuItem72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem72.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem73,
            this.toolStripMenuItem74,
            this.toolStripMenuItem75,
            this.toolStripMenuItem76,
            this.toolStripMenuItem77});
			this.toolStripMenuItem72.Enabled = false;
			this.toolStripMenuItem72.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem72.Name = "toolStripMenuItem72";
			this.toolStripMenuItem72.Size = new System.Drawing.Size(203, 24);
			this.toolStripMenuItem72.Text = "Сервопривод 4";
			// 
			// toolStripMenuItem73
			// 
			this.toolStripMenuItem73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem73.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem73.Name = "toolStripMenuItem73";
			this.toolStripMenuItem73.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem73.Text = "0°";
			// 
			// toolStripMenuItem74
			// 
			this.toolStripMenuItem74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem74.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem74.Name = "toolStripMenuItem74";
			this.toolStripMenuItem74.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem74.Text = "90°";
			// 
			// toolStripMenuItem75
			// 
			this.toolStripMenuItem75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem75.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem75.Name = "toolStripMenuItem75";
			this.toolStripMenuItem75.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem75.Text = "180°";
			// 
			// toolStripMenuItem76
			// 
			this.toolStripMenuItem76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem76.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem76.Name = "toolStripMenuItem76";
			this.toolStripMenuItem76.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem76.Text = "270°";
			// 
			// toolStripMenuItem77
			// 
			this.toolStripMenuItem77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem77.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem77.Name = "toolStripMenuItem77";
			this.toolStripMenuItem77.Size = new System.Drawing.Size(111, 24);
			this.toolStripMenuItem77.Text = "360°";
			// 
			// toolStripDropDownButton6
			// 
			this.toolStripDropDownButton6.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem78,
            this.toolStripMenuItem81,
            this.toolStripMenuItem84,
            this.toolStripMenuItem87,
            this.toolStripMenuItem90,
            this.toolStripMenuItem93,
            this.toolStripMenuItem292});
			this.toolStripDropDownButton6.Enabled = false;
			this.toolStripDropDownButton6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton6.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
			this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
			this.toolStripDropDownButton6.ShowDropDownArrow = false;
			this.toolStripDropDownButton6.Size = new System.Drawing.Size(121, 23);
			this.toolStripDropDownButton6.Text = "Выключатель";
			this.toolStripDropDownButton6.ToolTipText = "Пищалка";
			this.toolStripDropDownButton6.Visible = false;
			// 
			// toolStripMenuItem78
			// 
			this.toolStripMenuItem78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem78.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem79,
            this.toolStripMenuItem80});
			this.toolStripMenuItem78.Enabled = false;
			this.toolStripMenuItem78.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem78.Name = "toolStripMenuItem78";
			this.toolStripMenuItem78.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem78.Text = "Реле 1";
			// 
			// toolStripMenuItem79
			// 
			this.toolStripMenuItem79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem79.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem79.Name = "toolStripMenuItem79";
			this.toolStripMenuItem79.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem79.Text = "Включить";
			// 
			// toolStripMenuItem80
			// 
			this.toolStripMenuItem80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem80.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem80.Name = "toolStripMenuItem80";
			this.toolStripMenuItem80.Size = new System.Drawing.Size(166, 24);
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
			this.toolStripMenuItem81.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem81.Text = "Реле 2";
			// 
			// toolStripMenuItem82
			// 
			this.toolStripMenuItem82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem82.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem82.Name = "toolStripMenuItem82";
			this.toolStripMenuItem82.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem82.Text = "Включить";
			// 
			// toolStripMenuItem83
			// 
			this.toolStripMenuItem83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem83.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem83.Name = "toolStripMenuItem83";
			this.toolStripMenuItem83.Size = new System.Drawing.Size(166, 24);
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
			this.toolStripMenuItem84.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem84.Text = "Реле 3";
			// 
			// toolStripMenuItem85
			// 
			this.toolStripMenuItem85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem85.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem85.Name = "toolStripMenuItem85";
			this.toolStripMenuItem85.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem85.Text = "Включить";
			// 
			// toolStripMenuItem86
			// 
			this.toolStripMenuItem86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem86.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem86.Name = "toolStripMenuItem86";
			this.toolStripMenuItem86.Size = new System.Drawing.Size(166, 24);
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
			this.toolStripMenuItem87.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem87.Text = "Реле 4";
			// 
			// toolStripMenuItem88
			// 
			this.toolStripMenuItem88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem88.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem88.Name = "toolStripMenuItem88";
			this.toolStripMenuItem88.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem88.Text = "Включить";
			// 
			// toolStripMenuItem89
			// 
			this.toolStripMenuItem89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem89.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem89.Name = "toolStripMenuItem89";
			this.toolStripMenuItem89.Size = new System.Drawing.Size(166, 24);
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
			this.toolStripMenuItem90.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem90.Text = "Реле 5";
			// 
			// toolStripMenuItem91
			// 
			this.toolStripMenuItem91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem91.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem91.Name = "toolStripMenuItem91";
			this.toolStripMenuItem91.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem91.Text = "Включить";
			// 
			// toolStripMenuItem92
			// 
			this.toolStripMenuItem92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem92.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem92.Name = "toolStripMenuItem92";
			this.toolStripMenuItem92.Size = new System.Drawing.Size(166, 24);
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
			this.toolStripMenuItem93.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem93.Text = "Реле 6";
			// 
			// toolStripMenuItem94
			// 
			this.toolStripMenuItem94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem94.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem94.Name = "toolStripMenuItem94";
			this.toolStripMenuItem94.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem94.Text = "Включить";
			// 
			// toolStripMenuItem95
			// 
			this.toolStripMenuItem95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem95.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem95.Name = "toolStripMenuItem95";
			this.toolStripMenuItem95.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem95.Text = "Выключить";
			// 
			// toolStripMenuItem292
			// 
			this.toolStripMenuItem292.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem292.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem293,
            this.toolStripMenuItem294});
			this.toolStripMenuItem292.Enabled = false;
			this.toolStripMenuItem292.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem292.Name = "toolStripMenuItem292";
			this.toolStripMenuItem292.Size = new System.Drawing.Size(129, 24);
			this.toolStripMenuItem292.Text = "Реле 7";
			// 
			// toolStripMenuItem293
			// 
			this.toolStripMenuItem293.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem293.ForeColor = System.Drawing.Color.Lime;
			this.toolStripMenuItem293.Name = "toolStripMenuItem293";
			this.toolStripMenuItem293.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem293.Text = "Включить";
			// 
			// toolStripMenuItem294
			// 
			this.toolStripMenuItem294.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem294.ForeColor = System.Drawing.Color.Red;
			this.toolStripMenuItem294.Name = "toolStripMenuItem294";
			this.toolStripMenuItem294.Size = new System.Drawing.Size(166, 24);
			this.toolStripMenuItem294.Text = "Выключить";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripDropDownButton7
			// 
			this.toolStripDropDownButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem295,
            this.toolStripMenuItem296});
			this.toolStripDropDownButton7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripDropDownButton7.ForeColor = System.Drawing.Color.Silver;
			this.toolStripDropDownButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton7.Image")));
			this.toolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton7.Name = "toolStripDropDownButton7";
			this.toolStripDropDownButton7.ShowDropDownArrow = false;
			this.toolStripDropDownButton7.Size = new System.Drawing.Size(81, 23);
			this.toolStripDropDownButton7.Text = "Помощь";
			// 
			// toolStripMenuItem295
			// 
			this.toolStripMenuItem295.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem295.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem295.Name = "toolStripMenuItem295";
			this.toolStripMenuItem295.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem295.Text = "О программе";
			// 
			// toolStripMenuItem296
			// 
			this.toolStripMenuItem296.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripMenuItem296.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.toolStripMenuItem296.Name = "toolStripMenuItem296";
			this.toolStripMenuItem296.Size = new System.Drawing.Size(190, 24);
			this.toolStripMenuItem296.Text = "Помощь";
			// 
			// tabPage0
			// 
			this.tabPage0.Controls.Add(this.materialLabel2);
			this.tabPage0.Controls.Add(this.materialComboBox6);
			this.tabPage0.Controls.Add(this.materialComboBox5);
			this.tabPage0.Controls.Add(this.connect_materialButton3);
			this.tabPage0.Location = new System.Drawing.Point(4, 22);
			this.tabPage0.Name = "tabPage0";
			this.tabPage0.Size = new System.Drawing.Size(1045, 491);
			this.tabPage0.TabIndex = 4;
			this.tabPage0.Text = "Настройки МК";
			this.tabPage0.UseVisualStyleBackColor = true;
			// 
			// connect_materialButton3
			// 
			this.connect_materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.connect_materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.connect_materialButton3.Depth = 0;
			this.connect_materialButton3.HighEmphasis = true;
			this.connect_materialButton3.Icon = null;
			this.connect_materialButton3.Location = new System.Drawing.Point(67, 228);
			this.connect_materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.connect_materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.connect_materialButton3.Name = "connect_materialButton3";
			this.connect_materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
			this.connect_materialButton3.Size = new System.Drawing.Size(184, 36);
			this.connect_materialButton3.TabIndex = 0;
			this.connect_materialButton3.Text = "Подключиться к МК";
			this.connect_materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.connect_materialButton3.UseAccentColor = false;
			this.connect_materialButton3.UseVisualStyleBackColor = true;
			// 
			// materialComboBox5
			// 
			this.materialComboBox5.AutoResize = false;
			this.materialComboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox5.Depth = 0;
			this.materialComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox5.DropDownHeight = 174;
			this.materialComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox5.DropDownWidth = 121;
			this.materialComboBox5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox5.FormattingEnabled = true;
			this.materialComboBox5.IntegralHeight = false;
			this.materialComboBox5.ItemHeight = 43;
			this.materialComboBox5.Location = new System.Drawing.Point(67, 115);
			this.materialComboBox5.MaxDropDownItems = 4;
			this.materialComboBox5.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox5.Name = "materialComboBox5";
			this.materialComboBox5.Size = new System.Drawing.Size(196, 49);
			this.materialComboBox5.StartIndex = 0;
			this.materialComboBox5.TabIndex = 1;
			// 
			// materialComboBox6
			// 
			this.materialComboBox6.AutoResize = false;
			this.materialComboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox6.Depth = 0;
			this.materialComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox6.DropDownHeight = 174;
			this.materialComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox6.DropDownWidth = 121;
			this.materialComboBox6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox6.FormattingEnabled = true;
			this.materialComboBox6.IntegralHeight = false;
			this.materialComboBox6.ItemHeight = 43;
			this.materialComboBox6.Location = new System.Drawing.Point(67, 170);
			this.materialComboBox6.MaxDropDownItems = 4;
			this.materialComboBox6.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox6.Name = "materialComboBox6";
			this.materialComboBox6.Size = new System.Drawing.Size(196, 49);
			this.materialComboBox6.StartIndex = 0;
			this.materialComboBox6.TabIndex = 2;
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.materialLabel2.Location = new System.Drawing.Point(14, 9);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(107, 19);
			this.materialLabel2.TabIndex = 3;
			this.materialLabel2.Text = "materialLabel2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1097, 687);
			this.Controls.Add(this.materialTabControl1);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.statusStrip1);
			this.DrawerTabControl = this.materialTabControl1;
			this.DrawerUseColors = true;
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
			this.contextMenuStrip1.ResumeLayout(false);
			this.materialTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
			this.toolStrip3.ResumeLayout(false);
			this.toolStrip3.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabPage0.ResumeLayout(false);
			this.tabPage0.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private SerialPort serialPort1;
        private Timer timer1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private Label label15;
		private NotifyIcon notifyIcon1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem toolStripMenuItem49;
		private ToolStripMenuItem toolStripMenuItem50;
		private Timer timer2;
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private TabPage tabPage1;
		private GroupBox groupBox4;
		private Label label11;
		private Label label12;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar9;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar10;
		private Label label13;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar11;
		private Label label14;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar12;
		private MaterialSkin.Controls.MaterialSlider materialSlider1;
		private GroupBox groupBox1;
		private Label label3;
		private Label label4;
		private Label label2;
		private Label label1;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar3;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar4;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
		private GroupBox groupBox5;
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
		private Label label22;
		private Label label20;
		private Label label21;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private TabPage tabPage2;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialButton materialButton2;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox4;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
		private TabPage tabPage4;
		private ToolStrip toolStrip2;
		private ToolStripDropDownButton toolStripDropDownButton8;
		private ToolStripMenuItem toolStripMenuItem96;
		private ToolStripMenuItem toolStripMenuItem97;
		private ToolStripComboBox toolStripComboBox3;
		private ToolStripMenuItem toolStripMenuItem98;
		private ToolStripComboBox toolStripComboBox4;
		private ToolStripMenuItem toolStripMenuItem99;
		private ToolStripMenuItem toolStripMenuItem100;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripDropDownButton toolStripDropDownButton9;
		private ToolStripMenuItem toolStripMenuItem101;
		private ToolStripMenuItem toolStripMenuItem102;
		private ToolStripMenuItem toolStripMenuItem103;
		private ToolStripMenuItem toolStripMenuItem104;
		private ToolStripMenuItem toolStripMenuItem105;
		private ToolStripMenuItem toolStripMenuItem106;
		private ToolStripMenuItem toolStripMenuItem107;
		private ToolStripMenuItem toolStripMenuItem108;
		private ToolStripMenuItem toolStripMenuItem109;
		private ToolStripMenuItem toolStripMenuItem110;
		private ToolStripMenuItem toolStripMenuItem111;
		private ToolStripMenuItem toolStripMenuItem112;
		private ToolStripDropDownButton toolStripDropDownButton10;
		private ToolStripMenuItem toolStripMenuItem113;
		private ToolStripMenuItem toolStripMenuItem114;
		private ToolStripMenuItem toolStripMenuItem115;
		private ToolStripMenuItem toolStripMenuItem116;
		private ToolStripMenuItem toolStripMenuItem117;
		private ToolStripMenuItem toolStripMenuItem118;
		private ToolStripMenuItem toolStripMenuItem119;
		private ToolStripMenuItem toolStripMenuItem120;
		private ToolStripMenuItem toolStripMenuItem121;
		private ToolStripMenuItem toolStripMenuItem122;
		private ToolStripMenuItem toolStripMenuItem123;
		private ToolStripMenuItem toolStripMenuItem124;
		private ToolStripMenuItem toolStripMenuItem125;
		private ToolStripMenuItem toolStripMenuItem126;
		private ToolStripMenuItem toolStripMenuItem127;
		private ToolStripMenuItem toolStripMenuItem128;
		private ToolStripMenuItem toolStripMenuItem129;
		private ToolStripMenuItem toolStripMenuItem130;
		private ToolStripDropDownButton toolStripDropDownButton11;
		private ToolStripMenuItem toolStripMenuItem131;
		private ToolStripMenuItem toolStripMenuItem132;
		private ToolStripMenuItem toolStripMenuItem133;
		private ToolStripMenuItem toolStripMenuItem134;
		private ToolStripMenuItem toolStripMenuItem135;
		private ToolStripMenuItem toolStripMenuItem136;
		private ToolStripMenuItem toolStripMenuItem137;
		private ToolStripMenuItem toolStripMenuItem138;
		private ToolStripMenuItem toolStripMenuItem139;
		private ToolStripMenuItem toolStripMenuItem140;
		private ToolStripMenuItem toolStripMenuItem141;
		private ToolStripMenuItem toolStripMenuItem142;
		private ToolStripMenuItem toolStripMenuItem143;
		private ToolStripMenuItem toolStripMenuItem144;
		private ToolStripMenuItem toolStripMenuItem145;
		private ToolStripMenuItem toolStripMenuItem146;
		private ToolStripDropDownButton toolStripDropDownButton12;
		private ToolStripMenuItem toolStripMenuItem147;
		private ToolStripMenuItem toolStripMenuItem148;
		private ToolStripMenuItem toolStripMenuItem149;
		private ToolStripMenuItem toolStripMenuItem150;
		private ToolStripMenuItem toolStripMenuItem151;
		private ToolStripMenuItem toolStripMenuItem152;
		private ToolStripMenuItem toolStripMenuItem153;
		private ToolStripMenuItem toolStripMenuItem154;
		private ToolStripMenuItem toolStripMenuItem155;
		private ToolStripMenuItem toolStripMenuItem156;
		private ToolStripMenuItem toolStripMenuItem157;
		private ToolStripMenuItem toolStripMenuItem158;
		private ToolStripMenuItem toolStripMenuItem159;
		private ToolStripMenuItem toolStripMenuItem160;
		private ToolStripMenuItem toolStripMenuItem161;
		private ToolStripMenuItem toolStripMenuItem162;
		private ToolStripMenuItem toolStripMenuItem163;
		private ToolStripMenuItem toolStripMenuItem164;
		private ToolStripMenuItem toolStripMenuItem165;
		private ToolStripMenuItem toolStripMenuItem166;
		private ToolStripMenuItem toolStripMenuItem167;
		private ToolStripMenuItem toolStripMenuItem168;
		private ToolStripMenuItem toolStripMenuItem169;
		private ToolStripMenuItem toolStripMenuItem170;
		private ToolStripDropDownButton toolStripDropDownButton13;
		private ToolStripMenuItem toolStripMenuItem171;
		private ToolStripMenuItem toolStripMenuItem172;
		private ToolStripMenuItem toolStripMenuItem173;
		private ToolStripMenuItem toolStripMenuItem174;
		private ToolStripMenuItem toolStripMenuItem175;
		private ToolStripMenuItem toolStripMenuItem176;
		private ToolStripMenuItem toolStripMenuItem177;
		private ToolStripMenuItem toolStripMenuItem178;
		private ToolStripMenuItem toolStripMenuItem179;
		private ToolStripMenuItem toolStripMenuItem180;
		private ToolStripMenuItem toolStripMenuItem181;
		private ToolStripMenuItem toolStripMenuItem182;
		private ToolStripMenuItem toolStripMenuItem183;
		private ToolStripMenuItem toolStripMenuItem184;
		private ToolStripMenuItem toolStripMenuItem185;
		private ToolStripMenuItem toolStripMenuItem186;
		private ToolStripMenuItem toolStripMenuItem187;
		private ToolStripMenuItem toolStripMenuItem188;
		private ToolStripMenuItem toolStripMenuItem189;
		private ToolStripMenuItem toolStripMenuItem190;
		private ToolStripMenuItem toolStripMenuItem191;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripDropDownButton toolStripDropDownButton14;
		private ToolStripMenuItem toolStripMenuItem192;
		private ToolStripMenuItem toolStripMenuItem193;
		private TabPage tabPage3;
		private GroupBox groupBox3;
		private Label label9;
		private Label label10;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar8;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar7;
		private Label label8;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar6;
		private Label label7;
		private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar5;
		private ToolStrip toolStrip1;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripMenuItem toolStripMenuItem5;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripDropDownButton toolStripDropDownButton2;
		private ToolStripMenuItem toolStripMenuItem6;
		private ToolStripMenuItem toolStripMenuItem7;
		private ToolStripMenuItem toolStripMenuItem8;
		private ToolStripMenuItem toolStripMenuItem9;
		private ToolStripMenuItem toolStripMenuItem10;
		private ToolStripMenuItem toolStripMenuItem11;
		private ToolStripMenuItem toolStripMenuItem12;
		private ToolStripMenuItem toolStripMenuItem13;
		private ToolStripMenuItem toolStripMenuItem14;
		private ToolStripMenuItem toolStripMenuItem15;
		private ToolStripMenuItem toolStripMenuItem16;
		private ToolStripMenuItem toolStripMenuItem17;
		private ToolStripDropDownButton toolStripDropDownButton3;
		private ToolStripMenuItem toolStripMenuItem18;
		private ToolStripMenuItem toolStripMenuItem19;
		private ToolStripMenuItem toolStripMenuItem20;
		private ToolStripMenuItem toolStripMenuItem21;
		private ToolStripMenuItem toolStripMenuItem22;
		private ToolStripMenuItem toolStripMenuItem23;
		private ToolStripMenuItem toolStripMenuItem24;
		private ToolStripMenuItem toolStripMenuItem25;
		private ToolStripMenuItem toolStripMenuItem26;
		private ToolStripMenuItem toolStripMenuItem27;
		private ToolStripMenuItem toolStripMenuItem28;
		private ToolStripMenuItem toolStripMenuItem29;
		private ToolStripMenuItem toolStripMenuItem30;
		private ToolStripMenuItem toolStripMenuItem31;
		private ToolStripMenuItem toolStripMenuItem32;
		private ToolStripMenuItem toolStripMenuItem33;
		private ToolStripMenuItem toolStripMenuItem34;
		private ToolStripMenuItem toolStripMenuItem35;
		private ToolStripDropDownButton toolStripDropDownButton4;
		private ToolStripMenuItem toolStripMenuItem36;
		private ToolStripMenuItem toolStripMenuItem37;
		private ToolStripMenuItem toolStripMenuItem38;
		private ToolStripMenuItem toolStripMenuItem39;
		private ToolStripMenuItem toolStripMenuItem40;
		private ToolStripMenuItem toolStripMenuItem41;
		private ToolStripMenuItem toolStripMenuItem42;
		private ToolStripMenuItem toolStripMenuItem43;
		private ToolStripMenuItem toolStripMenuItem44;
		private ToolStripMenuItem toolStripMenuItem45;
		private ToolStripMenuItem toolStripMenuItem46;
		private ToolStripMenuItem toolStripMenuItem47;
		private ToolStripMenuItem toolStripMenuItem48;
		private ToolStripMenuItem toolStripMenuItem51;
		private ToolStripMenuItem toolStripMenuItem52;
		private ToolStripMenuItem toolStripMenuItem53;
		private ToolStripDropDownButton toolStripDropDownButton5;
		private ToolStripMenuItem toolStripMenuItem54;
		private ToolStripMenuItem toolStripMenuItem55;
		private ToolStripMenuItem toolStripMenuItem56;
		private ToolStripMenuItem toolStripMenuItem57;
		private ToolStripMenuItem toolStripMenuItem58;
		private ToolStripMenuItem toolStripMenuItem59;
		private ToolStripMenuItem toolStripMenuItem60;
		private ToolStripMenuItem toolStripMenuItem61;
		private ToolStripMenuItem toolStripMenuItem62;
		private ToolStripMenuItem toolStripMenuItem63;
		private ToolStripMenuItem toolStripMenuItem64;
		private ToolStripMenuItem toolStripMenuItem65;
		private ToolStripMenuItem toolStripMenuItem66;
		private ToolStripMenuItem toolStripMenuItem67;
		private ToolStripMenuItem toolStripMenuItem68;
		private ToolStripMenuItem toolStripMenuItem69;
		private ToolStripMenuItem toolStripMenuItem70;
		private ToolStripMenuItem toolStripMenuItem71;
		private ToolStripMenuItem toolStripMenuItem72;
		private ToolStripMenuItem toolStripMenuItem73;
		private ToolStripMenuItem toolStripMenuItem74;
		private ToolStripMenuItem toolStripMenuItem75;
		private ToolStripMenuItem toolStripMenuItem76;
		private ToolStripMenuItem toolStripMenuItem77;
		private ToolStripDropDownButton toolStripDropDownButton6;
		private ToolStripMenuItem toolStripMenuItem78;
		private ToolStripMenuItem toolStripMenuItem79;
		private ToolStripMenuItem toolStripMenuItem80;
		private ToolStripMenuItem toolStripMenuItem81;
		private ToolStripMenuItem toolStripMenuItem82;
		private ToolStripMenuItem toolStripMenuItem83;
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
		private ToolStripMenuItem toolStripMenuItem292;
		private ToolStripMenuItem toolStripMenuItem293;
		private ToolStripMenuItem toolStripMenuItem294;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripDropDownButton toolStripDropDownButton7;
		private ToolStripMenuItem toolStripMenuItem295;
		private ToolStripMenuItem toolStripMenuItem296;
		private GroupBox groupBox2;
		private MaterialSkin.Controls.MaterialButton materialButton1;
		private Label label6;
		private Label label5;
		private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
		private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
		private ToolStrip toolStrip3;
		private ToolStripDropDownButton toolStripDropDownButton15;
		private ToolStripMenuItem toolStripMenuItem194;
		private ToolStripMenuItem toolStripMenuItem195;
		private ToolStripComboBox toolStripComboBox5;
		private ToolStripMenuItem toolStripMenuItem196;
		private ToolStripComboBox toolStripComboBox6;
		private ToolStripMenuItem toolStripMenuItem197;
		private ToolStripMenuItem toolStripMenuItem198;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripDropDownButton toolStripDropDownButton16;
		private ToolStripMenuItem toolStripMenuItem199;
		private ToolStripMenuItem toolStripMenuItem200;
		private ToolStripMenuItem toolStripMenuItem201;
		private ToolStripMenuItem toolStripMenuItem202;
		private ToolStripMenuItem toolStripMenuItem203;
		private ToolStripMenuItem toolStripMenuItem204;
		private ToolStripMenuItem toolStripMenuItem205;
		private ToolStripMenuItem toolStripMenuItem206;
		private ToolStripMenuItem toolStripMenuItem207;
		private ToolStripMenuItem toolStripMenuItem208;
		private ToolStripMenuItem toolStripMenuItem209;
		private ToolStripMenuItem toolStripMenuItem210;
		private ToolStripDropDownButton toolStripDropDownButton17;
		private ToolStripMenuItem toolStripMenuItem211;
		private ToolStripMenuItem toolStripMenuItem212;
		private ToolStripMenuItem toolStripMenuItem213;
		private ToolStripMenuItem toolStripMenuItem214;
		private ToolStripMenuItem toolStripMenuItem215;
		private ToolStripMenuItem toolStripMenuItem216;
		private ToolStripMenuItem toolStripMenuItem217;
		private ToolStripMenuItem toolStripMenuItem218;
		private ToolStripMenuItem toolStripMenuItem219;
		private ToolStripMenuItem toolStripMenuItem220;
		private ToolStripMenuItem toolStripMenuItem221;
		private ToolStripMenuItem toolStripMenuItem222;
		private ToolStripMenuItem toolStripMenuItem223;
		private ToolStripMenuItem toolStripMenuItem224;
		private ToolStripMenuItem toolStripMenuItem225;
		private ToolStripMenuItem toolStripMenuItem226;
		private ToolStripMenuItem toolStripMenuItem227;
		private ToolStripMenuItem toolStripMenuItem228;
		private ToolStripDropDownButton toolStripDropDownButton18;
		private ToolStripMenuItem toolStripMenuItem229;
		private ToolStripMenuItem toolStripMenuItem230;
		private ToolStripMenuItem toolStripMenuItem231;
		private ToolStripMenuItem toolStripMenuItem232;
		private ToolStripMenuItem toolStripMenuItem233;
		private ToolStripMenuItem toolStripMenuItem234;
		private ToolStripMenuItem toolStripMenuItem235;
		private ToolStripMenuItem toolStripMenuItem236;
		private ToolStripMenuItem toolStripMenuItem237;
		private ToolStripMenuItem toolStripMenuItem238;
		private ToolStripMenuItem toolStripMenuItem239;
		private ToolStripMenuItem toolStripMenuItem240;
		private ToolStripMenuItem toolStripMenuItem241;
		private ToolStripMenuItem toolStripMenuItem242;
		private ToolStripMenuItem toolStripMenuItem243;
		private ToolStripMenuItem toolStripMenuItem244;
		private ToolStripDropDownButton toolStripDropDownButton19;
		private ToolStripMenuItem toolStripMenuItem245;
		private ToolStripMenuItem toolStripMenuItem246;
		private ToolStripMenuItem toolStripMenuItem247;
		private ToolStripMenuItem toolStripMenuItem248;
		private ToolStripMenuItem toolStripMenuItem249;
		private ToolStripMenuItem toolStripMenuItem250;
		private ToolStripMenuItem toolStripMenuItem251;
		private ToolStripMenuItem toolStripMenuItem252;
		private ToolStripMenuItem toolStripMenuItem253;
		private ToolStripMenuItem toolStripMenuItem254;
		private ToolStripMenuItem toolStripMenuItem255;
		private ToolStripMenuItem toolStripMenuItem256;
		private ToolStripMenuItem toolStripMenuItem257;
		private ToolStripMenuItem toolStripMenuItem258;
		private ToolStripMenuItem toolStripMenuItem259;
		private ToolStripMenuItem toolStripMenuItem260;
		private ToolStripMenuItem toolStripMenuItem261;
		private ToolStripMenuItem toolStripMenuItem262;
		private ToolStripMenuItem toolStripMenuItem263;
		private ToolStripMenuItem toolStripMenuItem264;
		private ToolStripMenuItem toolStripMenuItem265;
		private ToolStripMenuItem toolStripMenuItem266;
		private ToolStripMenuItem toolStripMenuItem267;
		private ToolStripMenuItem toolStripMenuItem268;
		private ToolStripDropDownButton toolStripDropDownButton20;
		private ToolStripMenuItem toolStripMenuItem269;
		private ToolStripMenuItem toolStripMenuItem270;
		private ToolStripMenuItem toolStripMenuItem271;
		private ToolStripMenuItem toolStripMenuItem272;
		private ToolStripMenuItem toolStripMenuItem273;
		private ToolStripMenuItem toolStripMenuItem274;
		private ToolStripMenuItem toolStripMenuItem275;
		private ToolStripMenuItem toolStripMenuItem276;
		private ToolStripMenuItem toolStripMenuItem277;
		private ToolStripMenuItem toolStripMenuItem278;
		private ToolStripMenuItem toolStripMenuItem279;
		private ToolStripMenuItem toolStripMenuItem280;
		private ToolStripMenuItem toolStripMenuItem281;
		private ToolStripMenuItem toolStripMenuItem282;
		private ToolStripMenuItem toolStripMenuItem283;
		private ToolStripMenuItem toolStripMenuItem284;
		private ToolStripMenuItem toolStripMenuItem285;
		private ToolStripMenuItem toolStripMenuItem286;
		private ToolStripMenuItem toolStripMenuItem287;
		private ToolStripMenuItem toolStripMenuItem288;
		private ToolStripMenuItem toolStripMenuItem289;
		private ToolStripSeparator toolStripSeparator6;
		private ToolStripDropDownButton toolStripDropDownButton21;
		private ToolStripMenuItem toolStripMenuItem290;
		private ToolStripMenuItem toolStripMenuItem291;
		private TabPage tabPage0;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox5;
		private MaterialSkin.Controls.MaterialButton connect_materialButton3;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox6;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
	}
}

