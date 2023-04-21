using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public List<Test> tests = new List<Test>();
    }
}
