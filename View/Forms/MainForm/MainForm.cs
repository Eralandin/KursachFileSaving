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
using KursachFileSaving.View.Forms.BlocksControlForms;
using KursachFileSaving.View.Forms.EmpControlForms;
using KursachFileSaving.View.Forms.AppsControlForms;
using KursachFileSaving.View.Forms.JournalControlForms;

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
            Load?.Invoke(this,EventArgs.Empty);
        }
        public event EventHandler Load;
        

        private void MainFormClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            List<PO> poList = JsonFileManager.LoadPOs();
            List<Blocks> blocksList = JsonFileManager.LoadBlocks();
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new POControl(poList, blocksList), panel2);
            ResumeLayout(true);
        }

        private void PCsMainButton_Click(object sender, EventArgs e)
        {
            List<Blocks> blocks = JsonFileManager.LoadBlocks();
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new BlockControl(blocks), panel2);
            ResumeLayout(true);
        }

        private void EmployeesMainButton_Click(object sender, EventArgs e)
        {
            List<Employees> employees = JsonFileManager.LoadEmps();
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new EmpControl(employees), panel2);
            ResumeLayout(true);
        }

        private void AppsMainButton_Click(object sender, EventArgs e)
        {
            List<Apps> apps = JsonFileManager.LoadApps();
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new AppsControl(apps), panel2);
            ResumeLayout(true);
        }

        private void JournalMainButton_Click(object sender, EventArgs e)
        {
            List<Journal> journal = JsonFileManager.LoadJournal();
            NSTUMainLogo.Visible = false;
            NSTUMainLogo.Visible = false;
            SuspendLayout();
            _presenter.OpenChildForm(new JournalControl(journal), panel2);
            ResumeLayout(true);
        }
    }
}
