using AutoMapper.QueryableExtensions;
using Entities.Models;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

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

        public static IQueryable<Poslanec> Sort(this IQueryable<Poslanec> poslanecs, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return poslanecs;

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Poslanec).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];


                if (propertyFromQueryName.Contains('.'))
                {
                    var temp = propertyFromQueryName.Split('.')[0];
                    var simpleCheck = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(temp, StringComparison.InvariantCultureIgnoreCase));
                    if (simpleCheck == null)
                        continue;

                    var dir = param.EndsWith(" desc") ? "descending" : "ascending";
                    orderQueryBuilder.Append($"{propertyFromQueryName} {dir}, ");
                    continue;
                }

                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(orderQuery))
            {
                return poslanecs.OrderBy(e => e.OsobniData.Prijmeni);
            }
            return poslanecs.OrderBy(orderQuery);
        }
    }
}
