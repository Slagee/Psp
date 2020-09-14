using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPoslanecRepository : IRepositoryBase<Poslanec>
    {
        Task<IEnumerable<Poslanec>> GetCurrentPoslanci();
    }
}
