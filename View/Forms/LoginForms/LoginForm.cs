using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachFileSaving.View.Forms.LoginForms
{
    public partial class LoginForm : Form, ILoginFormView
    {
        private readonly LoginFormPresenter _presenter;
        private readonly MainForm _mainForm;
        public LoginForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            _presenter = new LoginFormPresenter(this);
            InitializeComponent();
        }
        public event EventHandler InitializeFile;
        public event EventHandler LoginAttempt;
        public event EventHandler LoginFailure;

        public void LoginSuccess(object sender, EventArgs e)
        {
            this.Visible = false;
            _mainForm.Show();
        }
        private void ClearLabelLogin_Click(object sender, EventArgs e)
        {
            LoginNameTextBox.Clear();
            LoginPasswordTextBox.Clear();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                LoginPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                LoginPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginAttempt?.Invoke(this, EventArgs.Empty);
        }

        public string GetLogin()
        {
            return LoginNameTextBox.Text;
        }

        public string GetPassword()
        {
            return LoginPasswordTextBox.Text;
        }

        public void ShowLoginFailureMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
