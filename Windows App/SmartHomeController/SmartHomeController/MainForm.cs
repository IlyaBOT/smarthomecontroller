using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using SmartHomeController.Properties;
using Microsoft.Win32;

namespace SmartHomeController
{
	public partial class MainForm : Form
    {
        private int baudRate = 115200; // Скорость передачи при запуске программы.

        private bool isConnected; // Статус подключения.
        private string selectedPort;
        private string regPath = (@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize");
        private string theme = "0";

        public MainForm()
        {
            InitializeComponent();
            RegistryKey currentUserKey = Registry.CurrentUser.OpenSubKey(regPath);
            if (currentUserKey != null)
            {
                theme = currentUserKey.GetValue("AppsUseLightTheme").ToString();
                currentUserKey.Close();
                if (theme == "1")
                {
                    notifyIcon1.Icon = Resources.SmartHomeController1;
                }
                else if (theme == "0")
                {
                    notifyIcon1.Icon = Resources.SmartHomeController_white;
                }
            }

            var logo = new Logo();
            logo.ShowDialog();

            notifyIcon1.Visible = true; // Делаем видимой иконку в трее

            if (Properties.Settings.Default.lang == "RUS")
            {
                label15.Text = ("Версия " + AssemblyVersion);
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                label15.Text = ("Version " + AssemblyVersion);
            }
            settings_load();
        }
        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var portnames = SerialPort.GetPortNames(); // Получаем список COM портов доступных в системе.
            if (portnames.Length == 0) // Проверяем есть ли доступные.
            {
                if (Properties.Settings.Default.lang == "RUS")
                {
                    MessageBox.Show("Ошибка: В системе не найдено ни однго COM порта!"); // Выводим сообщение об ошибке.
                }
                else if (Properties.Settings.Default.lang == "ENG")
                {
                    MessageBox.Show("ERROR: Any COM PORT not found!"); // Выводим сообщение об ошибке.
                }
            }
            toolStripComboBox1.Items.Clear(); // Очищаем все COM-порты.
            foreach (var portName in portnames)
            {
                toolStripComboBox1.Items.Add(portName); // Добавляем доступные COM-порты в список.
                //Console.WriteLine(portnames.Length); // Выводим COM-порты в консоль [DEBUG ONLY].
                if (portnames[0] != null) toolStripComboBox1.SelectedItem = portnames[0];
            }

            baudRate = Convert.ToInt32(toolStripComboBox2.SelectedItem); // Устанавливаем скорость передачи.
            toolStripComboBox2.SelectedIndex = 1;
        }

        private void connectToArduino() // Connect function
        {
            isConnected = true; // Переменную подключения ставим равной true.
            baudRate = Convert.ToInt32(toolStripComboBox2.SelectedItem); // Устанавливаем скорость передачи.
            serialPort1.BaudRate = baudRate; // Устанавливаем скорость передачи.
            serialPort1.PortName = selectedPort; // Устанавливаем выбранный COM-порт.
            serialPort1.Open(); // Подключаемся к выбранному COM-порту.
            if (Properties.Settings.Default.lang == "RUS")
            {
                отключениеОтКонтроллераToolStripMenuItem.Text =
                "Отключение от контроллера"; // Надпись на кнопке подключения ставим: Отключиться.
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                отключениеОтКонтроллераToolStripMenuItem.Text =
                "Disconnect from controller"; // Надпись на кнопке подключения ставим: Disconnect.
            }
            
            отключениеОтКонтроллераToolStripMenuItem.Font = new Font("Century Gothic", 10);
            toolStripComboBox1.Enabled = false;
            toolStripComboBox2.Enabled = false;
            if (Properties.Settings.Default.lang == "RUS")
            {
                toolStripStatusLabel1.Text = ("Подключён к " + selectedPort + " со скоростью " + baudRate + " бод");
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                toolStripStatusLabel1.Text = ("Conncted to " + selectedPort + " with " + baudRate + " baudrate");
            }
            timer1.Enabled = true;

            settings_load();

            guna2NumericUpDown1.ForeColor = Color.White;
            guna2NumericUpDown2.ForeColor = Color.White;

            //serialPort1.Write("0,0"); // Бережённого бог бережёт :>
        }

