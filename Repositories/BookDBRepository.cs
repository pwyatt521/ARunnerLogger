using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Lab8;

namespace Book.Repositories
{
    public class BookDBRepository : IBookRepository
    {
        private IConfiguration configuration;
        private string conString;
        public BookDBRepository(IConfiguration config)
        {
            configuration = config;

            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual BookModel Get(int id)
        {
            
            BookModel Book = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Book = new BookModel();
                            Book.ID = (int) reader["ID"];
                            Book.BTitle = reader["BTitle"].ToString();
                            Book.BAuthor = reader["BAuthor"].ToString();
                            Book.BSummary =  reader["BSummary"].ToString();
                            Book.BRating = (int) reader["BRating"];
                            Book.BLength = (int) reader["BLength"];
                            Book.PostedBy =  reader["PostedBy"].ToString();
                        }
                    }
                }

            }
            return Book;
        }


        public virtual async Task<List<BookModel>> SearchList(string searchText)
        {
            List<BookModel> BookList = (await GetList()).Where(a => a.BTitle.ToLower().Contains(searchText.ToLower())).ToList();
            return BookList;
        }
        public virtual async Task<List<BookModel>> GetList()
        {
            List<BookModel> BookList = new List<BookModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            BookModel Book = new BookModel();
                            Book.ID = (int) reader["ID"];
                            Book.BTitle = reader["BTitle"].ToString();
                            Book.BAuthor = reader["BAuthor"].ToString();
                            Book.BSummary =  reader["BSummary"].ToString();
                            Book.BRating = (int) reader["BRating"];
                            Book.BLength = (int) reader["BLength"];
                            Book.PostedBy =  reader["PostedBy"].ToString();
                            BookList.Add(Book);
                        }
                    }
                }

            }
            return BookList;
        }


        public virtual void Save(BookModel Book)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_InsertUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", Book.ID);
                    command.Parameters.AddWithValue("@BTitle", Book.BTitle);
                    command.Parameters.AddWithValue("@BAuthor", Book.BAuthor);
                    command.Parameters.AddWithValue("@BSummary", Book.BSummary);
                    command.Parameters.AddWithValue("@BRating", Book.BRating);
                    command.Parameters.AddWithValue("@BLength", Book.BLength);
                    command.Parameters.AddWithValue("@PostedBy", Book.PostedBy);
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        Console.Error.WriteLine("Didn't Work");
                    }
                }
            }
        }
        public virtual void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    
                    command.Parameters.AddWithValue("@ID", id);
                    
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}