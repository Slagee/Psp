using System.Threading.Tasks;

namespace Poslanci.Server.Repository.Interfaces
{
    public interface IRepositoryWrapper
    {
        IPoslanecRepository Poslanec { get; }
        IZarazeniRepository Zarazeni { get; }
        Task SaveAsync();
    }
}
