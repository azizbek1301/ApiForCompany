using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiForCompany.Models
{
    public class EmployeeStaff
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int Employee_Id {  get; set; }
        [ForeignKey("Staff")]
        public int Staff_Id {  get; set; }

        public Staff Staff { get; set;}
        public Employee Employee { get; set; }
    }
}