        private void disconnectFromArduino() // Disconnect function
        {
            isConnected = false; // Переменную подключения ставим равной false.
            serialPort1.Close(); // Закрываем последовательный порт.

            if (Properties.Settings.Default.lang == "RUS")
            {
                отключениеОтКонтроллераToolStripMenuItem.Text =
                "Подключение к контроллеру"; // Надпись на кнопке подключения ставим Подключиться.
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                отключениеОтКонтроллераToolStripMenuItem.Text =
                "Connecto to controller"; // Надпись на кнопке подключения ставим Connect.
            }
            
            отключениеОтКонтроллераToolStripMenuItem.Font = new Font("Century Gothic", 10);
            toolStripComboBox1.Enabled = true;
            toolStripComboBox2.Enabled = true;
            if (Properties.Settings.Default.lang == "RUS")
            {
                toolStripStatusLabel1.Text = ("Отключён");
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                toolStripStatusLabel1.Text = ("Disconnected");
            }
            
            timer1.Enabled = false;

            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            toolStripDropDownButton4.Enabled = false;
            toolStripDropDownButton2.Enabled = false;
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem14.Enabled = false;
            toolStripMenuItem15.Enabled = false;
            toolStripMenuItem16.Enabled = false;
            toolStripMenuItem17.Enabled = false;

            label1.Enabled = false;
            label1.Visible = false;
            guna2TrackBar1.Enabled = false;
            guna2TrackBar1.Visible = false;

            groupBox2.Enabled = false;
            groupBox2.Visible = false;

            groupBox3.Enabled = false;
            groupBox3.Visible = false;
            guna2TrackBar5.Enabled = false;
            guna2TrackBar5.Visible = false;
            guna2TrackBar6.Enabled = false;
            guna2TrackBar6.Visible = false;
            guna2TrackBar7.Enabled = false;
            guna2TrackBar7.Visible = false;
            guna2TrackBar8.Enabled = false;
            guna2TrackBar8.Visible = false;

            groupBox4.Enabled = false;
            groupBox4.Visible = false;
            guna2TrackBar12.Enabled = false;
            guna2TrackBar12.Visible = false;
            guna2TrackBar10.Enabled = false;
            guna2TrackBar10.Visible = false;
            guna2TrackBar11.Enabled = false;
            guna2TrackBar11.Visible = false;
            guna2TrackBar9.Enabled = false;
            guna2TrackBar9.Visible = false;

            toolStripDropDownButton4.Visible = false;
            toolStripDropDownButton4.Enabled = false;
            toolStripDropDownButton2.Visible = false;
            toolStripDropDownButton2.Enabled = false;
            toolStripDropDownButton5.Visible = false;
            toolStripDropDownButton5.Enabled = false;
        }

