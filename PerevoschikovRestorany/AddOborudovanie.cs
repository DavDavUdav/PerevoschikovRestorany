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
    public partial class AddOborudovanie : Form
    {
        public AddOborudovanie()
        {
            InitializeComponent();
        }

        /*
         DataRow myRow = resoranyDataSet.Tables["oborudovanie"].NewRow();
            myRow["naim"] = tb_naim.Text;
            myRow["ser_num"] = tb_ser_num.Text;
            myRow["k_restor"] = cb_restoran.SelectedValue;
            myRow["dat_post"] = Convert.ToDateTime(maskedTextBox1.Text);
            myRow["k_post"] = cb_postavshik.SelectedValue;
            resoranyDataSet.oborudovanie.Rows.Add(myRow);

            this.oborudovanieTableAdapter.Update(this.resoranyDataSet.oborudovanie);
            this.oborudovanieTableAdapter.Fill(this.resoranyDataSet.oborudovanie);
         */
    }
}
