using SSMA.Models.Models;

namespace SSMA.Data.Repositories.Abstractions
{
    public interface IStaffRepository
    {
        Task<bool> AddStaff(Staff staff);
        Task<Staff?> GetStaffAsync(string staffId);
    }
}