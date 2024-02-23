using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
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

namespace KursachFileSaving.View.Forms.POControlForms
{
    public partial class POCM : Form, IPOModuleView
    {
        private readonly POCMPresenter _presenter;
        public POCM(List<PO> poData, int rowtoedit, string blockcode)
        {
            InitializeComponent();
            _presenter = new POCMPresenter(this, poData, rowtoedit, int.Parse(blockcode));
            BlockCode = blockcode;
        }
        public string POCode { get => POCodeTextBox.Text; set => POCodeTextBox.Text = value; }
        public string POName { get => PONameTextBox.Text; set => PONameTextBox.Text = value; }
        public string BlockCode { get; set; }

        public event EventHandler SavePO;
        public event EventHandler UpdatePO;
        public event EventHandler Cancel;


        public void CloseForm()
        {
            this.Close();
        }

        private void POMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void POMSaveButton_Click(object sender, EventArgs e)
        {
            SavePO?.Invoke(this, EventArgs.Empty);
        }

        private void POMUpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить это ПО?", "Обновление ПО", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdatePO?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
