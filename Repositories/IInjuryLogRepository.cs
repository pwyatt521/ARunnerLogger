using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.InjuryLog
{
    public interface IInjuryLogRepository
    {
        InjuryLogModel Get(int id);
        Task<List<InjuryLogModel>> GetList();
        Task<List<InjuryLogModel>> GetList(int InjuryID);
        void Save(InjuryLogModel Injury);
        void Delete(int id);
    }
}