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

namespace Repositories.InjuryLog
{
    public class InjuryLogDBRepository : IInjuryLogRepository
    {
        private IConfiguration configuration;
        private string conString;
        public InjuryLogDBRepository(IConfiguration config)
        {
            configuration = config;

            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual InjuryLogModel Get(int id)
        {
            
            InjuryLogModel InjuryLog = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("InjuryLog_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            InjuryLog = new InjuryLogModel();
                            InjuryLog.ID = (int) reader["ID"];
                            InjuryLog.Date = (DateTime) reader["Date"];
                            InjuryLog.InjuryID = (int)reader["InjuryID"];
                            InjuryLog.Description =  reader["Description"].ToString();
                            InjuryLog.RehabID = (int) reader["RehabID"];
                            InjuryLog.Rating = (int) reader["Rating"];
                            InjuryLog.PostedBy =  reader["PostedBy"].ToString();
                        }
                    }
                }

            }
            return InjuryLog;
        }


        public virtual async Task<List<InjuryLogModel>> GetList(int InjuryID)
        {
            List<InjuryLogModel> InjuryLogList = new List<InjuryLogModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("InjuryLog_GetList_ID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", InjuryID);
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            InjuryLogModel InjuryLog = new InjuryLogModel();
                            InjuryLog.ID = (int) reader["ID"];
                            InjuryLog.Date = (DateTime) reader["Date"];
                            InjuryLog.InjuryID = (int)reader["InjuryID"];
                            InjuryLog.Description =  reader["Description"].ToString();
                            InjuryLog.RehabID = (int) reader["RehabID"];
                            InjuryLog.Rating = (int) reader["Rating"];
                            InjuryLog.PostedBy =  reader["PostedBy"].ToString();
                            InjuryLogList.Add(InjuryLog);
                        }
                    }
                }

            }
            return InjuryLogList;
        }
        public virtual async Task<List<InjuryLogModel>> GetList()
        {
            List<InjuryLogModel> InjuryLogList = new List<InjuryLogModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("InjuryLog_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            InjuryLogModel InjuryLog = new InjuryLogModel();
                            InjuryLog.ID = (int) reader["ID"];
                            InjuryLog.Date = (DateTime) reader["Date"];
                            InjuryLog.InjuryID = (int)reader["InjuryID"];
                            InjuryLog.Description =  reader["Description"].ToString();
                            InjuryLog.RehabID = (int) reader["RehabID"];
                            InjuryLog.Rating = (int) reader["Rating"];
                            InjuryLog.PostedBy =  reader["PostedBy"].ToString();
                            InjuryLogList.Add(InjuryLog);
                        }
                    }
                }

            }
            return InjuryLogList;
        }


        public virtual void Save(InjuryLogModel InjuryLog)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("InjuryLog_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Date", InjuryLog.Date);
                    command.Parameters.AddWithValue("@InjuryID", InjuryLog.InjuryID);
                    command.Parameters.AddWithValue("@RehabID", InjuryLog.RehabID);
                    command.Parameters.AddWithValue("@Rating", InjuryLog.Rating);
                    command.Parameters.AddWithValue("@Description", InjuryLog.Description);
                    command.Parameters.AddWithValue("@PostedBy", InjuryLog.PostedBy);
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
                using (SqlCommand command = new SqlCommand("InjuryLog_Delete", connection))
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