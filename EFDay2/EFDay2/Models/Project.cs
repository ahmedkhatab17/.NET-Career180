using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay2.Models
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

        public virtual List<Workfor> Employees { get; set; } = new List<Workfor>();
    }
}
