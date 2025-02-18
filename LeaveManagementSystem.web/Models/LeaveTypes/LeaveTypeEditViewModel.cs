using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.web.Models.LeaveTypes
{
    public class LeaveTypeEditViewModel : BaseLeaveTypeViewModel
    {
        [Required]
        [Length(4, 150, ErrorMessage = "You have exceed the limit")]
        public string LeaveTypeName { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
