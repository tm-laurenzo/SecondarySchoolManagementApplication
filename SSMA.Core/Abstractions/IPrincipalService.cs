using SSMA.DTOs;
using SSMA.DTOs.PrincipalDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Core.Abstractions
{
    public interface IPrincipalService
    {
        Task<Response<bool>> AddPrincipal(AddPrincipalDTO addPrincipalDTO);
    }
}
