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
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.View.Forms.BlocksControlForms
{
    public partial class BlockControlModule : Form, IBCMView
    {
        private readonly BCMPresenter _presenter;
        public List<PO> poList;
        public BlockControlModule(List<Blocks> blocksData, int rowtoedit)
        {
            InitializeComponent();
            poList = JsonFileManager.LoadData().Item6;
            _presenter = new BCMPresenter(this, blocksData, rowtoedit, poList);
            ShowPOs(poList);
            comboBox1.Items.Add(0);
            var filteredPOs = poList.Where(po => po.BlockCode == 0);
            foreach (PO pO in filteredPOs)
            {
                comboBox1.Items.Add(pO.POCode);
            }
        }
        public string BlockCode { get => BlockCodeTextBox.Text; set => BlockCodeTextBox.Text = value; }
        public string BlockName { get => BlockNameTextBox.Text; set => BlockNameTextBox.Text = value; }
        public string Motherboard { get => MotherBoardTextBox.Text; set => MotherBoardTextBox.Text = value; }
        public string RAM { get => RAMTextBox.Text; set => RAMTextBox.Text = value; }
        public string Videocard { get => VideocardTextBox.Text; set => VideocardTextBox.Text = value; }
        public string POCOde { get => comboBox1.Text; set => comboBox1.Text = value; }

        public event EventHandler SaveBlock;
        public event EventHandler UpdateBlock;
        public event EventHandler Cancel;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public string SearchText => POsBCMSearchTextBox.Text;
        public void CloseForm()
        {
            this.Close();
        }

        private void BCMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BCMUpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить этот блок?", "Обновление блока", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateBlock?.Invoke(this, EventArgs.Empty);
            }
        }

        private void BCMSaveButton_Click(object sender, EventArgs e)
        {
            SaveBlock?.Invoke(this, EventArgs.Empty);
        }

        private void POsBCMSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(POsBCMSearchTextBox.Text));
        }
        public void ShowPOs(List<PO> poList)
        {
            if (poList.Count == 0)
            {
                BCMPOsDGV.Rows.Clear();
            }
            else
            {
                BCMPOsDGV.Rows.Clear();
                for (int i = 0; i < poList.Count; i++)
                {
                    BCMPOsDGV.Rows.Add(i + 1, poList[i].POCode, poList[i].POName, poList[i].BlockCode);
                }
            }
        }
    }
}
