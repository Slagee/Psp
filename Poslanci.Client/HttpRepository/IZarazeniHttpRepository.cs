using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Client.HttpRepository
{
    public interface IZarazeniHttpRepository
    {
        Task<List<ZarazeniDto>> GetZarazeni(short id);

        Task<List<ZarazeniDto>> GetClenstvi(short id);

        Task<List<ZarazeniDto>> GetFunkce(short id);
    }
}
