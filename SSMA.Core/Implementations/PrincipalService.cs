using Microsoft.AspNetCore.Identity;
using SSMA.Core.Abstractions;
using SSMA.Data.UnitOfWork.Abstractions;
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
    }
}
