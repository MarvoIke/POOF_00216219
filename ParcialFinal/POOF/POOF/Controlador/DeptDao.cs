using System.Data;

namespace POOF
{
    public static class DeptDao
    {
        public static DataTable MostPopDept()
        {
            string sql = "SELECT d.nombre, count(u.iddepartamento) as frecuencia " +
            "FROM registro r, departamento d, usuario u " +
            "WHERE r.idusuario = u.idusuario AND d.iddepartamento = u.iddepartamento " +
            "GROUP BY d.iddepartamento ORDER BY frecuencia DESC LIMIT 1";
            
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            return dt;
        }
    }
}