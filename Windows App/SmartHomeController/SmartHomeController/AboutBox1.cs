using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartHomeController
{
    internal partial class AboutBox1 : Form
    {
        bool btn_flag = false;
        string authors = "Создание программы и идея: IlyaBOT\r\nПомощь в рефакторинге кода: Ponfertato\r\n" +
            "Материальная поддержка: SuperNyanCat\r\nМоральная поддержка а так же оценивание: AndreyPon303 & Ponfertato\r\n" +
            "Источник моей головной и не только боли: Попытки сделать гибкое приложение как у Xiaomi, Google или Apple.";
        public AboutBox1()
        {
            InitializeComponent();
            Text = string.Format("О программе {0}", AssemblyTitle);
            labelProductName.Text = ("Название продукта: " + AssemblyProduct);
            labelVersion.Text = ("Версия: " + AssemblyVersion);
            labelCopyright.Text = ("Авторские права: " + AssemblyCopyright);
            labelCompanyName.Text = ("Автор: " + AssemblyCompany);
            textBoxDescription.Text = AssemblyDescription;
        }

        private void AboutBox1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {

        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") return titleAttribute.Title;
                }

                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyDescription
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

		#endregion

		private void button2_Click(object sender, EventArgs e)
		{
            if (!btn_flag)
            {
                textBoxDescription.Text = authors;
                button2.Text = "Описание";
                btn_flag = !btn_flag;
            }
            else {
                textBoxDescription.Text = AssemblyDescription;
                button2.Text = "Разработчики";
                btn_flag = !btn_flag;
            }
		}
	}
}