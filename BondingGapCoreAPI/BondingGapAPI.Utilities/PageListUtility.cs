using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BondingGapAPI.Utilities
{
    public class PageListUtility<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int Skip { get; set; }

        public List<T> Result { get; set; }

        public PageListUtility(List<T> items, int count, int pageNumber, int pageSize, int skip)
        {
            Result = items;
            TotalCount = count;
            TotalPage = (int)Math.Ceiling(TotalCount / (double)pageSize);
            CurrentPage = pageNumber < 1 ? 1 : (pageNumber > TotalPage ? TotalPage : pageNumber); ;
            PageSize = pageSize;
            Skip = skip;
        }


        /// <summary>
        /// Phân trang theo tiện ích Update 10/01/2019
        /// </summary>
        /// <param name="source">Danh sách truyền vào</param>
        /// <param name="pageNumber">Trang hiện tại</param>
        /// <param name="pageSize">Số lượng dòng trên một trang</param>
        /// <returns> Một đối tượng PageListUtility theo kiểu data truyền vào </returns>
        public static async Task<PageListUtility<T>> PageListAsync(IQueryable<T> source, int pageNumber, int pageSize = 10)
        {
            var count = await source.CountAsync();
            int skip = (pageNumber - 1) * pageSize;
            var items = await source.Skip(skip).Take(pageSize).ToListAsync();
            return new PageListUtility<T>(items, count, pageNumber, pageSize, skip);
        }


    }

}
