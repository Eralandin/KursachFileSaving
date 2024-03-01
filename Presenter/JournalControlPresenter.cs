using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.AppsControlForms;
using KursachFileSaving.View.Forms.ConfirmationForms;
using KursachFileSaving.View.Forms.JournalControlForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    internal class JournalControlPresenter
    {
        private readonly IJournalControlView _view;
        private List<Journal> _journalList;

        public int RowToDelete;
        public JournalControlPresenter(IJournalControlView view, List<Journal> journalList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _journalList = journalList;

            _view.Load += OnLoad;
            _view.AddJournal += AddJournal;
            _view.DeleteJournal += DeleteJournal;
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
            LoadJournal(_journalList);
        }
        private void LoadJournal(List<Journal> _journalList)
        {
            _view.ShowJournal(_journalList);
        }
        public void AddJournal(object sender, EventArgs e)
        {
            try
            {
                JournalControlModule moduleForm = new JournalControlModule(_journalList);
                if (_journalList.Count == 0)
                {
                    moduleForm.RecordCodeTextBox.Text = 1.ToString();
                }
                else
                {
                    moduleForm.RecordCodeTextBox.Text = (_journalList.Last().AppCode + 1).ToString();
                }
                moduleForm.RecordCodeTextBox.Enabled = false;
                moduleForm.DateEndTextBox.Text = DateTime.Now.ToString();
                moduleForm.BlockCodeTextBox.Enabled=false;
                moduleForm.DateEndTextBox.Enabled=false;
                moduleForm.DateBeginTextBox.Enabled=false;
                moduleForm.WorkTypeTextBox.Enabled=false;
                moduleForm.ShowDialog();
                LoadJournal(_journalList);
            }
            catch (Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        public void DeleteJournal(object sender, EventArgs e)
        {
            try
            {
                _journalList.Remove(_journalList[RowToDelete]);
                JsonFileManager.SaveJournal(_journalList, "data.json");
                LoadJournal(_journalList);
            }
            catch (Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            // Например, фильтруем список должностей по названию или коду
            List<Journal> filteredJournal = _journalList.Where(journal => journal.AppCode.ToString().Contains(searchText) || journal.BlockCode.ToString().Contains(searchText) || journal.RecordCode.ToString().Contains(searchText) || journal.WorkCode.ToString().Contains(searchText) || journal.Date.ToString().Contains(searchText) || journal.Commentary.ToString().Contains(searchText) || journal.DateEnd.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowJournal(filteredJournal);
        }
    }
}
