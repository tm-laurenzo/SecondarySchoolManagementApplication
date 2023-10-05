using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SSMA.Core.Abstractions;
using SSMA.Data.UnitOfWork.Abstractions;
using SSMA.DTOs;
using SSMA.DTOs.PrincipalDTOs;
using SSMA.Models.Models;
using SSMA.Utilities.Abstractions;

namespace SSMA.Core.Implementations
{
    public class PrincipalService : IPrincipalService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly UserManager<AppUser> _userManager;
        public PrincipalService(IMapper mapper, IUnitOfWork unitOfWork, ILoggerManager logger, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _logger = logger;
        }


        //There can only be one principal at any given time in a school
        public async Task<Response<bool>> AddPrincipal(AddPrincipalDTO addPrincipalDTO)
        {

            var appUser = _mapper.Map<AppUser>(addPrincipalDTO);
            var principal = _mapper.Map<Principal>(addPrincipalDTO);
            principal.AppUserId = appUser.Id;
            appUser.Principal = principal;
            appUser.IsActive = true;
            appUser.EmailConfirmed = true;

            var response = new Response<bool>()
            {
                StatusCode = StatusCodes.Status200OK,
                Succeeded = true,
                Data = true,
                Message = $" Principal {principal.AppUser.FirstName} {principal.AppUser.FirstName} with ID: : created successfully"
            };
            return response;
        }
    }
}
