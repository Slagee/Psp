using Entities.DataTransferObjects;
using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poslanci.Client.HttpRepository
{
    public interface IPoslanciHttpRepository
    {
        Task<List<PoslanecDto>> GetCurrentPoslanci();
    }
}
