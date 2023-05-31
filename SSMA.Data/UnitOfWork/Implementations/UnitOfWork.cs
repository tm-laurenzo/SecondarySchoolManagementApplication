using SSMA.Data.Context;
using SSMA.Data.UnitOfWork.Abstractions;

namespace hotel_booking_data.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SsmaDbContext _context;

        public UnitOfWork(SsmaDbContext context)
        {
            _context = context;
        }

        
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
