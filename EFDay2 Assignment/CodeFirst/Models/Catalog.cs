using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }


        public virtual List<News> News { get; set; } = new List<News>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
