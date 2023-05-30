using SSMA.Data.Context;
using SSMA.Data.Repositories.Abstractions;
using SSMA.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Data.Repositories.Implementations
{
    public class PrincipalRepository : GenericRepository<AppUser>, IPrincipalRepository
    {
        private readonly SsmaDbContext _context;
        public PrincipalRepository(SsmaDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
