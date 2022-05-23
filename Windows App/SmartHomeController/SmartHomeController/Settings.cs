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

			textBox1.Text = Properties.Settings.Default.name_light1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.name_light1 = textBox1.Text;
			Properties.Settings.Default.Save();
		}

		private void button4_Click(object sender, EventArgs e)
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
			Properties.Settings.Default.Save();
		}
	}
}
