using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
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
            RowToEdit = rowtoedit;
        }
        private void SaveWT(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.WorkTypeName))
            {
                MessageBox.Show("Введите название типа работ!");
                return;
            }
            else if (string.IsNullOrEmpty(_view.WorkTypeComm))
            {
                MessageBox.Show("Введите комментарий к типу работ!");
                return;
            }
            WorkType wt = new WorkType
            {
                // Присваивание значений из представления
                WorkTypeCode = int.Parse(_view.WorkTypeCode),
                WorkTypeName = _view.WorkTypeName,
                WorkTypeComm = _view.WorkTypeComm
            };
            WTsData.Add(wt);

            JsonFileManager.SaveWTs(WTsData, "data.json");

            // Оповещение пользователя об успешном сохранении
            MessageBox.Show("Новый тип работ успешно сохранён!");

            // Закрытие формы после сохранения
            _view.CloseForm();
        }
        private void UpdateWT(object sender, EventArgs e)
        {
            // Логика обновления выбранного типа работ
            // Проверка введенных данных
            if (string.IsNullOrEmpty(_view.WorkTypeName))
            {
                MessageBox.Show("Введите название типа работ!");
                return;
            }
            else if (string.IsNullOrEmpty(_view.WorkTypeComm))
            {
                MessageBox.Show("Введите комментарий к типу работ!");
                return;
            }
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
    }
}
