using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyViewModel : BaseLeaveTypeViewModel
    {

        public string LeaveTypeName { get; set; } = string.Empty;

        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
