using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IPoslanecRepository Poslanec { get; }
        Task SaveAsync();
    }
}
