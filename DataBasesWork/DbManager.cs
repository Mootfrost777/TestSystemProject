using System;
using System.Collections.Generic;
using System.Text;
using TestingApp.Context;
using TestingApp.Models;
using TestingApp.ConstantManager;
using System.Linq;

namespace TestingApp.DataBasesWork
{
    class DbManager
    {
        private TestContext db;
        public DbManager(TestContext db)
        {
            this.db = db;
        }
        public string ChekLogin(string name, string pass)
        {
            IQueryable<User> users = db.Users;
            
            User u = new User()
            {
                UserName=name,
                PasswordHash=pass
            };
                
            User user=users.FirstOrDefault(x=>x.UserName==name);
            if (user == null)
            {
                return ConstManager.uncorrectName;
            }
            if (user.PasswordHash!=pass)
            {
                return ConstManager.uncorrectPass;
            }
            return ConstManager.correctinfo;
        }
    }
}
