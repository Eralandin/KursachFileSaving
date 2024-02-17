using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.POControlForms;
using KursachFileSaving.View.Forms.WorkTypesForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    public class POPresenter
    {
        private readonly IPOView _view;
        private List<PO> _poList;

        public int RowToDelete;
        public int RowToEdit;

        public POPresenter(IPOView view, List<PO> poList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _poList = poList;

            _view.Load += OnLoad;
            _view.AddPO += AddPO;
            _view.UpdatePO += UpdatePO;
            _view.DeletePO += DeletePO;
            _view.SearchTextChanged += OnSearch;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadPOs(_poList);
        }

        private void LoadPOs(List<PO> poList)
        {
            _view.ShowPOs(poList);
        }

        public void AddPO(object sender, EventArgs e)
        {
            POCM moduleForm = new POCM(_poList, RowToEdit);
            moduleForm.POMUpdateButton.Enabled = false;
            if (_poList.Count == 0)
            {
                moduleForm.POCodeTextBox.Text = 1.ToString();
            }
            else
            {
                moduleForm.POCodeTextBox.Text = (_poList.Last().POCode + 1).ToString();
            }
            moduleForm.POCodeTextBox.Enabled = false;
            moduleForm.ShowDialog();
            LoadPOs(_poList);
        }

        public void UpdatePO(object sender, EventArgs e)
        {
            POCM moduleForm = new POCM(_poList, RowToEdit);
            moduleForm.POCodeTextBox.Enabled = false;
            moduleForm.POCodeTextBox.Text = _poList[RowToEdit].POCode.ToString();
            moduleForm.PONameTextBox.Text = _poList[RowToEdit].POName.ToString();
            moduleForm.POMSaveButton.Enabled = false;
            moduleForm.ShowDialog();
            LoadPOs(_poList);
        }

        public void DeletePO(object sender, EventArgs e)
        {
            _poList.Remove(_poList[RowToDelete]);
            JsonFileManager.SavePOs(_poList, "data.json");
            LoadPOs(_poList);
        }

        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            // Например, фильтруем список должностей по названию или коду
            List<PO> filteredPOs = _poList.Where(po => po.POName.Contains(searchText) || po.POCode.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowPOs(filteredPOs);
        }
    }
}
