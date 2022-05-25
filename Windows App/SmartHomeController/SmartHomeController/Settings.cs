using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHomeController
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();

			if (Properties.Settings.Default.lang == "RUS")
			{
				comboBox1.SelectedIndex = 0;
			}
			else if (Properties.Settings.Default.lang == "ENG")
			{
				comboBox1.SelectedIndex = 1;
			}

			if (Properties.Settings.Default.theme == true)
			{
				comboBox2.SelectedIndex = 1;
			}
			else if (Properties.Settings.Default.theme == false)
			{
				comboBox2.SelectedIndex = 0;
			}

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
			this.Close();
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
	}
}
