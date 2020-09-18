using Entities.Models;
using System.Threading.Tasks;

namespace Poslanci.Server.Repository.Interfaces
{
    public interface IZarazeniRepository : IRepositoryBase<Zarazeni>
    {
        Task<Zarazeni> GetZarazeni(short idPoslanec, short idOrgan);
    }
}
