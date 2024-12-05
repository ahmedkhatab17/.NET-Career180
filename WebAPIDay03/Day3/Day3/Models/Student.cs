using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Day3.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
     //   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
        public string address { get; set; }
        [ForeignKey("department")]
        public int deptid { get; set; }
       // [JsonIgnore]
        public virtual Department department { get; set; }
    }
}
