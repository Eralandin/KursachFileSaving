using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.ConfirmationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    internal class AppsControlModulePresenter
    {
        private readonly IACMView _view;
        private List<Apps> appsData;
        public int RowToEdit;
        public AppsControlModulePresenter(IACMView view, List<Apps> appsList, int rowtoedit)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            appsData = appsList;
            _view.SaveApp += SaveApp;
            _view.UpdateApp += UpdateApp;
            RowToEdit = rowtoedit;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void SaveApp(object sender, EventArgs e)
        {
            try
            {
                Apps app = new Apps
                {
                    // Присваивание значений из представления
                    AppCode = int.Parse(_view.AppCode),
                    AppComment = _view.AppComment,
                    Day = int.Parse(_view.Day),
                    Month = int.Parse(_view.Month),
                    Year = int.Parse(_view.Year),
                    BlockCode = int.Parse(_view.BlockCode),
                    WorkType = int.Parse(_view.WorkType.Split(new string[] { ". " }, StringSplitOptions.None)[0])
                };
                appsData.Add(app);

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
        private void UpdateApp(object sender, EventArgs e)
        {
            try
            {
                if (_view.BlockCode == "")
                {
                    _view.MessageFormView("Введите код блока!");
                    return;
                }
                if (_view.WorkType == "")
                {
                    _view.MessageFormView("Введите код типа работы!");
                    return;
                }

                Apps app = new Apps
                {
                    // Присваивание значений из представления
                    AppCode = int.Parse(_view.AppCode),
                    AppComment = _view.AppComment,
                    Day = int.Parse(_view.Day),
                    Month = int.Parse(_view.Month),
                    Year = int.Parse(_view.Year),
                    BlockCode = int.Parse(_view.BlockCode),
                    WorkType = int.Parse(_view.WorkType.Split(new string[] { ". " }, StringSplitOptions.None)[0])
                };
                appsData.RemoveAt(RowToEdit);
                appsData.Insert(RowToEdit, app);
                JsonFileManager.SaveApps(appsData, "data.json");

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
