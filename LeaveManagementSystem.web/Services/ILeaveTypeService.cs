using LeaveManagementSystem.web.Models.LeaveTypes;

namespace LeaveManagementSystem.web.Services
{
    public interface ILeaveTypeService
    {
        Task<bool> CheckIfLeaveTypeExist(string leaveTypeName);
        Task<bool> CheckIfLeaveTypeExistForEdit(LeaveTypeEditViewModel leaveTypeEdit);
        Task Create(LeaveTypeCreateViewModel model);
        Task Edit(LeaveTypeEditViewModel model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyViewModel>> GetAllAsync();
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}