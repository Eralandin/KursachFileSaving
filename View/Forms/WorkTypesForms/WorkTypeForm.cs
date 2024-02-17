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

namespace KursachFileSaving.View.Forms.WorkTypesForms
{
    public partial class WorkTypesForm : Form
    {
        private WorkTypesModel model;
        private WTPresenter presenter;
        public WorkTypesForm()
        {
            InitializeComponent();
            model = new WorkTypesModel();
            presenter = new WTPresenter(model);
            model.WTs.Add(new WorkType(23,"Work","Test"));
            for (int i = 1; i <= model.WTs.Count; i++)
            {
                DGVWTsForm.Rows.Add(i,model.WTs[i-1].WorkTypeCode, model.WTs[i - 1].WorkTypeName, model.WTs[i - 1].WorkTypeComm);
            }
        }

        private void DGVWTsForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVWTsForm.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

            }
            if (colName == "Delete")
            {
                model.WTs.RemoveAt(e.RowIndex);
                UpdateTable();
            }
        }
        private void UpdateTable()
        {
            DGVWTsForm.Rows.Clear();
            for (int i = 1; i <= model.WTs.Count; i++)
            {
                DGVWTsForm.Rows.Add(i, model.WTs[i - 1].WorkTypeCode, model.WTs[i - 1].WorkTypeName, model.WTs[i - 1].WorkTypeComm);
            }
        }
    }
}
