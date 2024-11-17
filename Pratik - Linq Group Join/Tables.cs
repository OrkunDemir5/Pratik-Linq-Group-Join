using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }

    public class Classes
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
