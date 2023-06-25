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

        public async Task<Principal> GetPrincipal(string principalId)
        {

            var principal = await _dbSet.Where(x => x.Id == principalId).FirstOrDefaultAsync();
            return principal;


        }
    }
}

