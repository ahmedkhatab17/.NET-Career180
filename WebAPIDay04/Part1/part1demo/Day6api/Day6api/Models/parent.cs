using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6api.Models
{
    public class parent
    {
        [Key]
        [ForeignKey("user")]
        public string parentid { get; set; }
        public string parentname { get; set; }
        public string adress { get; set; }

        public virtual IdentityUser user { get; set; }

    }
}
