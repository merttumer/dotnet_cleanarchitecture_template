using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.Application.Templates
{
    public class PagedResult<T> : Result<T>
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }

        public static PagedResult<T> Ok(T data, int page, int perPage, int total, int totalPages)
        {
            return new PagedResult<T>
            {
                Success = true,
                Data = data,
                Page = page,
                PerPage = perPage,
                Total = total,
                Total_pages = totalPages
            };
        }
    }
}