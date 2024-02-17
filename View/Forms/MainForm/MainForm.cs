using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Presenter;
using KursachFileSaving.View.Forms.JobsControlForms;
using System.IO;
using KursachFileSaving.View.Forms.WorkTypesForms;
using KursachFileSaving.View.Forms.POControlForms;

namespace KursachFileSaving.View.Forms
{
    public partial class MainForm : Form, IMainFormView
    {
        private readonly MainFormPresenter _presenter;
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            _presenter = new MainFormPresenter(this);
            LoadDataFromJson();
        }
        private void LoadDataFromJson()
        {
            if (!File.Exists("data.json"))
            {
                // Создаем пустой файл data.json
                JsonFileManager.InitializeDataIfFileNotExists();
            }
            // Загрузка данных из файла data.json
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = JsonFileManager.LoadData();

            // Передача данных презентеру
            _presenter.InitializeData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }

        private void MainFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void JobsMainButton_Click(object sender, EventArgs e)
        {
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new JobsControl(_presenter.Jobs), panel2);
            ResumeLayout(true);
        }

        private void WorkTypesMainButton_Click(object sender, EventArgs e)
        {
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new WTControl(_presenter.WorkTypesModel), panel2);
            ResumeLayout(true);
        }

        private void POsMainButton_Click(object sender, EventArgs e)
        {
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new POControl(_presenter.POs), panel2);
            ResumeLayout(true);
        }
    }
}
