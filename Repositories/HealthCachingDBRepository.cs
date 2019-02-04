using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Health.Repositories
{
    public class HealthCachingDBRepository : HealthDBRepository
    {
        private readonly string _CachePrefix = "AdventureCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public HealthCachingDBRepository(IConfiguration Config, IMemoryCache cache) : base(Config)
        {
            _Cache = cache;
        }
        public override async Task<List<HealthModel>> GetList()
        {

            var HealthList = (List<HealthModel>) _Cache.Get(_CacheListKey);
            if (HealthList != null)
            {
                return HealthList;
            }
            else
            {
                HealthList = await base.GetList();
                _Cache.Set(_CacheListKey, HealthList);
                return HealthList;
            }

        }
        public override void Save(HealthModel Health)
        {
            base.Save(Health);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}