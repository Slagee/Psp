using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Poslanec>> GetCurrentPoslanci()
        {
            return await FindAll()
                .Include(os => os.OsobniData)
                .Include(ob => ob.VolebniObdobi).Where(x => x.VolebniObdobi.Zkratka == "PSP8")
                .Include(ka => ka.Kandidatka)
                .Include(kr => kr.Kraj)
                .OrderBy(x => x.Kandidatka.Zkratka)
                .ToListAsync();
        }
    }
}
