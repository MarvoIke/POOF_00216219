using System;
using System.Data;

namespace POOF
{
    public class LogDao
    {
        public static DataTable GetUserLogs(User us)
        {
            string sql = string.Format(
                "SELECT * FROM registro WHERE idusuario = {0};",
                us.idUser);
            
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            return dt;
        }
        
        public static DataTable GetLogs()
        {
            string sql = "SELECT * FROM registro";
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            return dt;
        }
        
        public static void CreateLog(int pIdUser , bool pIsWorking , double pTemp)
        {
            //Crear y ejecutar NonQuery
            string sql = string.Format(
                "INSERT INTO registro (idusuario , entrada , temperatura)" + 
                "VALUES ({0} , {1} , {2});",
                pIdUser , pIsWorking , pTemp);
               
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static DataTable Working()
        {
            string sql = "SELECT * FROM registro WHERE entrada = true;";
            
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            return dt;
        }
    }
}