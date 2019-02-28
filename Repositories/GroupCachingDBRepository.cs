using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Repositories.Group
{
    public class GroupCachingDBRepository : GroupDBRepository
    {
        private readonly string _CachePrefix = "GroupCacheRepo";
        private string _CacheListKey { get { return $"{_CachePrefix}_List"; } }
        private IMemoryCache _Cache;
        public GroupCachingDBRepository(IConfiguration Config, IMemoryCache cache) : base(Config)
        {
            _Cache = cache;
        }
        public override async Task<List<GroupModel>> GetList()
        {
            var GroupList = (List<GroupModel>) _Cache.Get(_CacheListKey);
            if (GroupList != null)
            {
                return GroupList;
            }
            else
            {
                GroupList = await base.GetList();
                _Cache.Set(_CacheListKey, GroupList);
                return GroupList;
            }
        }
        public override void Save(GroupModel Group)
        {
            base.Save(Group);
            _Cache.Remove(_CacheListKey);
        }
        public override void Update(GroupModel Group)
        {
            base.Update(Group);
            _Cache.Remove(_CacheListKey);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            _Cache.Remove(_CacheListKey);
        }
        public override void AddMember(int id)
        {
            base.AddMember(id);
            _Cache.Remove(_CacheListKey);
        }
    }
}