using Microsoft.EntityFrameworkCore;
using PerevoschikovRestorany.DataStore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using LiveCharts; //Core of the library
//using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using LiveCharts.Wpf;
using System.Collections.Generic;

namespace PerevoschikovRestorany
{
    public partial class MainForm : Form
    {
        public DataStore.DataStore _dataStore { get; set; }

        public bool isAdmin;

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
            Update();
            UpdateForm();
        }

        public async void UpdateForm()
        {
            //await UpdateRestoraunts();
            await UpdateEquipment();
            await UpdateSuppliers();
            await UpdateEquipmentInStock();
            //await UpdateEquipmentInRestoraunt(1);
            await UpdateEStatistics();



            await UpdateNaimRest();
            await UpdateNaimSuppliersSearch();

            if (isAdmin == false)
            {
                IsUser();
            }

        }

        public void IsUser()
        {
            btn_add_equipments_all.Enabled = false;
            btn_add_new_Equipment.Enabled = false;
            btn_add_restoran.Enabled = false;
            btn_add_to_stock.Enabled = false;
            //btn_do_document.Enabled = false;
            btn_move_to_restoran.Enabled = false;
            btn_move_to_stock.Enabled = false;
            button1.Enabled = false;
        }

        #region addInTable
        //пример
        private async void btn_add_postavshik_Click(object sender, EventArgs e)
        {
            var addsupplier = new AddSupplier();
            addsupplier.ShowDialog();

            // получаем заполненные значения
            var supplier = addsupplier.GetSupplier();
            if (supplier != null)
            {
                _dataStore.Suppliers.Add((Suppliers)supplier);
                await _dataStore.SaveChangesAsync();
            }
            UpdateSuppliers();
        }


        private async void btn_add_restoran_Click(object sender, EventArgs e)
        {
            if (tb_nazv_Restoran.Text == "" || tb_addres_Restoran.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }

            var restoran = new Restoraunt()
            {
                Name = tb_nazv_Restoran.Text,
                Address = tb_addres_Restoran.Text
            };

            _dataStore.Restoraunts.Add(restoran);
            await _dataStore.SaveChangesAsync();

            await UpdateNaimRest();
            //UpdateRestoraunts();
        } // готово

        private async void btn_add_equipment_Click(object sender, EventArgs e)
        {
            /*
            var addEqupment = new AddOborudovanie();
            addEqupment.ShowDialog();

            //Получаем заполненные значения
            var equpment = addEqupment.GetEqupment();
            if (equpment != null)
            {
                //_dataStore.Equipments.Add(equpment);
                await _dataStore.SaveChangesAsync();
            }

            UpdateEquipments();
            */
        }

        private async void btn_add_to_stock_Click(object sender, EventArgs e)
        {
            if (tb_ser_num.Text.Length < 5)
            {
                MessageBox.Show("Серийный номер должен состоять из 5 символов");

            }
            if (dgw_suppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите оборудование из таблицы с которым хотите взаимодействовать");
                return;
            }

            var activSelect = dgw_suppliers.SelectedRows[0].Cells;

            var addstock = new Stock()
            {
                InfoEquipmentId = (int)activSelect[0].Value,
                SerialNumber = tb_ser_num.Text,
                RestorauntId = null,
                status = "Новое"
            };
            _dataStore.Stocks.Add(addstock);
            await _dataStore.SaveChangesAsync();
        }

        /// <summary>
        /// добавление оборудования поставщику
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_add_new_Equipment_Click(object sender, EventArgs e)
        {
            AddOborudovanie addOborudovanie = new AddOborudovanie();
            addOborudovanie.ShowDialog();

            var _equipment = addOborudovanie.GetEqupment();
            if (_equipment != null)
            {
                _dataStore.InfoEquipment.Add(_equipment);
                await _dataStore.SaveChangesAsync();

            }

            await GetIdSuppliers();
        }

        private async void btn_add_equipments_all_Click(object sender, EventArgs e)
        {
            if (tb_naim_equipment.Text == "")
            {
                MessageBox.Show("Введите наименование оборудования");
                return;
            }

            var _equipment = new Equipment()
            {
                Name = tb_naim_equipment.Text
            };

            _dataStore.Equipment.Add(_equipment);
            await _dataStore.SaveChangesAsync();

            await UpdateEquipment();
        }
        #endregion addIntable

