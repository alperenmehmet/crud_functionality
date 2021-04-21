using CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDOperation_ASP.NET_Web_Application.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-H7LHG97\SQLEXPRESS;Database=CRUDOperationsPersonDb;Integrated Security=True";
        }

        public DbSet<Person> People { get; set; }
    }
}