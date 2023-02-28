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
        public DbSet<Users> Users { get; set; }
        public DbSet<Statistics> Statistics { get; set; }

        /*
        public DbSet<EquipmentRestoraunt> Equipments { get; set; }
        public DbSet<Restorany> Restorany { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        */
        //Переопределяем подключение к базе данных


        // строка подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L93R2E4;Database=PerevoschikovRestorany;Trusted_Connection=True;");
        }

        public DataStore()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }


    public class Suppliers // поставщики
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public List<InfoEquipment> InfoEquipment { get; set; } // может иметь много оборудования
    }

    public class Equipment // оборудование
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public List<InfoEquipment> InfoEquipment { get; set; } // иметь одно что-то(не знаю как назвать, но грубо говоря оборудование)
    }

    public class InfoEquipment // инормация об оборудовании
    {
        public int Id { get; set; }
        [Required]
        public int SuppliersId { get; set; }
        [Required]
        public int EquipmentId { get; set; }
        [Required]
        public int Price { get; set; }

        public Equipment Equipment { get; set; } 
        public Suppliers Suppliers { get; set; } // может иметь только одного поставщика
        public List<Stock> Stocks { get; set; } // может повторяться оборудование
    }

    public class Stock // склад
    {
        public int Id { get; set; }
        [Required]
        public int InfoEquipmentId { get; set; }
        [Required, MaxLength(5), MinLength(5)]
        public string SerialNumber { get; set; }
        
        public int? RestorauntId { get; set; }
        [Required, MaxLength(10)]
        public string status { get; set; }

        
        public InfoEquipment InfoEquipment { get; set; } // склад может иметь много оборудования
        public Restoraunt Restoraunt { get; set; } // привязка только к одному ресторану
    }

    public class Restoraunt // рестораны
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Address { get; set; }

        public List<Stock> Stock { get; set; } // может иметь много оборудования
    }

    public class Users
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MinLength(5), Required]
        public string Password { get; set; }
    }
    
    public class Statistics
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime DateTime { get; set; }
    }
    
}
