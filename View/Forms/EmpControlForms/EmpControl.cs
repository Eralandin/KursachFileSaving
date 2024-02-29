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

namespace KursachFileSaving.View.Forms.EmpControlForms
{
    public partial class EmpControl : Form, IECView
    {
        private readonly EmpControlPresenter _presenter;
        public EmpControl(List<Employees> empslist)
        {
            InitializeComponent();
            _presenter = new EmpControlPresenter(this, empslist);
            ShowEmps(empslist);
        }
        public event EventHandler Load;
        public event EventHandler AddEmp;
        public event EventHandler UpdateEmp;
        public event EventHandler DeleteEmp;
        public event EventHandler<SearchEventArgs> SearchTextChanged;
        public event EventHandler<string> MessageForm;

        public void MessageFormView(string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        public string SearchText => EmpsSearchTextBox.Text;
        public void ShowEmps(List<Employees> empslist)
        {
            if (empslist.Count == 0)
            {
                DGVEmps.Rows.Clear();
            }
            else
            {
                DGVEmps.Rows.Clear();
                for (int i = 0; i < empslist.Count; i++)
                {
                    DGVEmps.Rows.Add(i + 1, empslist[i].EmpCode, empslist[i].LastName, empslist[i].FirstName, empslist[i].Patronymic, empslist[i].Login, empslist[i].Email, empslist[i].JobCode, empslist[i].BlockCode);
                }
            }
        }

        private void DGVEmps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string colName = DGVEmps.Columns[e.ColumnIndex].Name;
                    if (colName == "Edit")
                    {
                        _presenter.RowToEdit = e.RowIndex;
                        UpdateEmp?.Invoke(sender, e);
                    }
                    else if (colName == "Delete")
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить этого сотрудника?", "Удаление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _presenter.RowToDelete = e.RowIndex;
                            DeleteEmp?.Invoke(sender, e);
                            MessageForm?.Invoke(this, "Сотрудник успешно удалён!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageForm?.Invoke(this, "Непредвиденная ошибка! " + ex.Message);
            }
        }

        private void EmpsAddButton_Click(object sender, EventArgs e)
        {
            AddEmp?.Invoke(sender, e);
        }

        private void EmpsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, new SearchEventArgs(EmpsSearchTextBox.Text));
        }
    }
}
