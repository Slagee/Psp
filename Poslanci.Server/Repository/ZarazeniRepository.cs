using Entities.Models;
using Poslanci.Server.Repository.Interfaces;
using System;
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

        public Task<Zarazeni> GetZarazeni(short idPoslanec, short idOrgan)
        {
            throw new NotImplementedException();
        }
    }
}
