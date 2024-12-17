using System.ComponentModel.DataAnnotations;

namespace Day4.DTOs.StudentDTO
{
    public class addstudentDTO
    {
        [Required(ErrorMessage ="required name!!")]
      //  [StringLength(30,MinimumLength =20)]
        [MinLength(10 ,ErrorMessage ="minium length of name > 10")]
        public string name { get; set; }
        [Range(6,12 ,ErrorMessage ="age must between 6  and 12")]
        public int  age { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        [Compare("password",ErrorMessage = "password not matched")]
        public string confirm_password { get; set; }

        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$" ,ErrorMessage ="invalid email")]
        public string email { get; set; }


        public int  deptid { get; set; }
    }
}
