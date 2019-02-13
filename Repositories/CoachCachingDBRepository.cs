using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Coach.Repositories
{
    public class CoachCachingDBRepository : CoachDBRepository
    {
        private readonly string _CachePrefix = "CoachCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public CoachCachingDBRepository(IConfiguration Config, IMemoryCache cache) : base(Config)
        {
            _Cache = cache;
        }
        public override async Task<List<NewsModel>> GetList()
        {

            var newsList = (List<NewsModel>) _Cache.Get(_CacheListKey);
            if (newsList != null)
            {
                return newsList;
            }
            else
            {
                newsList = await base.GetList();
                _Cache.Set(_CacheListKey, newsList);
                return newsList;
            }

        }
        public override void Save(NewsModel news)
        {
            base.Save(news);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}