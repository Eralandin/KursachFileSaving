using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    public class BCMPresenter
    {
        private readonly IBCMView _view;
        private List<Blocks> blocksData; // Список должностей, загруженных из JSON-файла
        public int RowToEdit;
        private List<PO> poData;
        public BCMPresenter(IBCMView view, List<Blocks> blocksdata, int rowtoedit, List<PO> poList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            blocksData = blocksdata;
            _view.SaveBlock += SaveBlock;
            _view.UpdateBlock += UpdateBlock;
            RowToEdit = rowtoedit;
            poData = poList;
            _view.SearchTextChanged += OnSearch;
        }
        private void SaveBlock(object sender, EventArgs e)
        {
            try
            {
                Blocks block = new Blocks
                {
                    // Присваивание значений из представления
                    BlockCode = int.Parse(_view.BlockCode),
                    BlockName = _view.BlockName,
                    Motherboard = _view.Motherboard,
                    RAM = int.Parse(_view.RAM),
                    Videocard = _view.Videocard,
                };
                blocksData.Add(block);

                JsonFileManager.SaveBlocks(blocksData, "data.json");

                // Оповещение пользователя об успешном сохранении
                MessageBox.Show("Новый блок успешно сохранён!");

                // Закрытие формы после сохранения
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиненная ошибка! " + ex.Message);
                return;
            }
        }
        private void UpdateBlock(object sender, EventArgs e)
        {
            try
            {
                if (_view.POCOde == "")
                {
                    MessageBox.Show("Введите код ПО! (если ПО ещё не назначено - выбирайте 0)");
                    return;
                }
                if ((_view.POCOde == "0" || _view.POCOde != "0") && blocksData[RowToEdit].POCode.ToString() != "0")
                {
                    var poList = JsonFileManager.LoadData().Item6;
                    int index = poList.FindIndex(po => po.BlockCode == blocksData[RowToEdit].BlockCode);
                    poList[index].BlockCode = 0;
                    JsonFileManager.SavePOs(poList, "data.json");
                }
                Blocks block = new Blocks
                {
                    // Присваивание значений из представления
                    BlockCode = int.Parse(_view.BlockCode),
                    BlockName = _view.BlockName,
                    Motherboard = _view.Motherboard,
                    RAM = int.Parse(_view.RAM),
                    Videocard = _view.Videocard,
                    POCode = int.Parse(_view.POCOde)
                };
                blocksData.RemoveAt(RowToEdit);
                blocksData.Insert(RowToEdit, block);
                JsonFileManager.SaveBlocks(blocksData, "data.json");
                if (_view.POCOde != "0")
                {
                    var poList = JsonFileManager.LoadData().Item6;
                    int index = poList.FindIndex(po => po.POCode == int.Parse(_view.POCOde));
                    poList[index].BlockCode = int.Parse(_view.BlockCode);
                    JsonFileManager.SavePOs(poList, "data.json");
                }

                MessageBox.Show("Блок успешно обновлён!");
                _view.CloseForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиненная ошибка! " + ex.Message);
                return;
            }
        }
        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            List<PO> filteredPOs = poData.Where(po => po.POCode.ToString().Contains(searchText) || po.POName.Contains(searchText) || po.BlockCode.ToString().Contains(searchText)).ToList();

            _view.ShowPOs(filteredPOs);
        }
    }
}
