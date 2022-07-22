using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace enviarMail
{

    

    public class PersonaMgr
    {
              
        SqlConnection conn = new SqlConnection("Data Source = 148.234.13.218; Initial Catalog = PruebasSoporteDesarrollo; Integrated Security = True ");
        DataTable Dtt;
       
        public DataTable Listar()
        {
            Dtt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("Select * from pruebaJob", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return Dtt;
        }

    }
}

