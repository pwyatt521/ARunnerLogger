using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Repositories.InjuryLog
{
    public class InjuryLogCachingDBRepository : InjuryLogDBRepository
    {
        private readonly string _CachePrefix = "BookCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private string _CacheIDListKey { get { return $"{_CachePrefix}_IDList"; } }
        private IMemoryCache _Cache;
        public InjuryLogCachingDBRepository(IConfiguration InjuryLogConfig, IMemoryCache cache) : base(InjuryLogConfig)
        {
            _Cache = cache;
        }
        public override async Task<List<InjuryLogModel>> GetList()
        {

            var InjuryLogList = (List<InjuryLogModel>) _Cache.Get(_CacheListKey);
            if (InjuryLogList != null)
            {
                return InjuryLogList;
            }
            else
            {
                InjuryLogList = await base.GetList();
                _Cache.Set(_CacheListKey, InjuryLogList);
                return InjuryLogList;
            }

        }

        public override async Task<List<InjuryLogModel>> GetList(int InjuryID)
        {

            var InjuryLogList = (List<InjuryLogModel>) _Cache.Get(_CacheIDListKey);
            if (InjuryLogList != null)
            {
                return InjuryLogList;
            }
            else
            {
                InjuryLogList = await base.GetList(InjuryID);
                _Cache.Set(_CacheIDListKey, InjuryLogList);
                return InjuryLogList;
            }

        }
        public override void Save(InjuryLogModel InjuryLog)
        {
            base.Save(InjuryLog);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}