using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SSMA.Core.Abstractions;
using SSMA.Data.UnitOfWork.Abstractions;
using SSMA.DTOs;
using SSMA.DTOs.PrincipalDTOs;
using SSMA.Models.Models;
using SSMA.Utilities.Abstractions;
using System.Net;
using System.Transactions;

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addPrincipalDTO"></param>
        /// <returns></returns>
        public async Task<Response<bool>> AddPrincipal(AddPrincipalDTO addPrincipalDTO)
        {
            bool savePrincipal = false;
            //Create AppUser
            var appUser = _mapper.Map<AppUser>(addPrincipalDTO);

            //Create Principal
            var principal = _mapper.Map<Principal>(addPrincipalDTO);

            //Create Staff
            Staff staff = new Staff
            {
                AppUserId = appUser.Id,
                AppUser = appUser,
                Principal = principal,
                Email = addPrincipalDTO.Email,
                Phone = addPrincipalDTO.Phone

            };
            principal.Staff = staff;
            //1 add appuser : DONE
            //2 if 1 is successful add staff : DONE
            //3 if 2 is successful add principal : DONE


            appUser.IsActive = true;
            appUser.EmailConfirmed = true;
            var result = await _userManager.CreateAsync(appUser);

            if (result.Succeeded)
            {
                var saveStaffResult = await _unitOfWork.Staff.AddStaff(staff);
                if (saveStaffResult)
                {
                    savePrincipal = await _unitOfWork.Principals.AddPrincipal(principal);
                    await _unitOfWork.Save();
                }
            }
           
          
          
            if(savePrincipal) {
                var response = new Response<bool>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Succeeded = true,
                    Data = true,
                    Message = $" Principal {principal.Staff.AppUser.FirstName} {principal.Staff.AppUser.FirstName} with ID: : created successfully"
                };
                return response;
            }
            //TODO convert to proper response
            return null;
          
        }

        public async Task<Response<string>> UpdatePrincipal(string principalId, UpdatePrincipalDTO updatePrincipalDTO)
        {
            // TODO: wrap this in try-catch block
            var response = new Response<string>();
            var principal = await _unitOfWork.Principals.GetPrincipalAsync(principalId);


            using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if (principal != null)
                {
                    // Update user details in AspNetAppUser table
                    var user = await _userManager.FindByIdAsync(principalId);
                    var userUpdateResult = await UpdateUser(user, updatePrincipalDTO);

                    if (userUpdateResult.Succeeded)
                    {
                        //  TODO: Update the staff
                        var staff = principal.Staff;
                        // TODO: update the principal
                        await _unitOfWork.Save();

                        response.Message = "Update Successful";
                        response.StatusCode = (int)HttpStatusCode.OK;
                        response.Succeeded = true;
                        response.Data = principalId;
                        transaction.Complete();
                        return response;

                    }

                    transaction.Dispose();
                    response.Message = "Something went wrong, when updating the AppUser table. Please try again later";
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    response.Succeeded = false;
                    return response;
                }
                response.Message = "Customer Not Found";
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Succeeded = false;
                transaction.Complete();
                return response;
            }
        }

        private async Task<IdentityResult> UpdateUser(AppUser user, UpdatePrincipalDTO model)
        {
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.Phone;
            user.Age = model.Age;
            user.Email = model.Email;
            return await _userManager.UpdateAsync(user);
        }
       


    }
}
