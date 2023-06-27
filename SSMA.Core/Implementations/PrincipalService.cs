using Microsoft.AspNetCore.Identity;
using SSMA.Core.Abstractions;
using SSMA.Data.UnitOfWork.Abstractions;
using SSMA.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Core.Implementations
{
    public class PrincipalService : IPrincipalService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly UserManager<AppUser> _userManager;
        public PrincipalService(IMapper mapper, IUnitOfWork unitOfWork,
            IMailService mailService, ILogger logger, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _mailService = mailService;
            _logger = logger;
        }
    }
}
