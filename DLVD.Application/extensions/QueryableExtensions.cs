using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ApplySorting<T>(
                    this IQueryable<T> query,
                    string? sortOrder,
                    Expression<Func<T, object>> orderByExp) 
        {

            if (sortOrder?.ToLower() == "desc")
                query = query.OrderByDescending(orderByExp);
            else
                query = query.OrderBy(orderByExp);

            return query;
        }
    }
}
