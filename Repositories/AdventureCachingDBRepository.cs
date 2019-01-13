using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Adventure.Repositories
{
    public class AdventureCachingDBRepository : AdventureDBRepository
    {
        private readonly string _CachePrefix = "AdventureCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public AdventureCachingDBRepository(IConfiguration Config, IMemoryCache cache) : base(Config)
        {
            _Cache = cache;
        }
        public override async Task<List<AdventureModel>> GetList()
        {

            var AdventureList = (List<AdventureModel>) _Cache.Get(_CacheListKey);
            if (AdventureList != null)
            {
                return AdventureList;
            }
            else
            {
                AdventureList = await base.GetList();
                _Cache.Set(_CacheListKey, AdventureList);
                return AdventureList;
            }

        }
        public override void Save(AdventureModel Adventure)
        {
            base.Save(Adventure);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}