using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.Presenter;
using KursachFileSaving.View.Forms.ConfirmationForms;
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

namespace KursachFileSaving.View.Forms.POControlForms
{
    public partial class POControl : Form, IPOView
    {
        private readonly POPresenter _presenter;

        public POControl(List<PO> poList, List<Blocks> blocksList)
        {
            InitializeComponent();
            _presenter = new POPresenter(this, poList, blocksList);
            ShowPOs(poList);
        }
        public event EventHandler Load;
        public event EventHandler AddPO;
        public event EventHandler UpdatePO;
        public event EventHandler DeletePO;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;

        public string SearchText => POsSearchTextBox.Text;
        public void ShowPOs(List<PO> poList)
        {
            if (poList.Count == 0)
            {
                DGVPOs.Rows.Clear();
            }
            else
            {
                DGVPOs.Rows.Clear();
                for (int i = 0; i < poList.Count; i++)
                {
                    DGVPOs.Rows.Add(i + 1, poList[i].POCode, poList[i].POName, poList[i].BlockCode);
                }
            }
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void DGVPOs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = DGVPOs.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {
                    _presenter.RowToEdit = e.RowIndex;
                    _presenter.UpdatePO(sender, e);
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить это ПО?", "Удаление ПО", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _presenter.RowToDelete = e.RowIndex;
                        _presenter.DeletePO(sender, e);
                        MessageFormCreate(this, "ПО успешно удалено!");
                    }
                }
            }
        }
        private void POsAddButton_Click(object sender, EventArgs e)
        {
            AddPO?.Invoke(sender, e);
        }

        private void POsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(POsSearchTextBox.Text));
        }
    }
}
