using SSMA.DTOs;
using SSMA.DTOs.PrincipalDTOs;

namespace SSMA.Core.Abstractions
{
    public interface IPrincipalService
    {
        Task<Response<bool>> AddPrincipal(AddPrincipalDTO addPrincipalDTO);
    }
}
