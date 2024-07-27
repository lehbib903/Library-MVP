using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryMVP.Logic.Services
{
    static class CategoryService
    {
        public static bool categoryInsert(int id,string name)
        {
        return  DBHelper.excuteData("categoryInsert", () => categoryParamterInsert(id, name, DBHelper.command));
            
        }
        //this methoud to add insert paramter into stored procedure
        private static void categoryParamterInsert(int id , string name ,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value =id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value =name;

        }


        public static bool categoryDelete(int id)
        {
          return  DBHelper.excuteData("categoryDelete", () => categoryParamterDelete(id, DBHelper.command));
            
        }
        //this methoud to Delte paramter into stored procedure
        private static void categoryParamterDelete(int id,  SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value =id;
          
        }
        public static bool categoryUpdate(int id, string name)
        {
         return  DBHelper.excuteData("categoryUpdate", () => categoryParamterUpdate(id, name, DBHelper.command));
            
        }
        //this methoud to add Update paramter into stored procedure
        private static void categoryParamterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value =id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value =name;

        }

        public static bool categoryDeleteAll()
        {
          return  DBHelper.excuteData("categoryDeleteAll", () => categoryParamterDeleteAll( ));
           
        }
        //this methoud to Delte paramter into stored procedure
        private static void categoryParamterDeleteAll( )
        {            

        }

    }
}
