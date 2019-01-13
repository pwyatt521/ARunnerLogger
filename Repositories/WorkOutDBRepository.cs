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

namespace WorkOut.Repositories
{
    public class WorkOutDBRepository : IWorkOutRepository
    {
        private IConfiguration configuration;
        private string conString;
        public WorkOutDBRepository(IConfiguration config)
        {
            configuration = config;
            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual WorkOutModel Get(int id)
        {
            
            WorkOutModel WorkOut = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("WorkOut_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            WorkOut = new WorkOutModel();
                            WorkOut.ID = (int) reader["ID"];
                            WorkOut.WName = reader["WName"].ToString();
                            WorkOut.WDescription =  reader["WDescription"].ToString();
                            WorkOut.WRating = (int) reader["WRating"];
                            WorkOut.WDate = (DateTime) reader["WDate"];
                            WorkOut.PostedBy =  reader["PostedBy"].ToString();
                        }
                    }
                }

            }
            return WorkOut;
        }


        public virtual async Task<List<WorkOutModel>> SearchList(string searchText)
        {
            List<WorkOutModel> WorkOutList = (await GetList()).Where(a => a.WName.ToLower().Contains(searchText.ToLower())).ToList();
            return WorkOutList;
        }
        public virtual async Task<List<WorkOutModel>> GetList()
        {
            List<WorkOutModel> WorkOutList = new List<WorkOutModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("WorkOut_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            WorkOutModel WorkOut = new WorkOutModel();
                            WorkOut.ID = (int) reader["ID"];
                            WorkOut.WName = reader["WName"].ToString();
                            WorkOut.WDescription =  reader["WDescription"].ToString();
                            WorkOut.WRating = (int) reader["WRating"];
                            WorkOut.WDate = (DateTime) reader["WDate"];
                            WorkOut.PostedBy =  reader["PostedBy"].ToString();
                        
                            WorkOutList.Add(WorkOut);
                        }
                    }
                }

            }
            return WorkOutList;
        }


        public virtual void Save(WorkOutModel WorkOut)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("WorkOut_InsertUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", WorkOut.ID);
                    command.Parameters.AddWithValue("@WName", WorkOut.WName);
                    command.Parameters.AddWithValue("@WDescription", WorkOut.WDescription);
                    command.Parameters.AddWithValue("@WRating", WorkOut.WRating);
                    command.Parameters.AddWithValue("@WDate", WorkOut.WDate);
                    command.Parameters.AddWithValue("@PostedBy", WorkOut.PostedBy);
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
                using (SqlCommand command = new SqlCommand("WorkOut_Delete", connection))
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