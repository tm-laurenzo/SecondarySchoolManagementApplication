using SSMA.Data.Context;
using SSMA.Data.Repositories.Abstractions;
using SSMA.Data.Repositories.Implementations;
using SSMA.Data.UnitOfWork.Abstractions;

namespace hotel_booking_data.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SsmaDbContext _context;
        private IPrincipalRepository _principal;

        public UnitOfWork(SsmaDbContext context)
        {
            _context = context;
        }

        public IPrincipalRepository Principals => _principal ??= new PrincipalRepository(_context);


        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
