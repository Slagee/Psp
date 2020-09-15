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
                .Include(os => os.OsobniData)
                .Include(ob => ob.VolebniObdobi).Where(x => x.VolebniObdobi.Zkratka == "PSP8")
                .Include(ka => ka.Kandidatka)
                .Include(kr => kr.Kraj)
                .OrderBy(x => x.Kandidatka.Zkratka).ToListAsync();

            return PagedList<Poslanec>.ToPagedList(poslanci, poslanciParameters.PageNumber, poslanciParameters.PageSize);
        }
    }
}
