using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WorkOut.Repositories
{
    public class WorkOutCachingDBRepository : WorkOutDBRepository
    {
        private readonly string _CachePrefix = "WorkOutCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public WorkOutCachingDBRepository(IConfiguration WorkOutConfig, IMemoryCache cache) : base(WorkOutConfig)
        {
            _Cache = cache;
        }
        public override async Task<List<WorkOutModel>> GetList()
        {

            var WorkOutList = (List<WorkOutModel>) _Cache.Get(_CacheListKey);
            if (WorkOutList != null)
            {
                return WorkOutList;
            }
            else
            {
                WorkOutList = await base.GetList();
                _Cache.Set(_CacheListKey, WorkOutList);
                return WorkOutList;
            }

        }
        public override void Save(WorkOutModel WorkOut)
        {
            base.Save(WorkOut);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}