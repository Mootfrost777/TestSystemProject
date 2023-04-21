using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestingApp.Models;
namespace TestingApp.Context
{
    public class TestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
             @"Server=DESKTOP-FDU98J2;Database=TestingApp;Trusted_Connection = True;");


        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