        private void отключениеОтКонтроллераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isConnected)
                connectToArduino();
            else
                disconnectFromArduino();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Write("2," + guna2TrackBar1.Value + ";");
            serialPort1.Write("3," + guna2TrackBar5.Value + ";");
            serialPort1.Write("4," + guna2TrackBar12.Value + ";");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPort = Convert.ToString(toolStripComboBox1.SelectedItem); // Ставим значние переменной selectedPort равной выбранному COM-порту.
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudRate = Convert.ToInt32(toolStripComboBox2.SelectedItem); // Устанавливаем скорость передачи.
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //terminalText = serialPort1.ReadExisting();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            var portnames = SerialPort.GetPortNames(); // Получаем список COM портов доступных в системе.
            if (portnames.Length == 0) // Проверяем есть ли доступные.
            {
                if (Properties.Settings.Default.lang == "RUS")
                {
                    MessageBox.Show("Ошибка: В системе не найдено ни однго COM порта!"); // Выводим сообщение об ошибке.
                }
                else if (Properties.Settings.Default.lang == "ENG")
                {
                    MessageBox.Show("ERROR: Any COM PORT not found!"); // Выводим сообщение об ошибке.
                }
            }
                    toolStripComboBox1.Items.Clear(); // Очищаем все COM-порты.
            foreach (var portName in portnames)
                toolStripComboBox1.Items.Add(portName); // Добавляем доступные COM-порты в список.
            toolStripComboBox1.SelectedItem = selectedPort;
        }

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
            guna2TrackBar1.Value = 1023;
        }

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
            guna2TrackBar1.Value = 0;
        }

		private void guna2Button1_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + guna2NumericUpDown1.Value + "," + guna2NumericUpDown2.Value + ";");
        }

		private void toolStripMenuItem21_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
        }

		private void toolStripMenuItem20_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
        }

		private void toolStripMenuItem19_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
        }

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
        }

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
            Thread.Sleep(200);
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
        }

		private void toolStripMenuItem22_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItem23_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 100 + ";");
        }

		private void toolStripMenuItem25_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 250 + ";");
        }

		private void toolStripMenuItem26_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 500 + ";");
        }

		private void toolStripMenuItem27_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 1000 + ";");
        }

		private void toolStripMenuItem28_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 1000 + "," + 2000 + ";");
        }

		private void toolStripMenuItem24_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 2000 + "," + 100 + ";");
        }

		private void toolStripMenuItem30_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 2000 + "," + 250 + ";");
        }

		private void toolStripMenuItem31_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 2000 + "," + 500 + ";");
        }

		private void toolStripMenuItem32_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 2000 + "," + 1000 + ";");
        }

		private void toolStripMenuItem33_Click(object sender, EventArgs e)
		{
            serialPort1.Write("1," + 2000 + "," + 2000 + ";");
        }

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            //this.ShowInTaskbar = true; // Возвращаем окно на панель задач.
            //WindowState = FormWindowState.Normal; // Разворачиваем окно
        }
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
        }      

        private void toolStripMenuItem50_Click(object sender, EventArgs e)
		{
            Application.Exit();
        }

		private void toolStripMenuItem49_Click(object sender, EventArgs e)
		{
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            //this.ShowInTaskbar = true; // Возвращаем окно на панель задач.
            //WindowState = FormWindowState.Normal; // Разворачиваем окно
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
            Properties.Settings.Default.Save();
        }
        private void settings_load()
        {
            if (isConnected)
            {
                //Включение и отключение устрйстройств в зависимости от настроек программы

                label1.Visible = Properties.Settings.Default.light1;
                label1.Enabled = Properties.Settings.Default.light1;
                guna2TrackBar1.Visible = Properties.Settings.Default.light1;
                guna2TrackBar1.Enabled = Properties.Settings.Default.light1;
                toolStripMenuItem2.Visible = Properties.Settings.Default.light1;
                toolStripMenuItem2.Enabled = Properties.Settings.Default.light1;
                label2.Visible = Properties.Settings.Default.light2;
                label2.Enabled = Properties.Settings.Default.light2;
                guna2TrackBar2.Visible = Properties.Settings.Default.light2;
                guna2TrackBar2.Enabled = Properties.Settings.Default.light2;
                toolStripMenuItem5.Visible = Properties.Settings.Default.light2;
                toolStripMenuItem5.Enabled = Properties.Settings.Default.light2;
                label4.Visible = Properties.Settings.Default.light3;
                label4.Enabled = Properties.Settings.Default.light3;
                guna2TrackBar4.Visible = Properties.Settings.Default.light3;
                guna2TrackBar4.Enabled = Properties.Settings.Default.light3;
                toolStripMenuItem8.Visible = Properties.Settings.Default.light3;
                toolStripMenuItem8.Enabled = Properties.Settings.Default.light3;
                label3.Visible = Properties.Settings.Default.light4;
                label3.Enabled = Properties.Settings.Default.light4;
                guna2TrackBar3.Visible = Properties.Settings.Default.light4;
                guna2TrackBar3.Enabled = Properties.Settings.Default.light4;
                toolStripMenuItem11.Visible = Properties.Settings.Default.light4;
                toolStripMenuItem11.Enabled = Properties.Settings.Default.light4;

                if (Properties.Settings.Default.light1 == false && Properties.Settings.Default.light2 == false && Properties.Settings.Default.light3 == false && Properties.Settings.Default.light4 == false)
                {
                    groupBox1.Visible = false;
                    groupBox1.Enabled = false;
                    toolStripDropDownButton4.Visible = false;
                    toolStripDropDownButton4.Enabled = false;
                }
                else
                {
                    groupBox1.Visible = true;
                    groupBox1.Enabled = true;
                    toolStripDropDownButton4.Visible = true;
                    toolStripDropDownButton4.Enabled = true;
                }

                groupBox2.Visible = Properties.Settings.Default.buzzer;
                groupBox2.Enabled = Properties.Settings.Default.buzzer;
                toolStripDropDownButton2.Visible = Properties.Settings.Default.buzzer;
                toolStripDropDownButton2.Enabled = Properties.Settings.Default.buzzer;

                label7.Visible = Properties.Settings.Default.motor1;
                label7.Enabled = Properties.Settings.Default.motor1;
                guna2TrackBar5.Visible = Properties.Settings.Default.motor1;
                guna2TrackBar5.Enabled = Properties.Settings.Default.motor1;
                toolStripMenuItem45.Visible = Properties.Settings.Default.motor1;
                toolStripMenuItem45.Enabled = Properties.Settings.Default.motor1;
                label8.Visible = Properties.Settings.Default.motor2;
                label8.Enabled = Properties.Settings.Default.motor2;
                guna2TrackBar6.Visible = Properties.Settings.Default.motor2;
                guna2TrackBar6.Enabled = Properties.Settings.Default.motor2;
                toolStripMenuItem41.Visible = Properties.Settings.Default.motor2;
                toolStripMenuItem41.Enabled = Properties.Settings.Default.motor2;
                label9.Visible = Properties.Settings.Default.motor3;
                label9.Enabled = Properties.Settings.Default.motor3;
                guna2TrackBar7.Visible = Properties.Settings.Default.motor3;
                guna2TrackBar7.Enabled = Properties.Settings.Default.motor3;
                toolStripMenuItem34.Visible = Properties.Settings.Default.motor3;
                toolStripMenuItem34.Enabled = Properties.Settings.Default.motor3;
                label10.Visible = Properties.Settings.Default.motor4;
                label10.Enabled = Properties.Settings.Default.motor4;
                guna2TrackBar8.Visible = Properties.Settings.Default.motor4;
                guna2TrackBar8.Enabled = Properties.Settings.Default.motor4;
                toolStripMenuItem29.Visible = Properties.Settings.Default.motor4;
                toolStripMenuItem29.Enabled = Properties.Settings.Default.motor4;

                if (Properties.Settings.Default.motor1 == false && Properties.Settings.Default.motor2 == false && Properties.Settings.Default.motor3 == false && Properties.Settings.Default.motor4 == false)
                {
                    groupBox3.Visible = false;
                    groupBox3.Enabled = false;
                    toolStripDropDownButton5.Visible = false;
                    toolStripDropDownButton5.Enabled = false;
                }
                else
                {
                    groupBox3.Visible = true;
                    groupBox3.Enabled = true;
                    toolStripDropDownButton5.Visible = true;
                    toolStripDropDownButton5.Enabled = true;
                }

                label14.Visible = Properties.Settings.Default.servo1;
                label14.Enabled = Properties.Settings.Default.servo1;
                guna2TrackBar12.Visible = Properties.Settings.Default.servo1;
                guna2TrackBar12.Enabled = Properties.Settings.Default.servo1;
                label13.Visible = Properties.Settings.Default.servo2;
                label13.Enabled = Properties.Settings.Default.servo2;
                guna2TrackBar11.Visible = Properties.Settings.Default.motor2;
                guna2TrackBar11.Enabled = Properties.Settings.Default.motor2;
                label11.Visible = Properties.Settings.Default.servo3;
                label11.Enabled = Properties.Settings.Default.servo3;
                guna2TrackBar10.Visible = Properties.Settings.Default.motor3;
                guna2TrackBar10.Enabled = Properties.Settings.Default.motor3;
                label12.Visible = Properties.Settings.Default.servo4;
                label12.Enabled = Properties.Settings.Default.servo4;
                guna2TrackBar9.Visible = Properties.Settings.Default.servo4;
                guna2TrackBar9.Enabled = Properties.Settings.Default.servo4;

                if (Properties.Settings.Default.servo1 == false && Properties.Settings.Default.servo2 == false && Properties.Settings.Default.servo3 == false && Properties.Settings.Default.servo4 == false)
                {
                    groupBox4.Visible = false;
                    groupBox4.Enabled = false;
                }
                else
                {
                    groupBox4.Visible = true;
                    groupBox4.Enabled = true;
                }
            }
                //Установка названий
                label1.Text = Properties.Settings.Default.name_light1;
                toolStripMenuItem2.Text = Properties.Settings.Default.name_light1;
                label2.Text = Properties.Settings.Default.name_light2;
                toolStripMenuItem5.Text = Properties.Settings.Default.name_light2;
                label4.Text = Properties.Settings.Default.name_light3;
                toolStripMenuItem8.Text = Properties.Settings.Default.name_light3;
                label3.Text = Properties.Settings.Default.name_light4;
                toolStripMenuItem11.Text = Properties.Settings.Default.name_light4;


                groupBox2.Text = Properties.Settings.Default.name_buzzer;
                toolStripDropDownButton2.Text = Properties.Settings.Default.name_buzzer;

                label7.Text = Properties.Settings.Default.name_motor1;
                toolStripMenuItem45.Text = Properties.Settings.Default.name_motor1;
                label8.Text = Properties.Settings.Default.name_motor2;
                toolStripMenuItem41.Text = Properties.Settings.Default.name_motor2;
                label9.Text = Properties.Settings.Default.name_motor3;
                toolStripMenuItem34.Text = Properties.Settings.Default.name_motor3;
                label10.Text = Properties.Settings.Default.name_motor4;
                toolStripMenuItem29.Text = Properties.Settings.Default.name_motor4;

                label14.Text = Properties.Settings.Default.name_servo1;
                label13.Text = Properties.Settings.Default.name_servo2;
                label11.Text = Properties.Settings.Default.name_servo3;
                label12.Text = Properties.Settings.Default.name_servo4;
        }
		private void timer2_Tick(object sender, EventArgs e)
		{
            settings_load();
        }

        private void lang_change()
		{
            if (Properties.Settings.Default.lang == "RUS")
            {
                toolStripDropDownButton1.Text = "Действия";
                параметрыПодключенияToolStripMenuItem.Text = "Параметрый подключения";
                отключениеОтКонтроллераToolStripMenuItem.Text = "Подключение к контроллеру";
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                toolStripDropDownButton1.Text = "Actions";
                параметрыПодключенияToolStripMenuItem.Text = "Connections options";
                отключениеОтКонтроллераToolStripMenuItem.Text = "Connect to controller";
            }
        }
    }
}