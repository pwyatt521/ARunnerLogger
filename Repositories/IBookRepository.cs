using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Repositories
{
    public interface IBookRepository
    {
        BookModel Get(int id);
        Task<List<BookModel>> GetList();
        Task<List<BookModel>> SearchList(string searchText);
        void Save(BookModel Book);
        void Delete(int id);
    }
}