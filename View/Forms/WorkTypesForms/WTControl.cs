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

namespace KursachFileSaving.View.Forms.WorkTypesForms
{
    public partial class WTControl : Form, IWTView
    {
        private readonly WTPresenter _presenter;
        public WTControl(List<WorkType> WTsList)
        {
            SuspendLayout();
            InitializeComponent();
            _presenter = new WTPresenter(this, WTsList);
            ShowWTs(WTsList);
            ResumeLayout(true);
        }
        public event EventHandler Load;
        public event EventHandler AddWT;
        public event EventHandler UpdateWT;
        public event EventHandler DeleteWT;
        public event EventHandler<string> MessageForm;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public string SearchText => WTSearchTextBox.Text;
        public void ShowWTs(List<WorkType> WTs)
        {
            if (WTs.Count == 0)
            {
                DGVWTs.Rows.Clear();
            }
            else
            {
                DGVWTs.Rows.Clear();
                for (int i = 0; i < WTs.Count; i++)
                {
                    DGVWTs.Rows.Add(i + 1, WTs[i].WorkTypeCode, WTs[i].WorkTypeName, WTs[i].WorkTypeComm);
                }
            }
        }

        private void DGVWTs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = DGVWTs.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {
                    // Логика редактирования должности
                    _presenter.RowToEdit = e.RowIndex;
                    UpdateWT?.Invoke(sender, e);
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить этот тип работ?", "Удаление типа работ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Логика удаления должности
                        _presenter.RowToDelete = e.RowIndex;
                        DeleteWT?.Invoke(sender, e);
                        MessageBox.Show("Тип работ успешно удален!");
                    }
                }
            }
        }

        private void WTsAddButton_Click(object sender, EventArgs e)
        {
            AddWT?.Invoke(sender, e);
        }

        private void WTSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Получаем текст из текстового поля
            string searchText = WTSearchTextBox.Text;

            // Вызываем событие поиска и передаем текст для поиска
            SearchTextChanged?.Invoke(this, new SearchEventArgs(WTSearchTextBox.Text));
        }
    }
}
