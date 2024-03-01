using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Presenter
{
    internal class JournalControlModulePresenter
    {
        private readonly IJournalControlModuleView _view;
        private List<Journal> journalData;
        private List<Apps> appsData;
        public JournalControlModulePresenter(IJournalControlModuleView view, List<Journal> journalList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            journalData = journalList;
            appsData = JsonFileManager.LoadApps();
            _view.CheckApp += CheckApp;
            _view.SaveJournal += SaveJournal;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void SaveJournal(object sender, EventArgs e)
        {
            try
            {
                Journal record = new Journal
                {
                    // Присваивание значений из представления
                    RecordCode = int.Parse(_view.RecordCode),
                    AppCode = int.Parse(_view.AppCode),
                    Commentary = _view.Commentary.ToString(),
                    Date = _view.Date,
                    BlockCode = int.Parse(_view.BlockCode),
                    DateEnd = _view.DateOfEnd.ToString(),
                    WorkCode = _view.WorkCode.ToString()
                };
                int index = appsData.FindIndex(app => app.AppCode == int.Parse(_view.AppCode));
                appsData.RemoveAt(index);
                journalData.Add(record);


                JsonFileManager.SaveJournal(journalData, "data.json");
                JsonFileManager.SaveApps(appsData, "data.json");

                // Закрытие формы после сохранения
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                _view.MessageFormView("Ошибка! " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }
        private void CheckApp(object sender, int checkingapp)
        {
            try
            {
                List<Apps> appsList = JsonFileManager.LoadApps();
                if (appsList.Any(app => app.AppCode == checkingapp))
                {
                    int index = appsList.FindIndex(app => app.AppCode == checkingapp);
                    _view.Date = appsList[index].Day.ToString() +"."+ appsList[index].Month.ToString() +"."+ appsList[index].Year.ToString();
                    _view.BlockCode = appsList[index].BlockCode.ToString();
                    _view.WorkCode = appsList[index].WorkType;
                }
                else
                {
                    throw new ArgumentException("Ошибка! Проверьте введённые данные в других разделах!");
                }
            }
            catch(Exception ex)
            {
                _view.MessageFormView("Непредвиденная ошибка (CheckApp)! " + ex.Message);
            }
        }
    }
}
