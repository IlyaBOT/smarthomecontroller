using System;
using System.Reflection;
using System.Windows.Forms;

namespace SmartHomeController
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();

            label1.Text = ("Ver. " + AssemblyVersion);

            Opacity = 0;
            timer2.Interval = 40;
            timer2.Enabled = true;
            timer2.Start();
            timer1.Interval = 4000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.05;
            }
            else
            {
                timer2.Stop();
                timer2.Enabled = false;
            }
        }

        private void Logo_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}