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

            await UpdateNaimRest();
            await UpdateNaimSuppliersSearch();
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

        private void btn_add_to_stock_Click(object sender, EventArgs e)
        {

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
            if (_equipment !=null)
            {
                _dataStore.InfoEquipment.Add(_equipment);
                await _dataStore.SaveChangesAsync();
                
            }

            await GetIdSuppliers();
        }
        
        private async void btn_add_equipments_all_Click(object sender, EventArgs e)
        {
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
        private void btn_move_to_restoran_Click(object sender, EventArgs e)
        {

        }
        
        // переместить на склад
        /// <summary>
        /// Перемещение на склад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_move_to_stock_Click(object sender, EventArgs e)
        {
            int _get_id_equip = (int)dgw_restorany.SelectedRows[0].Cells[0].Value;

            var edit = _dataStore.Stocks
                .Where(p => p.Id == _get_id_equip)
                .FirstOrDefault();
            edit.RestorauntId = null;
            _dataStore.SaveChangesAsync();
        }
        #endregion editTable

        #region search

        private async void btn_search_supplier_Click(object sender, EventArgs e)
        {
            await GetIdSuppliers();
        }

        private async void btn_search_restoran_address_Click(object sender, EventArgs e)
        {
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

        private async Task GetIdrest()
        {
            var _id = await _dataStore.Restoraunts
                .Where(p => p.Address == cb_rest_address_search.Text)
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
                   Address = x.Address
               }).ToArrayAsync();

            cb_rest_address_search.Items.Clear();
            cb_rest_address_search1.Items.Clear();

            foreach (var item in naimRest)
            {
                cb_rest_address_search.Items.Add(item.Address);
                cb_rest_address_search1.Items.Add(item.Address);
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
                    Name =x.Name
                }).ToListAsync();

            //dgw_equipment_all.Rows.Clear();
            dgw_equipment_all.DataSource = _equipment;
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
                    Price = x.InfoEquipment.Price
                    
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
            await UpdateEquipment();
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
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

    #region printClass

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
        public int SuppliersId { get; set; }
        public string Name { get; set; }
    }

    // для вывода ресторанов
    public class RestorauntsTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class EquipmentStockTable
    {
        public int Id { get; set; }
        public string NameEquipment { get; set; }
        public string NameSupplier { get; set; }
        //public string AddressRestoran { get; set; }
        public string SerialNumber { get; set; }
        public int Price { get; set; }
    }

    public class EquipmentRestorauntTable
    {
        public int Id { get; set; }
        public string NameEquipment { get; set; }
        public string NameSupplier { get; set; }
        public string AddressRestoran { get; set; }
        public string SerialNumber { get; set; }
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
        public int Id { get; set; }
        public string NameEquipment { get; set; }
        public int Price { get; set; }
    }

    #endregion printClass
}
