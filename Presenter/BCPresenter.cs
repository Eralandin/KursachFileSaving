using KursachFileSaving.Models.Classes;
using KursachFileSaving.Models.Interfaces;
using KursachFileSaving.View.Forms.BlocksControlForms;
using KursachFileSaving.View.Forms.POControlForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursachFileSaving.View.Forms.JobsControlForms.JobsControl;

namespace KursachFileSaving.Presenter
{
    public class BCPresenter
    {
        private readonly IBCView _view;
        private List<Blocks> _blocksList;

        public int RowToDelete;
        public int RowToEdit;

        public BCPresenter(IBCView view, List<Blocks> blocksList)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _blocksList = blocksList;

            _view.Load += OnLoad;
            _view.AddBlock += AddBlock;
            _view.UpdateBlock += UpdateBlock;
            _view.DeleteBlock += DeleteBlock;
            _view.SearchTextChanged += OnSearch;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadBlocks(_blocksList);
        }

        private void LoadBlocks(List<Blocks> blocksList)
        {
            _view.ShowBlocks(blocksList);
        }

        public void AddBlock(object sender, EventArgs e)
        {
            BlockControlModule moduleForm = new BlockControlModule(_blocksList, RowToEdit);
            moduleForm.BCMUpdateButton.Enabled = false;
            if (_blocksList.Count == 0)
            {
                moduleForm.BlockCodeTextBox.Text = 1.ToString();
            }
            else
            {
                moduleForm.BlockCodeTextBox.Text = (_blocksList.Last().BlockCode + 1).ToString();
            }
            moduleForm.comboBox1.Enabled = false;
            moduleForm.BlockCodeTextBox.Enabled = false;
            moduleForm.ShowDialog();
            LoadBlocks(_blocksList);
        }
        public void UpdateBlock(object sender, EventArgs e)
        {
            BlockControlModule moduleForm = new BlockControlModule(_blocksList, RowToEdit);
            moduleForm.BlockCodeTextBox.Enabled = false;
            moduleForm.BlockCodeTextBox.Text = _blocksList[RowToEdit].BlockCode.ToString();
            moduleForm.BlockNameTextBox.Text = _blocksList[RowToEdit].BlockName.ToString();
            moduleForm.MotherBoardTextBox.Text = _blocksList[RowToEdit].Motherboard.ToString();
            moduleForm.RAMTextBox.Text = _blocksList[RowToEdit].RAM.ToString();
            moduleForm.VideocardTextBox.Text = _blocksList[RowToEdit].Videocard.ToString();
            if (_blocksList[RowToEdit].POCode != 0)
            {
                moduleForm.comboBox1.Items.Add(_blocksList[RowToEdit].POCode.ToString());
            }
            moduleForm.comboBox1.Sorted = true;
            moduleForm.BCMSaveButton.Enabled = false;
            moduleForm.ShowDialog();
            LoadBlocks(_blocksList);
        }

        public void DeleteBlock(object sender, EventArgs e)
        {
            try
            {
                _blocksList.Remove(_blocksList[RowToDelete]);
                JsonFileManager.SaveBlocks(_blocksList, "data.json");
                LoadBlocks(_blocksList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка! " + ex.Message);
                return;
            }
        }

        private void OnSearch(object sender, SearchEventArgs e)
        {
            // Получаем текст запроса из аргумента события
            string searchText = e.SearchText;

            // Выполняем логику поиска по тексту запроса
            // Например, фильтруем список должностей по названию или коду
            List<Blocks> filteredBlocks = _blocksList.Where(blocks => blocks.BlockName.Contains(searchText) || blocks.BlockCode.ToString().Contains(searchText) || blocks.Motherboard.ToString().Contains(searchText) || blocks.RAM.ToString().Contains(searchText) || blocks.Videocard.ToString().Contains(searchText) || blocks.POCode.ToString().Contains(searchText)).ToList();

            // Обновляем представление с отфильтрованным списком должностей
            _view.ShowBlocks(filteredBlocks);
        }
    }
}
