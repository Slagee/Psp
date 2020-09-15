using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Server.Repository.RepositoryExtensions
{
    public static class RepositoryPoslanecExtensions
    {
        public static IQueryable<Poslanec> Search(this IQueryable<Poslanec> poslanecs, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return poslanecs;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return poslanecs.Where(p => p.OsobniData.Jmeno.ToLower().Contains(lowerCaseSearchTerm) || p.OsobniData.Prijmeni.ToLower().Contains(lowerCaseSearchTerm));
        }
    }
}
