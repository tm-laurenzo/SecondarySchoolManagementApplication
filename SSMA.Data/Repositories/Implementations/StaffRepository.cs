using Microsoft.EntityFrameworkCore;
using SSMA.Data.Context;
using SSMA.Data.Repositories.Abstractions;
using SSMA.Models.Models;

namespace SSMA.Data.Repositories.Implementations
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        private readonly SsmaDbContext _context;
        private readonly DbSet<Staff> _dbSet;
        public StaffRepository(SsmaDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Staff>();
        }

        public async Task<Staff?> GetStaffAsync(string staffId)
        {
            var staff = await _dbSet.Where(x => x.AppUserId == staffId).FirstOrDefaultAsync();
            return staff;
        }

        public async Task<bool> AddStaff(Staff staff)
        {
            await _dbSet.AddAsync(staff);
            return true;
        }
    }
}
