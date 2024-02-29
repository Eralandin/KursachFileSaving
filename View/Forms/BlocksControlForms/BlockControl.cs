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

namespace KursachFileSaving.View.Forms.BlocksControlForms
{
    public partial class BlockControl : Form, IBCView
    {
        private readonly BCPresenter _presenter;

        public BlockControl(List<Blocks> blockslist)
        {
            InitializeComponent();
            _presenter = new BCPresenter(this, blockslist);
            ShowBlocks(blockslist);
        }
        public event EventHandler Load;
        public event EventHandler AddBlock;
        public event EventHandler UpdateBlock;
        public event EventHandler DeleteBlock;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;

        public void MessageFormView(string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        public string SearchText => BlocksSearchTextBox.Text;
        public void ShowBlocks(List<Blocks> blockslist)
        {
            if (blockslist.Count == 0)
            {
                DGVBlocks.Rows.Clear();
            }
            else
            {
                DGVBlocks.Rows.Clear();
                for (int i = 0; i < blockslist.Count; i++)
                {
                    DGVBlocks.Rows.Add(i + 1, blockslist[i].BlockCode, blockslist[i].Motherboard, blockslist[i].RAM, blockslist[i].Videocard, blockslist[i].BlockName, blockslist[i].POCode);
                }
            }
        }

        private void DGVBlocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = DGVBlocks.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {
                    _presenter.RowToEdit = e.RowIndex;
                    UpdateBlock?.Invoke(sender, e);
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить этот блок?", "Удаление блока", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _presenter.RowToDelete = e.RowIndex;
                        DeleteBlock?.Invoke(sender, e);
                        MessageForm.Invoke(this, "Блок успешно удалён!");
                    }
                }
            }
        }
        private void BlocksAddButton_Click(object sender, EventArgs e)
        {
            AddBlock?.Invoke(sender, e);
        }
        private void BlocksSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(BlocksSearchTextBox.Text));
        }
    }
}
