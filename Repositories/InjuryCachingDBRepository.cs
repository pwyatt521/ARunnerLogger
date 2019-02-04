using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Injury.Repositories
{
    public class InjuryCachingDBRepository : InjuryDBRepository
    {
        private readonly string _CachePrefix = "BookCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public InjuryCachingDBRepository(IConfiguration InjuryConfig, IMemoryCache cache) : base(InjuryConfig)
        {
            _Cache = cache;
        }
        public override async Task<List<InjuryModel>> GetList()
        {

            var InjuryList = (List<InjuryModel>) _Cache.Get(_CacheListKey);
            if (InjuryList != null)
            {
                return InjuryList;
            }
            else
            {
                InjuryList = await base.GetList();
                _Cache.Set(_CacheListKey, InjuryList);
                return InjuryList;
            }

        }
        public override void Save(InjuryModel Injury)
        {
            base.Save(Injury);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}