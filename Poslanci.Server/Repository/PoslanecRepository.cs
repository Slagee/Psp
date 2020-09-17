using Entities.Models;
using Entities.RequestFeatures;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Poslanci.Server.Paging;
using Poslanci.Server.Repository.RepositoryExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class PoslanecRepository : RepositoryBase<Poslanec>, IPoslanecRepository
    {
        public PoslanecRepository(PoliticsContext politicsContext)
            : base(politicsContext)
        {
        }

        public async Task<PagedList<Poslanec>> GetCurrentPoslanci(PoslanciParameters poslanciParameters)
        {
            var poslanci = await FindAll()
                .Search(poslanciParameters.SearchTerm)
                .Houses(poslanciParameters.Houses)
                .Include(os => os.OsobniData)
                .Include(ob => ob.VolebniObdobi)
                .Include(ka => ka.Kandidatka)
                .Include(kr => kr.Kraj)
                .Sort(poslanciParameters.OrderBy)
                .ToListAsync();

            return PagedList<Poslanec>.ToPagedList(poslanci, poslanciParameters.PageNumber, poslanciParameters.PageSize);
        }

        public async Task<Poslanec> GetPoslanec(short id) =>
            await FindByCondition(p => p.IdPoslanec.Equals(id)).FirstOrDefaultAsync();
    }
}
