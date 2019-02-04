using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Rehab.Repositories
{
    public class RehabCachingDBRepository : RehabDBRepository
    {
        private readonly string _CachePrefix = "RehabCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public RehabCachingDBRepository(IConfiguration Config, IMemoryCache cache) : base(Config)
        {
            _Cache = cache;
        }
        public override async Task<List<RehabModel>> GetList()
        {

            var RehabList = (List<RehabModel>) _Cache.Get(_CacheListKey);
            if (RehabList != null)
            {
                return RehabList;
            }
            else
            {
                RehabList = await base.GetList();
                _Cache.Set(_CacheListKey, RehabList);
                return RehabList;
            }

        }
        public override void Save(RehabModel Rehab)
        {
            base.Save(Rehab);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}