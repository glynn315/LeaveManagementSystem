using AutoMapper;
using LeaveManagementSystem.web.Data;
using LeaveManagementSystem.web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.web.Services;

public class LeaveTypeService(ApplicationDbContext _context, IMapper _mapper) : ILeaveTypeService
{
    
    public async Task<List<LeaveTypeReadOnlyViewModel>> GetAllAsync()
    {
        var data = await _context.LeaveTypes.ToListAsync();
        var viewData = _mapper.Map<List<LeaveTypeReadOnlyViewModel>>(data);

        return viewData;
    }

    public async Task<T?> Get<T>(int id) where T : class
    {
        var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);
        if (data == null)
        {
            return null;
        }

        var viewData = _mapper.Map<T>(data);

        return viewData;
    }

    public async Task Remove(int id)
    {
        var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);
        if (data != null)
        {
            _context.Remove(data);
            await _context.SaveChangesAsync();
        }
    }
    public async Task Edit(LeaveTypeEditViewModel model)
    {
        var leaveType = _mapper.Map<LeaveType>(model);
        _context.Update(leaveType);
        await _context.SaveChangesAsync();
    }

    public async Task Create(LeaveTypeCreateViewModel model)
    {
        var leaveType = _mapper.Map<LeaveType>(model);
        _context.Add(leaveType);
        await _context.SaveChangesAsync();

        return;
    }
    public bool LeaveTypeExists(int id)
    {
        return _context.LeaveTypes.Any(e => e.Id == id);
    }
    public async Task<bool> CheckIfLeaveTypeExist(string leaveTypeName)
    {
        var lowerCase = leaveTypeName.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.LeaveTypeName.ToLower().Equals(lowerCase));
    }
    public async Task<bool> CheckIfLeaveTypeExistForEdit(LeaveTypeEditViewModel leaveTypeEdit)
    {
        var lowerCase = leaveTypeEdit.LeaveTypeName.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.LeaveTypeName.ToLower().Equals(lowerCase) && q.Id != leaveTypeEdit.Id);
    }
}
