using Microsoft.EntityFrameworkCore;
using PerevoschikovRestorany.DataStore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerevoschikovRestorany
{
    public partial class MainForm : Form
    {
        public DataStore.DataStore _dataStore { get; set; }
        public MainForm()
        {
            _dataStore = new DataStore.DataStore();
            _dataStore.Database.EnsureCreated();

            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "resoranyDataSet.oborudovanie". При необходимости она может быть перемещена или удалена.
            //this.oborudovanieTableAdapter.Fill(this.resoranyDataSet.oborudovanie);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "resoranyDataSet.postavshiki". При необходимости она может быть перемещена или удалена.
            //this.postavshikiTableAdapter.Fill(this.resoranyDataSet.postavshiki);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "resoranyDataSet.restorany". При необходимости она может быть перемещена или удалена.
            //this.restoranyTableAdapter.Fill(this.resoranyDataSet.restorany);
        }

        private async void btn_add_oborudovanie_Click(object sender, EventArgs e)
        {
            //var first = await _dataStore.Equipments
            //    .Include(x => x.Suppliers) //Подключаем доп таблицу
            //    .Include(x => x.Restorany) //Подключаем доп таблицу
            //    .Where(x => x.Id > 5) //Фильтр x.Name поле по которому будешь искать совпадение
            //    //.Where(x => x.Suppliers.Id > 5) //Выбираем что хотим получить
            //    .Select(x => new YYY()
            //    {
            //        Id = x.Id,
            //        Name = x.Name,
            //        Address = x.Suppliers.Address,
            //        Serial = x.SerialNumber
            //    })
            //    .ToListAsync(); //Переводим в Лист 


            var addEqupment = new AddOborudovanie();
            addEqupment.ShowDialog();

            //Получаем заполненные значения
            var equpment = addEqupment.GetEqupment();
            if (equpment != null)
            {
                _dataStore.Equipments.Add(equpment);
                await _dataStore.SaveChangesAsync();
            }

            Update();
            
        }

        private async Task Update()
        {
            //Получение данных из таблицы Equipments
            var allEqupment = await _dataStore.Equipments
                .Include(x => x.Suppliers)
                .Include(x => x.Restorany)
                .Select(x => new RetoranTable()
                {
                    EquipmentId = x.Id,
                    Name = x.Name,
                    Serial = x.SerialNumber,
                    RestoranName = x.Restorany.RestoranName,
                    ReciptDate = x.ReceiptDate,
                    SupplerName = x.Suppliers.SupplierName,
                    Address = x.Restorany.Address
                })
                .ToListAsync();

            //Очистить таблицу
            dgw_restorany.Rows.Clear();

            //Вывести новые значения
            dgw_restorany.DataSource = allEqupment.ToList();
        }
    }

    //Класс для вывода
    public class RetoranTable
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public string RestoranName { get; set; }
        public DateTime ReciptDate { get; set; }
        public string SupplerName { get; set; }
        public string Address { get; set; }
    }
}
