using Microsoft.EntityFrameworkCore;
using SSMA.Data.Context;
using SSMA.Data.Repositories.Abstractions;
using SSMA.Models.Models;

namespace SSMA.Data.Repositories.Implementations
{
    public class PrincipalRepository : GenericRepository<Principal>, IPrincipalRepository
    {
        private readonly SsmaDbContext _context;
        private readonly DbSet<Principal> _dbSetPrincipal;
        private readonly DbSet<Staff> _dbSetStaff;
        public PrincipalRepository(SsmaDbContext context) : base(context)
        {
            _context = context;
            _dbSetPrincipal = _context.Set<Principal>();
            _dbSetStaff = _context.Set<Staff>();
        }

        public async Task<Principal?> GetPrincipalAsync(string principalId)
        {
            var principal = await _dbSetPrincipal.Where(x => x.Staff.AppUserId == principalId).FirstOrDefaultAsync();
            return principal;
        }
        public async Task<Principal?> GetPrincipalAsync()
        {
            var principal = await _dbSetPrincipal.Where(x => x.Staff.AppUser.IsActive
                                    && (x.Staff.AppUser.IsSoftDeleted == false)).FirstOrDefaultAsync();
            if (principal != null)
            {
                var appuser = await _context.Users.Where(x => x.Id == principal.StaffId).FirstOrDefaultAsync();
                if (appuser == null)
                {
                    return principal;
                }

                principal.Staff = await _context.Staffs.Where(x => x.AppUserId == principal.StaffId).FirstOrDefaultAsync();
            }
            return principal;

        }

        public async Task<bool> AddPrincipal(Principal principal)
        {
            await _dbSetPrincipal.AddAsync(principal);
            return true;
        }
    }
}

