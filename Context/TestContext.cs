using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TestingApp.Context
{
    class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ////options.UseSqlServer(
            //    @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }

    }
}
