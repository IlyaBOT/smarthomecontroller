using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using SmartHomeController.Properties;
using Microsoft.Win32;
using MaterialSkin.Controls;
using MaterialSkin;

namespace SmartHomeController
{
	public partial class MainForm : MaterialForm
    {
        private int baudRate = 115200; // Скорость передачи при запуске программы.

        private bool isConnected; // Статус подключения.
        private string selectedPort;
        private string regPath1 = (@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize");
        private string theme = "0";

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            RegistryKey currentUserKey = Registry.CurrentUser.OpenSubKey(regPath1);
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
                label15.Text = ("Версия Dev " + AssemblyVersion);
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                label15.Text = ("Version Dev " + AssemblyVersion);
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
			materialComboBox5.Items.Clear(); // Очищаем все COM-порты.
            foreach (var portName in portnames)
            {
				materialComboBox5.Items.Add(portName); // Добавляем доступные COM-порты в список.
                //Console.WriteLine(portnames.Length); // Выводим COM-порты в консоль [DEBUG ONLY].
                if (portnames[0] != null) materialComboBox5.SelectedItem = portnames[0];
            }

            baudRate = Convert.ToInt32(materialComboBox6.SelectedItem); // Устанавливаем скорость передачи.
			materialComboBox6.SelectedIndex = 1;
        }

        private void connectToArduino() // Connect function
        {
            isConnected = true; // Переменную подключения ставим равной true.
            baudRate = Convert.ToInt32(materialComboBox6.SelectedItem); // Устанавливаем скорость передачи.
            serialPort1.BaudRate = baudRate; // Устанавливаем скорость передачи.
            serialPort1.PortName = selectedPort; // Устанавливаем выбранный COM-порт.
            serialPort1.Open(); // Подключаемся к выбранному COM-порту.
            if (Properties.Settings.Default.lang == "RUS")
            {
				connect_materialButton3.Text =
                "Отключение от контроллера"; // Надпись на кнопке подключения ставим: Отключиться.
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
				connect_materialButton3.Text =
                "Disconnect from controller"; // Надпись на кнопке подключения ставим: Disconnect.
            }

			connect_materialButton3.Font = new Font("Century Gothic", 10);
			materialComboBox5.Enabled = false;
			materialComboBox6.Enabled = false;
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

            //serialPort1.Write("0,0"); // Бережённого бог бережёт :>
        }

        private void disconnectFromArduino() // Disconnect function
        {
            isConnected = false; // Переменную подключения ставим равной false.
            serialPort1.Close(); // Закрываем последовательный порт.

            if (Properties.Settings.Default.lang == "RUS")
            {
				connect_materialButton3.Text =
                "Подключение к контроллеру"; // Надпись на кнопке подключения ставим Подключиться.
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
				connect_materialButton3.Text =
                "Connecto to controller"; // Надпись на кнопке подключения ставим Connect.
            }

			connect_materialButton3.Font = new Font("Century Gothic", 10);
			materialComboBox5.Enabled = true;
			materialComboBox6.Enabled = true;
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
			materialSlider1.Enabled = false;
			materialSlider1.Visible = false;

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


        // Light
        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort1.Write("2," + materialSlider1.Value + ";");
        }


        // Buzzer
        private void materialButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1," + guna2NumericUpDown1.Value + "," + guna2NumericUpDown2.Value + ";");
        }


