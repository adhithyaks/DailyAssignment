using System.ComponentModel.DataAnnotations;

namespace Employee.Model
{
    public class Emp
    {
        public int deptId { get; set; }
        public string? name { get; set; }
        [DataType(DataType.Date)]
        public DateTime joiningDate { get; set; }
        public string? Gender { get; set; }
        public decimal salary { get; set; }
    }
}
