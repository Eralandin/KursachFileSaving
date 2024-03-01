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

namespace KursachFileSaving.View.Forms.JournalControlForms
{
    public partial class JournalControl : Form, IJournalControlView
    {
        private readonly JournalControlPresenter _presenter;
        public JournalControl(List<Journal> journalList)
        {
            InitializeComponent();
            _presenter = new JournalControlPresenter(this, journalList);
            ShowJournal(journalList);
        }
        public event EventHandler Load;
        public event EventHandler AddJournal;
        public event EventHandler DeleteJournal;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;
        public string SearchText => JournalSearchTextBox.Text;
        public void MessageFormView(string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        public void ShowJournal(List<Journal> journalList)
        {
            if (journalList.Count == 0)
            {
                DGVJournal.Rows.Clear();
            }
            else
            {
                DGVJournal.Rows.Clear();
                for (int i = 0; i < journalList.Count; i++)
                {
                    DGVJournal.Rows.Add(i + 1, journalList[i].RecordCode, journalList[i].BlockCode, journalList[i].WorkCode, journalList[i].AppCode, journalList[i].Commentary, journalList[i].Date, journalList[i].DateEnd);
                }
            }
        }

        private void DGVJournal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string colName = DGVJournal.Columns[e.ColumnIndex].Name;
                    if (colName == "Delete")
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _presenter.RowToDelete = e.RowIndex;
                            DeleteJournal?.Invoke(sender, e);
                            MessageForm?.Invoke(this, "Запись успешно удалена!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageForm?.Invoke(this, "Непредвиденная ошибка! " + ex.Message);
            }
        }

        private void JournalAddButton_Click(object sender, EventArgs e)
        {
            AddJournal?.Invoke(sender, e);
        }

        private void JournalSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(JournalSearchTextBox.Text));
        }
    }
}