        #region editTable

        // переместить в ресторан
        private async void btn_move_to_restoran_Click(object sender, EventArgs e)
        {
            // test

            if (cb_rest_address_search1.SelectedText == null || dgw_stock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ресторан или не выделили оборудование с которым хотите взаимодействовать");
                return;
            }

            await MoveEquipmentStockToRest();
        }



        // переместить на склад
        /// <summary>
        /// Перемещение на склад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_move_to_stock_Click(object sender, EventArgs e)
        {

            if (dgw_restorany.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите оборудование из таблицы");
                return;
            }



            await TaskMoveSklad(cb_status_equipment.SelectedItem.ToString());
            await GetIdrest();

        }

        private async Task TaskMoveSklad(string status)
        {
            int _get_id_equip = (int)dgw_restorany.SelectedRows[0].Cells[0].Value;

            var edit = _dataStore.Stocks
                .Where(p => p.Id == _get_id_equip)
                .FirstOrDefault();
            edit.RestorauntId = null;
            edit.status = status;
            await _dataStore.SaveChangesAsync();
        }

        #endregion editTable

        #region search

        private async void btn_search_supplier_Click(object sender, EventArgs e)
        {
            if (cb_suppliers_search.SelectedItem == null)
            {
                MessageBox.Show("Выберите поставщика");
                return;
            }
            await GetIdSuppliers();
        }

        private async void btn_search_restoran_address_Click(object sender, EventArgs e)
        {
            if (cb_rest_address_search.SelectedItem == null)
            {
                MessageBox.Show("Выберите ресторан, оборудование которого хотите просмотреть");
                return;
            }

            await GetIdrest();


        }

        private async Task GetIdSuppliers()
        {
            var _idSupplier = await _dataStore.Suppliers
                .Where(p => p.Name == cb_suppliers_search.SelectedItem.ToString())
                .Select(x => new EquipmentSuppliers
                {
                    Id = x.Id
                }).ToArrayAsync();
            await UpdateEquipmentSupplier(_idSupplier[0].Id);
        }


        /// <summary>
        /// перемещение в ресторан
        /// </summary>
        /// <returns></returns>
        private async Task MoveEquipmentStockToRest()
        {
            var _id = await _dataStore.Restoraunts
                .Where(p => p.Name == cb_rest_address_search1.SelectedItem)
                .Select(x => new RestorauntsTable()
                {
                    Id = x.Id
                }).ToArrayAsync();

            int _get_id_equip = (int)dgw_stock.SelectedRows[0].Cells[0].Value;

            var edit = _dataStore.Stocks
                .Where(p => p.Id == _get_id_equip)
                .FirstOrDefault();
            edit.RestorauntId = _id[0].Id;
            await _dataStore.SaveChangesAsync();
            await UpdateEquipmentInStock();

        }

        private async Task GetIdrest1()
        {
            var _id = await _dataStore.Restoraunts
                .Where(p => p.Address == cb_rest_address_search.Text)
                .Select(x => new RestorauntsTable()
                {
                    Id = x.Id
                }).ToArrayAsync();
            await UpdateEquipmentInRestoraunt(_id[0].Id);
        }

        private async Task GetIdrest()
        {
            var _id = await _dataStore.Restoraunts
                .Where(p => p.Name == cb_rest_address_search.Text)
                .Select(x => new RestorauntsTable()
                {
                    Id = x.Id
                }).ToArrayAsync();
            await UpdateEquipmentInRestoraunt(_id[0].Id);
        }
        #endregion search

        #region updateTable

