using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Group
{
    public interface IGroupRepository
    {
        GroupModel Get(int id);
        Task<List<GroupModel>> GetList();
        void Save(GroupModel group);
        void Update(GroupModel group);
        void Delete(int id);

        void AddMember(int id);
    }
}