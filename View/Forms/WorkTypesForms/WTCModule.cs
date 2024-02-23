using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Models.Classes;
using KursachFileSaving.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachFileSaving.View.Forms.ConfirmationForms;

namespace KursachFileSaving.View.Forms.WorkTypesForms
{
    public partial class WTCModule : Form, IWTMView
    {
        private readonly WTMPresenter _presenter;
        public WTCModule(List<WorkType> wtsData, int rowtoedit)
        {
            InitializeComponent();
            _presenter = new WTMPresenter(this, wtsData, rowtoedit);
        }
        public string WorkTypeCode { get => WTCodeTextBox.Text; set => WTCodeTextBox.Text = value; }
        public string WorkTypeName { get => WTNameTextBox.Text; set => WTNameTextBox.Text = value; }
        public string WorkTypeComm { get => WTCommTextBox.Text; set => WTCommTextBox.Text = value; }

        public event EventHandler SaveWT;
        public event EventHandler UpdateWT;
        public event EventHandler Cancel;

        private void WTMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void CloseForm()
        {
            OperationConfirmedForm ocf = new OperationConfirmedForm();
            ocf.ShowDialog();
            this.Close();
        }

        private void WTMSaveButton_Click(object sender, EventArgs e)
        {
            SaveWT?.Invoke(this, EventArgs.Empty);
        }

        private void WTMUpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить этот тип работ?", "Обновление типа работ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateWT?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