        /// <summary>
        /// обновление комбобокса адресов ресторанов
        /// </summary>
        private async Task UpdateNaimRest()
        {
            var naimRest = await _dataStore.Restoraunts
               .Select(x => new RestorauntsTable()
               {
                   Name = x.Name
               }).ToArrayAsync();

            cb_rest_address_search.Items.Clear();
            cb_rest_address_search1.Items.Clear();

            foreach (var item in naimRest)
            {
                cb_rest_address_search.Items.Add(item.Name);
                cb_rest_address_search1.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// обновление комбобокса поставщиков
        /// </summary>
        private async Task UpdateNaimSuppliersSearch()
        {
            var naimSuppliers = await _dataStore.Suppliers
                .Select(x => new NaimSuppliersTable()
                {
                    Name = x.Name
                }).ToArrayAsync();

            cb_suppliers_search.Items.Clear();

            foreach (var item in naimSuppliers)
            {
                cb_suppliers_search.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Обновление DataGridView ресторанов
        /// </summary>
        /// <returns></returns>
        private async Task UpdateRestoraunts()
        {
            var allRestoraunt = await _dataStore.Restoraunts
                .Select(x => new RestorauntsTable()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address
                }).ToListAsync();

            //dgw_restorany.Rows.Clear();
            dgw_restorany.DataSource = allRestoraunt;
        }

        /// <summary>
        /// Обновление DataGridView оборудования
        /// </summary>
        /// <returns></returns>
        private async Task UpdateEquipment()
        {
            var _equipment = await _dataStore.Equipment
                .Select(x => new EquipmentTable()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();

            //dgw_equipment_all.Rows.Clear();
            dgw_equipment_all.DataSource = _equipment;
        }

        /// <summary>
        /// обновление dgw статистики
        /// </summary>
        /// <returns></returns>
        private async Task UpdateEStatistics()
        {
            var _stats = await _dataStore.Statistics
                .Select(x => new StatisticsTable()
                {
                    Id = x.Id,
                    Action = x.Action,
                    DateTime = x.DateTime
                }).ToListAsync();

            //dgw_equipment_all.Rows.Clear();
            dgw_statistics.DataSource = _stats;
        }

        /// <summary>
        /// Обновление datagridview поставщиков(вывод поставщиков)
        /// </summary>
        /// <returns></returns>
        private async Task UpdateSuppliers()
        {
            var _suppliers = await _dataStore.Suppliers
                .Select(x => new SuppliersTable()
                {
                    Name = x.Name
                }).ToListAsync();

            // dgw_suppliers.DataSource = _suppliers;
        }

        // попытка вывода оборудования на складе
        /// <summary>
        /// обновление dataGridView оборудования на складе
        /// </summary>
        /// <returns></returns>
        private async Task UpdateEquipmentInStock()
        {
            var equipmentInStock = await _dataStore.Stocks
                .Include(x => x.InfoEquipment)
                .Include(x => x.Restoraunt)
                .Include(x => x.InfoEquipment.Equipment)
                .Include(x => x.InfoEquipment.Suppliers)
                .Where(p => p.Restoraunt == null)
                .Select(x => new EquipmentStockTable()
                {
                    Id = x.Id,
                    NameEquipment = x.InfoEquipment.Equipment.Name,
                    NameSupplier = x.InfoEquipment.Suppliers.Name,
                    //AddressRestoran = x.Restoraunt.Name,
                    SerialNumber = x.SerialNumber,
                    Price = x.InfoEquipment.Price,
                    Status = x.status

                }).ToListAsync();

            dgw_stock.DataSource = equipmentInStock;
        }

        /// <summary>
        /// обновление dataGridView оборудования в ресторанах
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        private async Task UpdateEquipmentInRestoraunt(int _id)
        {
            var equipmentInRestoran = await _dataStore.Stocks
                .Include(x => x.InfoEquipment)
                .Include(x => x.Restoraunt)
                .Include(x => x.InfoEquipment.Equipment)
                .Include(x => x.InfoEquipment.Suppliers)
                .Where(p => p.Restoraunt.Id == _id)
                .Select(x => new EquipmentRestorauntTable()
                {
                    Id = x.Id,
                    NameEquipment = x.InfoEquipment.Equipment.Name,
                    NameSupplier = x.InfoEquipment.Suppliers.Name,
                    AddressRestoran = x.Restoraunt.Name,
                    SerialNumber = x.SerialNumber,
                    Price = x.InfoEquipment.Price

                }).ToListAsync();
            dgw_restorany.DataSource = equipmentInRestoran;
        }

        /// <summary>
        /// Обновление DataGridView оборудование у конкретного поставщика
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        private async Task UpdateEquipmentSupplier(int _id)
        {
            var equipSupplier = await _dataStore.InfoEquipment
                .Where(p => p.SuppliersId == _id)
                .Select(x => new EquipmentSuppliers()
                {
                    Id = x.Id,
                    NameEquipment = x.Equipment.Name,
                    Price = x.Price
                }).ToListAsync();
            dgw_suppliers.DataSource = equipSupplier;
        }

        /*
        private async Task UpdateEquipments()
        {
            //Получение данных из таблицы Equipments
            /*
            var allEqupment = await _dataStore.Equipments
                .Include(x => x.Suppliers)
                .Include(x => x.Restorany)
                .Select(x => new EquipmentTable()
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
            dgw_oborudovanie.Rows.Clear();

            //Вывести новые значения
            dgw_oborudovanie.DataSource = allEqupment;
            
        }
        */

        // узнать откуда
        private async void btn_update_equipments_Click(object sender, EventArgs e)
        {
            await UpdateEquipmentInStock();

        }

        private void btn_update_Suppliers_equipment_Click(object sender, EventArgs e)
        {
            UpdateSuppliers();
        }

        // обновление ресторанов
        private void btn_Update_Restorany_Click(object sender, EventArgs e)
        {
            UpdateRestoraunts();
        } // готово

        // обновление оборудования
        private async void button1_Click(object sender, EventArgs e)
        {
            await UpdateEquipment();
        }


        #endregion updateTable

        #region other
        // пример добавления
        /*
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


        }
        */


        // вывод значений поставщиков
        /*
        private async Task UpdateSuppliers()
        {
            //Получение данных из таблицы Equipments
            
            
            var allSuppliers = await _dataStore.Suppliers
                .Select(x => new SuppliersTable() 
                { 
                    SuppliersId = x.Id,
                    Name = x.SupplierName
                })
                .ToListAsync();
            
            //Очистить таблицу
            dgw_suppliers.Rows.Clear();

            //Вывести новые значения
            dgw_suppliers.DataSource = allSuppliers;
            
        }
        */




        // Кнопка добавления оборудования


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }




        // Кнопка добавления поставщиков
        #endregion other


        // добавление поставщика
        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (tb_supplier_naim.Text == "" || tb_supplier_naim.Text.Length < 3)
            {
                MessageBox.Show("заполните имя поставщика перед тем как его добавить");
            }

            var post = new Suppliers()
            {
                Name = tb_supplier_naim.Text
            };

            _dataStore.Suppliers.Add(post);
            await _dataStore.SaveChangesAsync();

            tb_supplier_naim.Text = "";
            await UpdateNaimSuppliersSearch();
        }

        private void btn_do_document_Click(object sender, EventArgs e)
        {
            /*
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            //Название таблицы
            ExcelApp.Cells[3, 1] = "Склад";
            //Цикл для заполнения названий столбцов таблицы
            for (int i = 1; i < dgw_stock.Columns.Count; i++)
            {
                ExcelApp.Cells[dgw_stock.Columns.Count, i] = dgw_stock.Columns[i].HeaderText;
            }
            //Заполнение таблицы данными
            for (int i = 0; i < dgw_stock.Rows.Count; i++)
            {
                for (int j = 0; j < dgw_stock.Columns.Count, j++)
                {
                    ExcelApp.Cells[i + 6, j + 1] = dgw_stock[i, j].Value.ToString();
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Columns.BorderAround2();
            ExcelApp.Columns.ColumnWidth = 30;
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
            */


            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Workbooks.Add();
            //Excel.Worksheets wsh = (Excel.Worksheets)ExcelApp.ActiveSheet;
            ExcelApp.Cells[1, 1] = "Склад";


            ExcelApp.Cells[2, 1] = "№";
            ExcelApp.Cells[2, 2] = "Оборудование";
            ExcelApp.Cells[2, 3] = "Поставщик";
            ExcelApp.Cells[2, 4] = "Серийный номер";
            ExcelApp.Cells[2, 5] = "Цена";

            //Заполнение таблицы данными
            for (int i = 0; i < dgw_stock.Columns.Count; i++)
            {
                for (int j = 0; j < dgw_stock.Rows.Count; j++)
                {
                    ExcelApp.Cells[j + 3, i + 1] = (dgw_stock[i, j].Value).ToString();
                }
            }

            dynamic sheet = ExcelApp.ActiveSheet;
            sheet.Columns.EntireColumn.AutoFit();

            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }

        private async void btn_update_statistics_Click(object sender, EventArgs e)
        {
            await UpdateEStatistics();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var _statistics = _dataStore.Statistics
                .ToList();
            var _group = _statistics.GroupBy(x => x.Action).ToArray();
            // PieChartExample(_group);

            var countEdit = _group[0].Count();
            var countAdd = _group[1].Count();

            PieChartExample(countAdd, countEdit);
            /*
                        chart_statistics.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();



                        chart_statistics.Series[0].XValueMember = "ads";
                        chart_statistics.Series[0].YValueMembers = "ddfs";

                        chart_statistics.DataSource = _group.Keys;

                        chart_statistics.Series[0].ChartType = SeriesChartType.Pie;
                        */
        }

        //todo: do
        public void PieChartExample(int countAdd, int countEdit)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection piechartData = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Добавление",
                    Values = new ChartValues<double> {countAdd},
                    DataLabels = true,
                    LabelPoint = labelPoint,

                    // Define a custom Color 
                    Fill = System.Windows.Media.Brushes.Gray
                },
                new PieSeries
                {
                    Title = "Изменение",
                    Values = new ChartValues<double> {countEdit},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Green,
                    PushOut = 15
                }
            };


