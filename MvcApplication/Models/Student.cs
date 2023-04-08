using MvcApplication.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Max name length is 80 characters")]
        public string Name { get; set; }
        [Required]
        public string Class { get; set; }


        [Display(Name = "Department")]
        public int DeptID { get; set; }
        [ForeignKey("DeptID")]
        public virtual Department? Dept { get; set; }
    }
}

