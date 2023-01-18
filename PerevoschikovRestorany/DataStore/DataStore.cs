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

        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<InfoEquipment> InfoEquipment { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Restoraunt> Restoraunts { get; set; }

        /*
        public DbSet<EquipmentRestoraunt> Equipments { get; set; }
        public DbSet<Restorany> Restorany { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        */
        //Переопределяем подключение к базе данных

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase.db");
        }
    }

    public class Suppliers // поставщики
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
    }

    public class Equipment // оборудование
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
    }

    public class InfoEquipment // инормация об оборудовании
    {
        public int Id { get; set; }
        public int SuppliersId { get; set; }
        public int EquipmentId { get; set; }
        public int Price { get; set; }

        public List<Equipment> Equipment { get; set; }
        public List<Suppliers> Suppliers { get; set; }
        
    }

    public class Stock // склад
    {
        public int Id { get; set; }
        public int InfoEquipmentId { get; set; }
        public int SerialNumber { get; set; }
        public int RestorauntId { get; set; }

        public List<InfoEquipment> InfoEquipment { get; set; }
        public Restoraunt Restoraunt { get; set; }
    }

    public class Restoraunt // рестораны
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Stock> Stock { get; set; }
    }

    /*
    
    // таблица рестораны
    public class Restorany
    {
        //Primary key 
        public int Id { get; set; }
        public string RestoranName { get; set; }
        public string Address { get; set; }

        public List<EquipmentRestoraunt> EquipmentRestoraunts { get; set; }
    }

    // таблица поставщики
    public class Suppliers
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public List<SuppliedEquipment> SuppliedEquipment { get; set; }
    }

    // поставляемое оборудование(какой поставщик что поставляет)
    public class SuppliedEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public int price { get; set; }

        public int SuppliersId { get; set; }
        public Suppliers Suppliers { get; set; }
    }

    // имеющееся оборудование
    public class Equipment
    {
        public int Id { get; set; }
        public int SEId { get; set; }
        public SuppliedEquipment SuppliedEquipment { get; set; }
    }

    // таблица оборудование в ресторанах
    public class EquipmentRestoraunt
    {
        //PK
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int RestoranId { get; set; }

        public Restorany Restorany { get; set; }
        public Equipment Equipment { get; set; }
    }

    // склад
    public class Stock
    {
        public int id { get; set; }
        public int EquipmentId { get; set; } // id поставляемого оборудования
        public string Condition { get; set; }

        public List<Equipment> Equipment { get; set; }
    }

    // таблица пользователи
    public class User
    {
        public int Id { get; set; }
        public string Personal { get; set; }
        public string Password { get; set; }
    }

    */
}
