using Entities.Models;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPoslanecRepository : IRepositoryBase<Poslanec>
    {
        Task<PagedList<Poslanec>> GetCurrentPoslanci();
    }
}
