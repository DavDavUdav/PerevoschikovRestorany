using PerevoschikovRestorany.DataStore;
using System;
using System.Windows.Forms;

namespace PerevoschikovRestorany
{
    public partial class AddOborudovanie : Form
    {
        //Объявляем переменную описывающую класс оборудования
        public Equipment _equipment;
        public AddOborudovanie()
        {

            InitializeComponent();
        }

        // Метод получения результата заполнения формы
        public Equipment GetEqupment() => _equipment;

        private void button1_Click(object sender, EventArgs e)
        {
            //Заполняем класс и записываем в переменную _equipment
            _equipment = new Equipment()
            {
                Name = textBox1.Text,
                ReceiptDate = dateTimePicker1.Value,
                SerialNumber = textBox2.Text,
                Restorany = new Restorany()
                {
                    RestoranName = textBox3.Text
                },
                Suppliers = new Suppliers()
                {
                    Address = textBox4.Text,
                    SupplierName = textBox5.Text
                }
            };

            //Закрываем диалоговое окно(Форму)
            this.Close();
        }
    }
}
