using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PerevoschikovRestorany.DataStore;
using System.ComponentModel.DataAnnotations;

namespace PerevoschikovRestorany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            
            
            if ((tb_login.Text == "Admin" && tb_password.Text=="admin") || (tb_login.Text == "User" && tb_password.Text == "user") )
            {
                var activeMainForm = new MainForm();
                activeMainForm.Show();
            }
            else
            {
                MessageBox.Show("Введены неверные данные");
            }
            
            //this.Close();
        }
    }

    public class Users
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Password { get; set; }
    }
}
