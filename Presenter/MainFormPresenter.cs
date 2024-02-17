using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;

namespace KursachFileSaving.Presenter
{
    public class MainFormPresenter
    {
        public List<Apps> Apps;
        public List<Blocks> Blocks;
        public List<Employees> Employees;
        public List<Jobs> Jobs;
        public List<Journal> Journals;
        public List<PO> POs;
        public List<WorkType> WorkTypesModel;
        private Form activeForm = null;

        private readonly IMainFormView _view;

        public MainFormPresenter(IMainFormView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public void InitializeData(List<Apps> apps, List<Blocks> blocks, List<Employees> employees, List<Jobs> jobs, List<Journal> journal, List<PO> po, List<WorkType> workTypesModel)
        {
            Apps = apps;
            Blocks = blocks;
            Employees = employees;
            Jobs = jobs;
            Journals = journal;
            POs = po;
            WorkTypesModel = workTypesModel;
        }

        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
