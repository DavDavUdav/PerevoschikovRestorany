using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PerevoschikovRestorany.DataStore
{
    public class DataStore : DbContext
    {
        //Прописываем под каждую ТАБЛИЦУ БАЗЫ ДАННЫХ 

        //  DbSet<НАЗВАНИЕ КЛАССА> ИМЯ
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Restorany> Restorany { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        //Переопределяем подключение к базе данных

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase.db");
        }
    }




    public class Equipment
    {
        //PK
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ReceiptDate { get; set; }


        public Restorany Restorany { get; set; }
        public Suppliers Suppliers { get; set; }
    }

    public class Restorany
    {
        //Primary key 
        public int Id { get; set; }
        public string RestoranName { get; set; }
        public string Address { get; set; }
    }

    public class Suppliers
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Personal { get; set; }
        public string Password { get; set; }
    }
}
