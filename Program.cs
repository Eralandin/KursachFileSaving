using KursachFileSaving.View.Forms;
using KursachFileSaving.View.Forms.JobsControlForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachFileSaving.View.Forms.LoginForms;


namespace KursachFileSaving
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm;
            MainForm mainForm = new MainForm(); // Создаем экземпляр MainForm
            loginForm = new LoginForm(mainForm); // Создаем экземпляр LoginForm и передаем в конструктор ссылку на MainForm

            // Запускаем приложение с LoginForm
            Application.Run(loginForm);
        }
    }
}
