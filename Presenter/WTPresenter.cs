using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using KursachFileSaving.View.Forms.JobsControlForms;
using KursachFileSaving.View.Forms.WorkTypesForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    public class WTPresenter
    {
        private readonly IWTView _view;
        private List<WorkType> WTsList;
        public int RowToDelete;
        public int RowToEdit;

        public WTPresenter(IWTView view, List<WorkType> wtslist)
        {
            WTsList = wtslist;
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.Load += OnLoad;
            _view.AddWT += AddWT;
            _view.UpdateWT += UpdateWT;
            _view.DeleteWT += DeleteWT;
            _view.SearchTextChanged += OnSearch;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadWTs(WTsList);
        }
        private void LoadWTs(List<WorkType> wtslist)
        {
            _view.ShowWTs(wtslist);
        }
        public void AddWT(object sender, EventArgs e)
        {
            WTCModule moduleForm = new WTCModule(WTsList, RowToEdit);
            moduleForm.WTMUpdateButton.Enabled = false;
            if (WTsList.Count == 0)
            {
                moduleForm.WTCodeTextBox.Text = 1.ToString();
            }
            else
            {
                moduleForm.WTCodeTextBox.Text = (WTsList.Last().WorkTypeCode + 1).ToString();
            }
            moduleForm.WTCodeTextBox.Enabled = false;
            moduleForm.ShowDialog();
            LoadWTs(WTsList);
        }
        public void UpdateWT(object sender, EventArgs e)
        {
            WTCModule moduleForm = new WTCModule(WTsList, RowToEdit);
            moduleForm.WTCodeTextBox.Enabled = false;
            moduleForm.WTCodeTextBox.Text = WTsList[RowToEdit].WorkTypeCode.ToString();
            moduleForm.WTNameTextBox.Text = WTsList[RowToEdit].WorkTypeName.ToString();
            moduleForm.WTCommTextBox.Text = WTsList[RowToEdit].WorkTypeComm.ToString();
            moduleForm.WTMSaveButton.Enabled = false;
            moduleForm.ShowDialog();
            LoadWTs(WTsList);
        }
        public void DeleteWT(object sender, EventArgs e)
        {
            try
            {
                WTsList.Remove(WTsList[RowToDelete]);
                JsonFileManager.SaveWTs(WTsList, "data.json");
                LoadWTs(WTsList);
            }
            catch (Exception ex)
            {
                MessageFormCreate(this,"Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            // Например, фильтруем список должностей по названию или коду
            List<WorkType> filteredWTs = WTsList.Where(worktype => worktype.WorkTypeName.Contains(searchText) || worktype.WorkTypeCode.ToString().Contains(searchText) || worktype.WorkTypeComm.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowWTs(filteredWTs);
        }
    }
}
