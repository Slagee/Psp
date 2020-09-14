using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace Poslanci.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoslanecController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;

        public PoslanecController(IRepositoryWrapper repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPoslanec()
        {
            try
            {
                var poslanci = await _repo.Poslanec.GetAllPoslanecAsync();

                var poslanciResult = _mapper.Map<IEnumerable<PoslanecDto>>(poslanci);
                return Ok(poslanciResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
