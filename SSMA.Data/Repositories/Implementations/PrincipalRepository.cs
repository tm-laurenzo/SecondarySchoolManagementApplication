using Microsoft.EntityFrameworkCore;
using SSMA.Data.Context;
using SSMA.Data.Repositories.Abstractions;
using SSMA.Models.Models;

namespace SSMA.Data.Repositories.Implementations
{
    public class PrincipalRepository : GenericRepository<Principal>, IPrincipalRepository
    {
        private readonly SsmaDbContext _context;
        private readonly DbSet<Principal> _dbSet;
        public PrincipalRepository(SsmaDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Principal>();
        }

        public async Task<Principal?> GetPrincipalAsync(string principalId)
        {
            var principal = await _dbSet.Where(x => x.Staff.AppUserId == principalId).FirstOrDefaultAsync();
            return principal;
        }
        public async Task<Principal?> GetPrincipalAsync()
        {
            var principal = await _dbSet.Where(x => x.Staff.AppUser.IsActive
                                    && (x.Staff.AppUser.IsSoftDeleted == false )).FirstOrDefaultAsync();
            return principal;
        }

        public async Task<bool> AddPrincipal(Principal principal)
        {
            await _dbSet.AddAsync(principal);
            return true;
        }
    }
}

