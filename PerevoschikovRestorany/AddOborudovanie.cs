using PerevoschikovRestorany.DataStore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace PerevoschikovRestorany
{
    public partial class AddOborudovanie : Form
    {

        public DataStore.DataStore _dataStore { get; set; }

        //Объявляем переменную описывающую класс оборудования
        public InfoEquipment _info_equipment;
        public AddOborudovanie()
        {
            _dataStore = new DataStore.DataStore();
            _dataStore.Database.EnsureCreated();


            InitializeComponent();

            StartLoad();

        }

        public async void StartLoad()
        {
            await LoadNameEquipment();
            await LoadNameSuppliers();
        }

        /*
        private async Task LoadSuppliers()
        {
            var nameSuppliers = await _dataStore.Suppliers
                .Select(x => new RetoranTable() 
                { 
                    SupplerName = x.SupplierName
                })
                .ToListAsync();
            
        }
        */

        private async Task LoadNameEquipment()
        {
            var nameEquip = await _dataStore.Equipment
                .Select(x => new UpdateEquipment() 
                { 
                    Id = x.Id,
                    Name = x.Name
                }).ToArrayAsync();

            foreach (var item in nameEquip)
            {
                cb_equipment.Items.Add(item.Name);
            }
        }

        private async Task LoadNameSuppliers()
        {
            var nameSupplier = await _dataStore.Suppliers
                .Select(x => new UpdateSuppliers()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToArrayAsync();

            foreach (var item in nameSupplier)
            {
                cb_suppliers_name.Items.Add(item.Name);
            }
            
        }

        // Метод получения результата заполнения формы
        public InfoEquipment GetEqupment() => _info_equipment;

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cb_equipment.SelectedText==null || cb_suppliers_name.SelectedText==null || tb_price.Text==null)
            {
                MessageBox.Show("вы не ввели цену или не выбрали поставщиков или оборудование");
                return;
            }
            
            var _nameEquip = await _dataStore.Equipment
                .Where(p => p.Name==cb_equipment.SelectedItem.ToString())
                .Select(x => new UpdateEquipment()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToArrayAsync();

            var nameSupplier = await _dataStore.Suppliers
                .Where(p => p.Name == cb_suppliers_name.SelectedItem.ToString())
                .Select(x => new UpdateSuppliers()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToArrayAsync();

            _info_equipment = new InfoEquipment()
            {
                EquipmentId = _nameEquip[0].Id,
                SuppliersId = nameSupplier[0].Id,
                Price = Convert.ToInt32(tb_price.Text)
                
            };
            
            
            //Заполняем класс и записываем в переменную _equipment
            /*
            _equipment = new Equipment()
            {
                Name = tb_name_Equipment.Text,
                ReceiptDate = dateTimePicker1.Value,
                SerialNumber = tb_serial_Number.Text,
                Restorany = new Restorany()
                {
                    RestoranName = tb_restoran_Name.Text,
                    Address = tb_adress_restoran.Text
                },
                Suppliers = new Suppliers()
                {
                    
                    SupplierName = tb_supplier_name.Text
                }
            };
            */
            //Закрываем диалоговое окно(Форму)
            this.Close();
        }

        

    }

    public class UpdateEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateSuppliers
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
