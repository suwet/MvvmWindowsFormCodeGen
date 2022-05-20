using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Rmx.Dals
{
	public  class CConfigDal : BaseDal
	{
		public List<C_Config> GetAll()    
        {    
            List<C_Config> results = new List<C_Config>();    
            using (var connection = new SqlConnection(ConnectionString))    
            {    
                connection.Open();    
                string query = @"Select  CF_ID,CF_Name,CF_Value,CF_Group,CF_Description  From C_Configuration";
                results = connection.Query<C_Config>(query).ToList();    
                connection.Close();    
            }    
            return results;    
        }    

        public int Insert(C_Config data)    
        {    
            using (var connection = new SqlConnection(ConnectionString))    
            {    
                connection.Open(); 
                string sql = @"Insert into C_Configuration ( CF_ID,CF_Name,CF_Value,CF_Group,CF_Description )
                                                          values( @CF_ID,@CF_Name,@CF_Value,@CF_Group,@CF_Description )
                            ";
                var affectedRows = connection.Execute(sql,new { 
CF_ID = data.CF_ID,CF_Name = data.CF_Name,CF_Value = data.CF_Value,CF_Group = data.CF_Group,CF_Description = data.CF_Description } 
);    
                connection.Close();    
                return affectedRows;    
            }    
        }   
        
        public int Update(C_Config data)    
        {    
            using (var connection = new SqlConnection(ConnectionString))    
            {    
                connection.Open();    
                string sql = @"Update C_Configuration set  CF_ID = @CF_ID,CF_Name = @CF_Name,CF_Value = @CF_Value,CF_Group = @CF_Group,CF_Description = @CF_Description  where Id=@Id";
                var affectedRows = connection.Execute(sql,new { 
CF_ID = data.CF_ID,CF_Name = data.CF_Name,CF_Value = data.CF_Value,CF_Group = data.CF_Group,CF_Description = data.CF_Description } 
);    
                connection.Close();    
                return affectedRows;    
            }    
        }  
        
        public int Delete(long Id)    
        {    
            using (SqlConnection connection = new SqlConnection(ConnectionString))    
            {    
                connection.Open();    
                string sql = @"Delete from C_Configuration Where Id = @Id";
                var affectedRows = connection.Execute(sql, new {Id = Id });    
                connection.Close();    
                return affectedRows;    
            }    
        }    

        public C_Config GetById(long Id)    
        {    
            using (SqlConnection connection = new SqlConnection(ConnectionString))    
            {    
                connection.Open();    
                string sql = @"Select  CF_ID,CF_Name,CF_Value,CF_Group,CF_Description  from C_Configuration Where Id = @Id";
                var result  = connection.QueryFirst<C_Config>(sql, new {Id = Id });    
                connection.Close();    
                return result;    
            }    
        }    
	}
}