            // Define the collection of Values to display in the Pie Chart
            pieChart1.Series = piechartData;

            // Set the legend location to appear in the bottom of the chart
            pieChart1.LegendLocation = LegendLocation.Right;

        }

        #region printClass

        public class StatisticsTable
        {
            public int Id { get; set; }
            public string Action { get; set; }
            public DateTime DateTime { get; set; }
        }

        //Класс для вывода
        /*
        public class EquipmentTable
        {
            [Display(Name = "№")]
            public int EquipmentId { get; set; }
            public string Name { get; set; }
            public string Serial { get; set; }
            public string RestoranName { get; set; }
            public string Address { get; set; }
            public DateTime ReciptDate { get; set; }
            public string SupplerName { get; set; }
        }
        */

        // для вывода поставщиков
        public class SuppliersTable
        {
            [Display(Name = "№")]
            public int SuppliersId { get; set; }
            [Display(Name = "Поставщик")]
            public string Name { get; set; }
        }

        // для вывода ресторанов
        public class RestorauntsTable
        {
            [Display(Name = "№")]
            public int Id { get; set; }
            [Display(Name = "Ресторан")]
            public string Name { get; set; }
            [Display(Name = "Адрес")]
            public string Address { get; set; }
        }

        public class EquipmentStockTable
        {
            [Display(Name = "№")]
            public int Id { get; set; }
            [Display(Name = "Оборудование")]
            public string NameEquipment { get; set; }
            [Display(Name = "Поставщик")]
            public string NameSupplier { get; set; }
            //public string AddressRestoran { get; set; }
            [Display(Name = "Серийный номер")]
            public string SerialNumber { get; set; }
            [Display(Name = "Цена")]
            public int Price { get; set; }
            public string Status { get; set; }
        }

        public class EquipmentRestorauntTable
        {
            [Display(Name = "№")]
            public int Id { get; set; }
            [Display(Name = "Оборудование")]
            public string NameEquipment { get; set; }
            [Display(Name = "Поставщик")]
            public string NameSupplier { get; set; }
            [Display(Name = "Адрес")]
            public string AddressRestoran { get; set; }
            [Display(Name = "Серийный номер")]
            public string SerialNumber { get; set; }
            [Display(Name = "Цена")]
            public int Price { get; set; }
        }

        public class NaimResttable
        {
            public string Id { get; set; }
        }

        public class NaimSuppliersTable
        {
            public string Name { get; set; }
        }

        public class EquipmentTable
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class EquipmentSuppliers
        {
            [Display(Name = "№")]
            public int Id { get; set; }
            [Display(Name = "Оборудование")]
            public string NameEquipment { get; set; }
            [Display(Name = "Цена")]
            public int Price { get; set; }
        }

        #endregion printClass
    }
}
