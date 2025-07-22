using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        public int LeaveTypeId { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        public int NumberOfDays { get; set; }
    }
}
