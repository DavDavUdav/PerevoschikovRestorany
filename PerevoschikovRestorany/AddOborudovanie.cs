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
        public Equipment _equipment;
        public AddOborudovanie()
        {
            _dataStore = new DataStore.DataStore();
            _dataStore.Database.EnsureCreated();


            InitializeComponent();

            

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


        // Метод получения результата заполнения формы
        public Equipment GetEqupment() => _equipment;

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void cb_location_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_location_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cb_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_location.SelectedIndex == 0)
            {
                cb_address.Visible = false;
                label_address.Visible = false;
            }

            if (cb_location.SelectedIndex == 1)
            {
                cb_address.Visible = true;
                label_address.Visible = true;


            }
        }
    }
}
