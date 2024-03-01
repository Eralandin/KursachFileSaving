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
    public class POCMPresenter
    {
        private readonly IPOModuleView _view;
        private List<PO> poData; // Список должностей, загруженных из JSON-файла
        public int RowToEdit;
        public int BlockCode;
        public POCMPresenter(IPOModuleView view, List<PO> podata, int rowtoedit, int blockcode)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            poData = podata;
            _view.SavePO += SavePO;
            _view.UpdatePO += UpdatePO;
            RowToEdit = rowtoedit;
            BlockCode = blockcode;
            _view.MessageForm += MessageFormCreate;
        }
        private void MessageFormCreate(object sender, string message)
        {
            MessageForm mf = new MessageForm(message);
            mf.ShowDialog();
        }
        private void SavePO(object sender, EventArgs e)
        {
            try
            {
                PO po = new PO
                {
                    // Присваивание значений из представления
                    POCode = int.Parse(_view.POCode),
                    POName = _view.POName,
                };
                poData.Add(po);

                JsonFileManager.SavePOs(poData, "data.json");

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
        private void UpdatePO(object sender, EventArgs e)
        {
            try
            {
                PO po = new PO
                {
                    // Присваивание значений из представления
                    POCode = int.Parse(_view.POCode),
                    POName = _view.POName,
                    BlockCode = int.Parse(_view.BlockCode)
                };
                poData.RemoveAt(RowToEdit);
                poData.Insert(RowToEdit, po);
                JsonFileManager.SavePOs(poData, "data.json");
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
