using Microsoft.AspNetCore.Mvc;
using SSMA.Core.Abstractions;
using SSMA.DTOs.PrincipalDTOs;
using SSMA.Utilities.Abstractions;

namespace SecondarySchoolManagementApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrincipalController : ControllerBase
    {
        private readonly IPrincipalService _principalService;
        private readonly ILoggerManager _logger;


        public PrincipalController(ILoggerManager logger, IPrincipalService principalService)
        {
            _principalService = principalService;
            _logger = logger;
        }

        [HttpPost]
        [Route("AddPrincipal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddPrincipal([FromBody] AddPrincipalDTO principalDto)
        {
            var result = await _principalService.AddPrincipal(principalDto);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPut]
        [Route("UpdatePrincipal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePrincipal([FromBody] UpdatePrincipalDTO updatePrincipalDto, string principalId)
        {
            var result = await _principalService.UpdatePrincipal(principalId, updatePrincipalDto);
            return StatusCode(result.StatusCode, result);
        }
    }
}
