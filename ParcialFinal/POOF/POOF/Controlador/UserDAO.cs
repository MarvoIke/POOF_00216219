using System;
using System.Data;

namespace POOF
{
    public class UserDAO
    {
        public static User GetUser(string name)
        {
            //Crear y ejecutar consulta
            string sql = string.Format(
                "SELECT * FROM usuario WHERE nombre = '{0}';",
                name);
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            //Guardar datos de consulta
            User u = new User();
            foreach (DataRow row in dt.Rows)
            {
                u.idUser = Convert.ToInt32(row[0]);
                u.password = row[1].ToString();
                u.name = row[2].ToString();
                u.lastName = row[3].ToString();
                u.dui = row[4].ToString();
                u.birthDate = Convert.ToDateTime(row[5]);
                u.idZone = Convert.ToInt32(row[6]);
            }
            //Regresar datos
            return u;
        }

        public static void CreateUser(string pPass , string pName , string pLastName , string pDui , string pBirth ,
        int pIdZone)
        {
            //Crear y ejecutar NonQuery
            string sql =
                "INSERT INTO usuario (contrasena , nombre , apellido , dui , fechanacimiento , iddepartamento)" +
                $"VALUES ('{pPass}' , '{pName}' , '{pLastName}' , '{pDui}' , {pBirth} , {pIdZone});";
            //pPass , pName , pLastName , pDui , pBirth , pIdZone);
               
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}