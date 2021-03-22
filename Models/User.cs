using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestEFC.Models
{
    public class User
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string SecondName { get; set; }
     //   public decimal Salary { get; set; }
        public string UserMail { get; set; }



    }
    public class Cart
    {
        public long CountItems { get; set; } = 0;
        public string Items { get; set; }
        public decimal TotalPrice { get; set; }

    }

    public enum OrderStatus
    {
      WaitForConfirm,
      Confirmed,
      Perfomed,
      Delivering,
      Delivered,
      WaitingForPay,
      WaitingForClientCheck,
      Completed



    }
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<ClientInfo> ClientsInfo { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ConfirmToken> ConfirmTokens { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
         
            //Database.EnsureCreated();

        }
    }
    
}
