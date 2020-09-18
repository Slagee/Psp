using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Poslanci.Server.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Server.Repository
{
    public class ZarazeniRepository : RepositoryBase<Zarazeni>, IZarazeniRepository
    {

        public ZarazeniRepository(PoliticsContext politicsContext)
            : base(politicsContext)
        {
        }

        public async Task<List<Zarazeni>> GetClenstvi(short idOsoba) =>
            await FindAll().Where(x => x.IdOsoba.Equals(idOsoba))
                .Where(x => x.ClFunkce.Equals((short)0))
                .Include(org => org.IdOrgan).ThenInclude(typOrg => typOrg.TypOrganu)
                .ToListAsync();

        public async Task<List<Zarazeni>> GetFunkce(short idOsoba) =>
            await FindAll().Where(x => x.IdOsoba.Equals(idOsoba))
                .Where(x => x.ClFunkce.Equals((short)1))
                .Include(funk => funk.IdFunkce).ThenInclude(org => org.OrganClenstvi)
                .Include(funk => funk.IdFunkce).ThenInclude(tf => tf.TypFunkce)
                .ToListAsync();
    }
}
