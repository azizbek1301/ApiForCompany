using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiForCompany.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeName {  get; set; }
        public string EmployeeEmail {  get; set; }
        [ForeignKey(nameof(Company))]
        public int Company_Id {  get; set; }

        public Company Company { get; set; }

        public ICollection<EmployeeStaff> Staffs { get; set; }
    }
}
