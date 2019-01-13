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

namespace Adventure.Repositories
{
    public class AdventureDBRepository : IAdventureRepository
    {
        private IConfiguration Configuration;
        private string conString;
        public AdventureDBRepository( IConfiguration config)
        {
            Configuration = config;
            
            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual AdventureModel Get(int id)
        {
            AdventureModel Adventure = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Adventure_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Adventure = new AdventureModel();
                            Adventure.ID = (int) reader["ID"];
                            Adventure.AName = reader["AName"].ToString();
                            Adventure.ADescription =  reader["ADescription"].ToString();
                            Adventure.ARating = (int) reader["ARating"];
                            Adventure.PostedBy =  reader["PostedBy"].ToString();
                        }
                    }
                }

            }
            return Adventure;
        }


        public virtual async Task<List<AdventureModel>> SearchList(string searchText)
        {
            List<AdventureModel> AdventureList = (await GetList()).Where(a => a.AName.ToLower().Contains(searchText.ToLower())).ToList();
            return AdventureList;
        }
        public virtual async Task<List<AdventureModel>> GetList()
        {
            List<AdventureModel> AdventureList = new List<AdventureModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Adventure_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            AdventureModel Adventure = new AdventureModel();
                            Adventure.ID = (int) reader["ID"];
                            Adventure.AName = reader["AName"].ToString();
                            Adventure.ADescription =  reader["ADescription"].ToString();
                            Adventure.ARating = (int) reader["ARating"];
                            Adventure.PostedBy =  reader["PostedBy"].ToString();
                        
                            AdventureList.Add(Adventure);
                        }
                    }
                }

            }
            return AdventureList;
        }


        public virtual void Save(AdventureModel Adventure)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Adventure_InsertUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", Adventure.ID);
                    command.Parameters.AddWithValue("@AName", Adventure.AName);
                    command.Parameters.AddWithValue("@ADescription", Adventure.ADescription);
                    command.Parameters.AddWithValue("@ARating", Adventure.ARating);
                    command.Parameters.AddWithValue("@PostedBy", Adventure.PostedBy);
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
                using (SqlCommand command = new SqlCommand("Adventure_Delete", connection))
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