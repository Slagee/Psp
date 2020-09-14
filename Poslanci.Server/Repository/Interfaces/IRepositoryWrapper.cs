using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepositoryWrapper
    {
        IPoslanecRepository Poslanec { get; }
        Task SaveAsync();
    }
}
