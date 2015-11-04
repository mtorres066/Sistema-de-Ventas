using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;


namespace CapaDatos
{
    class Conexion
    {
        //public static string Cn = "Data Source=JCARLOSAD7; Initial Catalog=dbventas; Integrated Security=true";
        public static string Cn = "server=127.0.0.1; Database=dbventas; Uid=root; pwd=Matl066";
        //public static string Cn = "Data Source=desarrollo-lap2\\sqlexpress; Initial Catalog=dbventas; Integrated Security=True";

    }
}
