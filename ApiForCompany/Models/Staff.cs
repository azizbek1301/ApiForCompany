namespace ApiForCompany.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string StaffName { get; set; }
        public string StaffEmail {  get; set; }

        public ICollection<EmployeeStaff> EmployeeStaff { get; set; }

    }
}
