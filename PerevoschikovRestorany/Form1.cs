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
        public DataStore.DataStore _dataStore { get; set; }

        public Form1()
        {
            _dataStore = new DataStore.DataStore();
            _dataStore.Database.EnsureCreated();
            InitializeComponent();
            LoadInfo();
        }

        public async void LoadInfo()
        {
            await GetLoginUsers();
        }

        private async void btn_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckPass();
            }
            catch
            {
                MessageBox.Show("Проверьте имя пользователя и пароль");
            }
            
        }

        private async Task CheckPass()
        {
            var login = await _dataStore.Users
                .Where(p => p.Name==cb_login.SelectedItem.ToString())
                .Select(x => new Users()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Password = x.Password
                }).ToArrayAsync();
            if (tb_password.Text==login[0].Password)
            {
                var activeMainForm = new MainForm();
                activeMainForm.Show();
                if (cb_login.SelectedItem.ToString() == "admin")
                {
                    activeMainForm.isAdmin = true;
                }
                else
                {
                    activeMainForm.isAdmin = false;
                }
            }
            else
            {
                MessageBox.Show("Проверьте имя пользователя и пароль");
            }
            
        }

        private async Task GetLoginUsers()
        {
            var login = await _dataStore.Users
                .Select(x => new Users() 
                { 
                    Id=x.Id,
                    Name =x.Name,
                    Password = x.Password
                }).ToArrayAsync();

            cb_login.Items.Clear();

            foreach (var item in login)
            {
                cb_login.Items.Add(item.Name);
            }
        }
    }
    public class Users
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Password { get; set; }
    }
}
