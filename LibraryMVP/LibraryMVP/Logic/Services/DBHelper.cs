﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryMVP.Logic.Services
{
    static public  class DBHelper
    {
     public static SqlCommand command;
        // this methoud to get connection string from sql server
        private static SqlConnection getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity=true;
            return new SqlConnection(builder.ConnectionString);
        }
        //this methoud to make update insert delete and delete all in database in all program
        public static bool excuteData(string spName ,Action methoud)
        {
            using (SqlConnection connection = getConnectionString())
            {
                try
                {
                    command = new SqlCommand(spName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //to execute methoud that contain paramaters
                    methoud.Invoke();

                    //command.Parameters.Add("@id", SqlDbType.Int).Value = 2;
                    //command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "ali";

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;

                }catch(Exception ex )
                {
                    connection.Close();

                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                   
                }
            }

            return false;
        }
    }
}
