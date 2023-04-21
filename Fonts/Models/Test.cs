using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApp.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string TestSeed { get; set; }
        public List<Question> questions = new List<Question>();
        public string Result { get; set; }
    }
}
