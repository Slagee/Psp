using Entities.Models;
using Poslanci.Server.Repository.Interfaces;
using System.Threading.Tasks;

namespace Poslanci.Server.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly PoliticsContext _context;
        private IPoslanecRepository _poslanec;
        private IZarazeniRepository _zarazeni;

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

        public IZarazeniRepository Zarazeni
        {
            get
            {
                if (_zarazeni == null)
                {
                    _zarazeni = new ZarazeniRepository(_context);
                }

                return _zarazeni;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
