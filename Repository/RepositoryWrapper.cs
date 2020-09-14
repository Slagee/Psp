using Contracts;
using Entities.Models;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly PoliticsContext _context;
        private IPoslanecRepository _poslanec;

        public RepositoryWrapper(PoliticsContext politicsContext)
        {
            _context = politicsContext;
        }

        public IPoslanecRepository Poslanec
        {
            get
            {
                if (_poslanec == null)
                {
                    _poslanec = new PoslanecRepository(_context);
                }

                return _poslanec;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
