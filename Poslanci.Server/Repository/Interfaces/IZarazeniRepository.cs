using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poslanci.Server.Repository.Interfaces
{
    public interface IZarazeniRepository : IRepositoryBase<Zarazeni>
    {
        Task<List<Zarazeni>> GetClenstvi(short idOsoba);
        Task<List<Zarazeni>> GetFunkce(short idOsoba);
    }
}
