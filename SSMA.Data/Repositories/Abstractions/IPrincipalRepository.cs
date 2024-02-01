using SSMA.Models.Models;
using System.Threading.Tasks;

namespace SSMA.Data.Repositories.Abstractions
{
    public interface IPrincipalRepository
    {
        public Task<Principal?> GetPrincipalByIdAsync(string principalId);
        public Task<Principal?> GetPrincipalAsync();
        public Task<bool> AddPrincipal(Principal principal);
        public Task<bool> HardDeletePrincipal();
        public Task<bool> SoftDeletePrincipal();
    }
}