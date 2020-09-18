using Entities.Models;
using Entities.RequestFeatures;
using Poslanci.Server.Paging;
using System.Threading.Tasks;

namespace Poslanci.Server.Repository.Interfaces
{
    public interface IPoslanecRepository : IRepositoryBase<Poslanec>
    {
        Task<PagedList<Poslanec>> GetCurrentPoslanci(PoslanciParameters poslanciParameters);
        Task<Poslanec> GetPoslanec(short id);
    }
}
