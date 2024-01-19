using SSMA.Models.Models;
using System.Threading.Tasks;

namespace SSMA.Data.Repositories.Abstractions
{
    public interface IPrincipalRepository
    {
        public Task<Principal?> GetPrincipalByIdAsync(string principalId);
        public Task<Principal?> GetPrincipalAsync();
        public Task<bool> AddPrincipal(Principal principal);
        public Taxk<bool> HardDeletePrincipal();
        public Taxk<bool> SoftDeletePrincipal();
    }
}