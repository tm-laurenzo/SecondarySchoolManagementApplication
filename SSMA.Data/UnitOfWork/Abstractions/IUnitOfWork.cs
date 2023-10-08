using SSMA.Data.Repositories.Abstractions;

namespace SSMA.Data.UnitOfWork.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IPrincipalRepository Principals { get; }
        IStaffRepository Staff { get; }
        public Task Save();
    }
}