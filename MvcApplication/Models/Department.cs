using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcApplication.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
