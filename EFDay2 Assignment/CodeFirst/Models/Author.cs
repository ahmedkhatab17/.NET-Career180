using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? JoinDate { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? Bref { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