        // Motors
        private void guna2TrackBar5_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort1.Write("3," + guna2TrackBar5.Value + ";");
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3,1023;");
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3,512;");
        }

        private void toolStripMenuItem48_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3,0;");
        }


        // Servos
        private void guna2TrackBar12_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort1.Write("4," + guna2TrackBar12.Value + ";");
        }


        // Switches
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5,1;");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5,0;");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("6,1;");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("6,0;");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPort = Convert.ToString(materialComboBox5.SelectedItem); // Ставим значние переменной selectedPort равной выбранному COM-порту.
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudRate = Convert.ToInt32(materialComboBox6.SelectedItem); // Устанавливаем скорость передачи.
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
			materialComboBox5.Items.Clear(); // Очищаем все COM-порты.
            foreach (var portName in portnames)
				materialComboBox5.Items.Add(portName); // Добавляем доступные COM-порты в список.
			materialComboBox5.SelectedItem = selectedPort;
        }

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			materialSlider1.Value = 1023;
        }

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			materialSlider1.Value = 0;
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
            HelpForm help = new HelpForm();
            help.ShowDialog();

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
				materialSlider1.Visible = Properties.Settings.Default.light1;
				materialSlider1.Enabled = Properties.Settings.Default.light1;
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

                label19.Visible = Properties.Settings.Default.switch1;
                label19.Enabled = Properties.Settings.Default.switch1;
                guna2Button2.Visible = Properties.Settings.Default.switch1;
                guna2Button2.Enabled = Properties.Settings.Default.switch1;
                guna2Button3.Visible = Properties.Settings.Default.switch1;
                guna2Button3.Enabled = Properties.Settings.Default.switch1;
                label18.Visible = Properties.Settings.Default.switch2;
                label18.Enabled = Properties.Settings.Default.switch2;
                guna2Button4.Visible = Properties.Settings.Default.switch2;
                guna2Button4.Enabled = Properties.Settings.Default.switch2;
                guna2Button5.Visible = Properties.Settings.Default.switch2;
                guna2Button5.Enabled = Properties.Settings.Default.switch2;
                label16.Visible = Properties.Settings.Default.switch3;
                label16.Enabled = Properties.Settings.Default.switch3;
                guna2Button6.Visible = Properties.Settings.Default.switch3;
                guna2Button6.Enabled = Properties.Settings.Default.switch3;
                guna2Button7.Visible = Properties.Settings.Default.switch3;
                guna2Button7.Enabled = Properties.Settings.Default.switch3;
                label17.Visible = Properties.Settings.Default.switch4;
                label17.Enabled = Properties.Settings.Default.switch4;
                guna2Button8.Visible = Properties.Settings.Default.switch4;
                guna2Button8.Enabled = Properties.Settings.Default.switch4;
                guna2Button9.Visible = Properties.Settings.Default.switch4;
                guna2Button9.Enabled = Properties.Settings.Default.switch4;
                label20.Visible = Properties.Settings.Default.switch5;
                label20.Enabled = Properties.Settings.Default.switch5;
                guna2Button10.Visible = Properties.Settings.Default.switch5;
                guna2Button10.Enabled = Properties.Settings.Default.switch5;
                guna2Button11.Visible = Properties.Settings.Default.switch5;
                guna2Button11.Enabled = Properties.Settings.Default.switch5;
                label21.Visible = Properties.Settings.Default.switch6;
                label21.Enabled = Properties.Settings.Default.switch6;
                guna2Button12.Visible = Properties.Settings.Default.switch6;
                guna2Button12.Enabled = Properties.Settings.Default.switch6;
                guna2Button13.Visible = Properties.Settings.Default.switch6;
                guna2Button13.Enabled = Properties.Settings.Default.switch6;
                label22.Visible = Properties.Settings.Default.switch7;
                label22.Enabled = Properties.Settings.Default.switch7;
                guna2Button14.Visible = Properties.Settings.Default.switch7;
                guna2Button14.Enabled = Properties.Settings.Default.switch7;
                guna2Button15.Visible = Properties.Settings.Default.switch7;
                guna2Button15.Enabled = Properties.Settings.Default.switch7;


                if (Properties.Settings.Default.switch1 == false && Properties.Settings.Default.switch2 == false && Properties.Settings.Default.switch3 == false && Properties.Settings.Default.switch4 == false && Properties.Settings.Default.switch5 == false && Properties.Settings.Default.switch6 == false && Properties.Settings.Default.switch7 == false)
                {
                    groupBox5.Visible = false;
                    groupBox5.Enabled = false;
                }
                else
                {
                    groupBox5.Visible = true;
                    groupBox5.Enabled = true;
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
	
        private void lang_change()
		{
            if (Properties.Settings.Default.lang == "RUS")
            {
                toolStripDropDownButton1.Text = "Действия";
				materialLabel2.Text = "Параметры подключения";
				connect_materialButton3.Text = "Подключение к контроллеру";
            }
            else if (Properties.Settings.Default.lang == "ENG")
            {
                toolStripDropDownButton1.Text = "Actions";
				materialLabel2.Text = "Connection options";
				connect_materialButton3.Text = "Connect to controller";
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        private void MainForm_Activated(object sender, EventArgs e)
		{
            settings_load();
        }

		private void materialButton2_Click(object sender, EventArgs e)
		{

		}

		private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (materialTabControl1.SelectedIndex == 1) {
                if (Properties.Settings.Default.lang == "RUS")
                {
                    materialComboBox1.SelectedIndex = 0;
                }
                else if (Properties.Settings.Default.lang == "ENG")
                {
                    materialComboBox1.SelectedIndex = 1;
                }

                if (Properties.Settings.Default.theme == true)
                {
                    materialComboBox2.SelectedIndex = 1;
                }
                else if (Properties.Settings.Default.theme == false)
                {
                    materialComboBox2.SelectedIndex = 0;
                }
            }
		}

		/*
		// Text-боксы

		textBox1.Text = Properties.Settings.Default.name_light1;
		textBox2.Text = Properties.Settings.Default.name_light2;
		textBox4.Text = Properties.Settings.Default.name_light3;
		textBox3.Text = Properties.Settings.Default.name_light4;

		textBox9.Text = Properties.Settings.Default.name_buzzer;

		textBox8.Text = Properties.Settings.Default.name_motor1;
		textBox7.Text = Properties.Settings.Default.name_motor2;
		textBox6.Text = Properties.Settings.Default.name_motor3;
		textBox5.Text = Properties.Settings.Default.name_motor4;

		textBox13.Text = Properties.Settings.Default.name_servo1;
		textBox12.Text = Properties.Settings.Default.name_servo2;
		textBox11.Text = Properties.Settings.Default.name_servo3;
		textBox10.Text = Properties.Settings.Default.name_servo4;

		// Label'ы

		label4.Text = Properties.Settings.Default.name_light1;
		label3.Text = Properties.Settings.Default.name_light2;
		label6.Text = Properties.Settings.Default.name_light3;
		label5.Text = Properties.Settings.Default.name_light4;

		label11.Text = Properties.Settings.Default.name_buzzer;

		label10.Text = Properties.Settings.Default.name_motor1;
		label9.Text = Properties.Settings.Default.name_motor2;
		label8.Text = Properties.Settings.Default.name_motor3;
		label7.Text = Properties.Settings.Default.name_motor4;

		label15.Text = Properties.Settings.Default.name_servo1;
		label14.Text = Properties.Settings.Default.name_servo2;
		label13.Text = Properties.Settings.Default.name_servo3;
		label12.Text = Properties.Settings.Default.name_servo4;

		// Check-боксы

		checkBox1.Checked = Properties.Settings.Default.light1;
		checkBox2.Checked = Properties.Settings.Default.light2;
		checkBox4.Checked = Properties.Settings.Default.light3;
		checkBox3.Checked = Properties.Settings.Default.light4;

		checkBox9.Checked = Properties.Settings.Default.buzzer;

		checkBox8.Checked = Properties.Settings.Default.motor1;
		checkBox7.Checked = Properties.Settings.Default.motor2;
		checkBox6.Checked = Properties.Settings.Default.motor3;
		checkBox5.Checked = Properties.Settings.Default.motor4;

		checkBox13.Checked = Properties.Settings.Default.servo1;
		checkBox12.Checked = Properties.Settings.Default.servo2;
		checkBox11.Checked = Properties.Settings.Default.servo3;
		checkBox10.Checked = Properties.Settings.Default.servo4;
	}
	private void settings_save()
	{
		if (comboBox1.SelectedIndex == 0)
		{
			Properties.Settings.Default.lang = "RUS";
		}
		else if (comboBox1.SelectedIndex == 1)
		{
			Properties.Settings.Default.lang = "ENG";
		}
		if (comboBox2.SelectedIndex == 0)
		{
			Properties.Settings.Default.theme = false;
		}
		else if (comboBox2.SelectedIndex == 1)
		{
			Properties.Settings.Default.theme = true;
		}

		// Text-боксы

		Properties.Settings.Default.name_light1 = textBox1.Text;
		Properties.Settings.Default.name_light2 = textBox2.Text;
		Properties.Settings.Default.name_light3 = textBox4.Text;
		Properties.Settings.Default.name_light4 = textBox3.Text;

		Properties.Settings.Default.name_buzzer = textBox9.Text;

		Properties.Settings.Default.name_motor1 = textBox8.Text;
		Properties.Settings.Default.name_motor2 = textBox7.Text;
		Properties.Settings.Default.name_motor3 = textBox6.Text;
		Properties.Settings.Default.name_motor4 = textBox5.Text;

		Properties.Settings.Default.name_servo1 = textBox13.Text;
		Properties.Settings.Default.name_servo2 = textBox12.Text;
		Properties.Settings.Default.name_servo3 = textBox11.Text;
		Properties.Settings.Default.name_servo4 = textBox10.Text;

		// Check-боксы

		Properties.Settings.Default.light1 = checkBox1.Checked;
		Properties.Settings.Default.light2 = checkBox2.Checked;
		Properties.Settings.Default.light3 = checkBox4.Checked;
		Properties.Settings.Default.light4 = checkBox3.Checked;

		Properties.Settings.Default.buzzer = checkBox9.Checked;

		Properties.Settings.Default.motor1 = checkBox8.Checked;
		Properties.Settings.Default.motor2 = checkBox7.Checked;
		Properties.Settings.Default.motor3 = checkBox6.Checked;
		Properties.Settings.Default.motor4 = checkBox5.Checked;

		Properties.Settings.Default.servo1 = checkBox13.Checked;
		Properties.Settings.Default.servo2 = checkBox12.Checked;
		Properties.Settings.Default.servo3 = checkBox11.Checked;
		Properties.Settings.Default.servo4 = checkBox10.Checked;

		Properties.Settings.Default.Save();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		settings_save();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		settings_save();
		this.Close();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		settings_save();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		settings_save();
		this.Close();*/
	}
}