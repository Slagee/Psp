using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Poslanci.Server.Repository.Interfaces;

namespace Poslanci.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZarazeniController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;

        public ZarazeniController(IRepositoryWrapper repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetZarazeni(short id)
        {
            var funkce = await _repo.Zarazeni.GetFunkce(id);
            var clenstvi = await _repo.Zarazeni.GetClenstvi(id);

            var funkceResult = _mapper.Map<List<ZarazeniDto>>(funkce);
            var clenstviResult = _mapper.Map<List<ZarazeniDto>>(clenstvi);

            return Ok(new { funkceResult, clenstviResult });
        }

        [HttpGet("{id}/funkce")]
        public async Task<IActionResult> GetFunkce(short id)
        {
            var funkce = await _repo.Zarazeni.GetFunkce(id);

            var funkceResult = _mapper.Map<List<ZarazeniDto>>(funkce);

            return Ok(funkceResult);
        }

        [HttpGet("{id}/clenstvi")]
        public async Task<IActionResult> GetClenstvi(short id)
        {
            var clenstvi = await _repo.Zarazeni.GetClenstvi(id);

            var clenstviResult = _mapper.Map<List<ZarazeniDto>>(clenstvi);

            return Ok(clenstviResult);
        }
    }
}
