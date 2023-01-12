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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "resoranyDataSet.oborudovanie". При необходимости она может быть перемещена или удалена.
            this.oborudovanieTableAdapter.Fill(this.resoranyDataSet.oborudovanie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "resoranyDataSet.postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.resoranyDataSet.postavshiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "resoranyDataSet.restorany". При необходимости она может быть перемещена или удалена.
            this.restoranyTableAdapter.Fill(this.resoranyDataSet.restorany);

        }

        private void btn_add_oborudovanie_Click(object sender, EventArgs e)
        {
            AddOborudovanie addOborudovanie = new AddOborudovanie();
            addOborudovanie.Show();
        }
    }
}
