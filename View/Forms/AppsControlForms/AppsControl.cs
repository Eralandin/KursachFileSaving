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

namespace KursachFileSaving.View.Forms.AppsControlForms
{
    public partial class AppsControl : Form, IACView
    {
        private readonly AppsControlPresenter _presenter;
        public AppsControl(List <Apps> appsList)
        {
            InitializeComponent();
            _presenter = new AppsControlPresenter(this, appsList);
            ShowApps(appsList);
        }
        public event EventHandler Load;
        public event EventHandler AddApp;
        public event EventHandler UpdateApp;
        public event EventHandler DeleteApp;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;
        public string SearchText => AppsSearchTextBox.Text;
        public void MessageFormView(string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        public void ShowApps(List<Apps> appsList)
        {
            if (appsList.Count == 0)
            {
                DGVApps.Rows.Clear();
            }
            else
            {
                DGVApps.Rows.Clear();
                for (int i = 0; i < appsList.Count; i++)
                {
                    DGVApps.Rows.Add(i + 1, appsList[i].AppCode, appsList[i].AppComment, appsList[i].Day, appsList[i].Month, appsList[i].Year, appsList[i].BlockCode, appsList[i].WorkType);
                }
            }
        }

        private void DGVApps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string colName = DGVApps.Columns[e.ColumnIndex].Name;
                    if (colName == "Edit")
                    {
                        _presenter.RowToEdit = e.RowIndex;
                        UpdateApp?.Invoke(sender, e);
                    }
                    else if (colName == "Delete")
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить эту заявку?", "Удаление заявки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _presenter.RowToDelete = e.RowIndex;
                            DeleteApp?.Invoke(sender, e);
                            MessageForm?.Invoke(this, "Заявка успешно удалена!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageForm?.Invoke(this, "Непредвиденная ошибка! " + ex.Message);
            }
        }

        private void AppsAddButton_Click(object sender, EventArgs e)
        {
            AddApp?.Invoke(sender, e);
        }

        private void AppsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(AppsSearchTextBox.Text));
        }
    }
}
