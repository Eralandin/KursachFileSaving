using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachFileSaving.Presenter
{
    public class WTMPresenter
    {
        private readonly IWTMView _view;
        private List<WorkType> WTsData; // Список должностей, загруженных из JSON-файла
        public int RowToEdit;
        public WTMPresenter(IWTMView view, List<WorkType> wtsData, int rowtoedit)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            WTsData = wtsData;
            _view.SaveWT += SaveWT;
            _view.UpdateWT += UpdateWT;
            _view.MessageForm += MessageFormCreate;
            RowToEdit = rowtoedit;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void SaveWT(object sender, EventArgs e)
        {
            try
            {
                WorkType wt = new WorkType
                {
                    // Присваивание значений из представления
                    WorkTypeCode = int.Parse(_view.WorkTypeCode),
                    WorkTypeName = _view.WorkTypeName,
                    WorkTypeComm = _view.WorkTypeComm
                };
                WTsData.Add(wt);

                JsonFileManager.SaveWTs(WTsData, "data.json");
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
        private void UpdateWT(object sender, EventArgs e)
        {
            try
            {
                WorkType wt = new WorkType
                {
                    // Присваивание значений из представления
                    WorkTypeCode = int.Parse(_view.WorkTypeCode),
                    WorkTypeName = _view.WorkTypeName,
                    WorkTypeComm = _view.WorkTypeComm
                };
                WTsData.RemoveAt(RowToEdit);
                WTsData.Insert(RowToEdit, wt);
                JsonFileManager.SaveWTs(WTsData, "data.json");
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
    }
}
