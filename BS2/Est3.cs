using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BS2
{
    public class Est3
    {
        public static int agregar(Est1 Est1)
        {
            int retorna = 0;

            using (SqlConnection conn = Conxion.obtenerc())
            {
                string query = "insert into Dato (CAR,NOM,APD,ACU,EXA,FIN) values ('" + Est1.carnet + "' , '" + Est1.nombre + "' , '" + Est1.apelli + "' , '" + Est1.acum + "' , '" + Est1.exam + "' , '" + Est1.final + "')";
                SqlCommand cmd = new SqlCommand(query, conn);

                retorna = cmd.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Est1> presentar() 
        {
          List<Est1> lista = new List<Est1>();

            using (SqlConnection conn = Conxion.obtenerc()) 
            {
                string query = "select *from Dato";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    Est1 est1 = new Est1();
                    est1.carnet = reader.GetInt32(1);
                    est1.nombre = reader.GetString(2);
                    est1.apelli = reader.GetString(3);
                    est1.acum = reader.GetInt32(4);
                    est1.exam = reader.GetInt32(5);
                    est1.final = reader.GetInt32(6);
                    est1.id = reader.GetInt32(0);
                    lista.Add(est1);
                }

                conn.Close();
                return lista;
            }
        }

        
    }
}
