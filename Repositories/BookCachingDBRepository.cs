using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Book.Repositories
{
    public class BookCachingDBRepository : BookDBRepository
    {
        private readonly string _CachePrefix = "BookCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public BookCachingDBRepository(IConfiguration BookConfig, IMemoryCache cache) : base(BookConfig)
        {
            _Cache = cache;
        }
        public override async Task<List<BookModel>> GetList()
        {

            var BookList = (List<BookModel>) _Cache.Get(_CacheListKey);
            if (BookList != null)
            {
                return BookList;
            }
            else
            {
                BookList = await base.GetList();
                _Cache.Set(_CacheListKey, BookList);
                return BookList;
            }

        }
        public override void Save(BookModel Book)
        {
            base.Save(Book);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}