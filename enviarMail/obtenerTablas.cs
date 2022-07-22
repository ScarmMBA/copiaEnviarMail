using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace enviarMail
{
    public class obtenerTablas
    {
        public DataTable Bases()
        {
            string[] BD = new string[] { "PruebasSoporteDesarrollo", "CapacitacionVer2", "CapacitacionVer3" };

            DataTable bases;
            bases = new DataTable();

            foreach (var item in BD)
            {

                SqlConnection conn = new SqlConnection($"Data Source = 148.234.13.218; Initial Catalog = {item}; Integrated Security = True ");

                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES ", conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(bases);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }


            }

            return Dtt;
        }


    }
}
