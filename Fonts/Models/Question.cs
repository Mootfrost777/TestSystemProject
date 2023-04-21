using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserAnswer { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
