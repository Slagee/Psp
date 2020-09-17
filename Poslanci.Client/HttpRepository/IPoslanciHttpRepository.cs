using Entities.DataTransferObjects;
using Entities.RequestFeatures;
using Poslanci.Client.Features;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poslanci.Client.HttpRepository
{
    public interface IPoslanciHttpRepository
    {
        Task<PagingResponse<PoslanecDto>> GetCurrentPoslanci(PoslanciParameters poslanciParameters);
        Task<PoslanecDto> GetPoslanec(string id);
    }
}
