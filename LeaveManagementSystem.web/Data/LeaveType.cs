using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(150)")]
        public string LeaveTypeName { get; set; }
        public int NumberOfDays { get; set; }

    }
}
