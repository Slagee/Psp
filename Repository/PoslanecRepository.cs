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

        public async Task<IEnumerable<Poslanec>> GetAllPoslanecAsync()
        {
            return await FindAll()
                .Include(os => os.OsobniData)
                .OrderBy(po => po.OsobniData.Prijmeni)
                .ToListAsync();
        }
    }
}
