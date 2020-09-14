using Entities.DataTransferObjects;
using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poslanci.Server.HttpRepository
{
    public interface IPoslanciHttpRepository
    {
        Task<List<PoslanecDto>> GetCurrentPoslanci();
    }
}
