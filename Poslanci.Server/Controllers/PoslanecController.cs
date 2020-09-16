using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Entities.DataTransferObjects;
using Entities.RequestFeatures;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public async Task<IActionResult> Get([FromQuery] PoslanciParameters poslanciParameters)
        {
            try
            {
                var poslanci = await _repo.Poslanec.GetCurrentPoslanci(poslanciParameters);

                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(poslanci.MetaData));

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
