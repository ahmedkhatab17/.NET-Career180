using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class News
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Bref { get; set; }
        public string? Desc { get; set; }
        public DateTime? DateTime { get; set; }


        [ForeignKey("Catalog")]
        public int? CataId { get; set; }
        public virtual Catalog Catalog { get; set; }

        [ForeignKey("Author")]
        public int? AuthId { get; set; }
        public virtual Author Author { get; set; }


    }
}
