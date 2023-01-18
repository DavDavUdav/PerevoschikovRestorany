using PerevoschikovRestorany.DataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerevoschikovRestorany
{
    public partial class AddSupplier : Form
    {
        public DataStore.DataStore _dataStore { get; set; }

        //переменная класса поставщиков
        public Suppliers _supplier;

        public AddSupplier()
        {
            _dataStore = new DataStore.DataStore();
            _dataStore.Database.EnsureCreated();

            InitializeComponent();

        }

        // Метод получения результата заполнения формы
        public Suppliers GetSupplier() => _supplier;

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            _supplier = new Suppliers()
            {
                SupplierName = textBox1.Text
            };
            this.Close();
            */
        }

        
    }
}
