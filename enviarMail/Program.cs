using enviarMail;
using EnviarMail;
using System.Data;
using System.Data.SqlClient;

logic objLogic = new logic();
PersonaMgr objPerMgr = new PersonaMgr();
obtenerTablas objNombres = new obtenerTablas();


DataTable Dtt = new DataTable();
DataTable dt = new DataTable();

Dtt = objPerMgr.Listar();
dt = objNombres.Bases();

List<string> BD = new List<string>();
string table;


if (Dtt.Rows.Count > 0)
{
    int i =0;
    foreach(DataRow ren in Dtt.Rows)
    {

        
        string x =  ren["envioEmail"].ToString();
        int nuevx = Int16.Parse(x);
        Console.WriteLine(nuevx);

        if(nuevx == 0)
        {
            string body = @"<style>" +
                            "h1{color:dodgerblue;}" +
                            "h2{color:darkorange;}" +
                            "h3{color: green;}" +
                            "</style>" +
                            "<h1> Hola :D</h1></br>" +
                           "<p> Esto es correo de prueba solamente </p> </br>" +
                            "<h2>Ustedes han sido seleccionados para esta prueba</h2>" +
                            "<p>Debería revisar mas a fondo el como mejorar esto</p>" +
                            "<h3>Favor de ignorar estos mensajes que son prueba para este sistema</h3>" +
                            "<h4>Este mensaje se envia automaticamente, no responder</h4>";
            objLogic.sendMail(ren["email"].ToString(), "Correo de prueba xD", body);


            //   Console.WriteLine("Fila--->"+i);
            //  Console.WriteLine(ren["nombre"].ToString());
            //   Console.WriteLine(ren["apellido"].ToString());
            //   Console.WriteLine(ren["email"].ToString());
            //   Console.WriteLine(ren["fCreacion"].ToString());

            




            i++;
            
        }


        i++;


    }
}


