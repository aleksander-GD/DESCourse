using System;
using Npgsql;

class PostGresHandler
{
    public class PostGres
    {
        NpgsqlConnection where = null;
        NpgsqlCommand probeinfo = null;
        NpgsqlDataReader info = null;

        public string ConnStr { get; set; }

        // Connect to a PostgreSQL database
        public void HandleDB(string query)
        {
            where = new NpgsqlConnection(ConnStr);
            where.Open();
            probeinfo = new NpgsqlCommand(query, where);
            info = probeinfo.ExecuteReader();
            where.Close();
        }

    }


    static void Main(string[] args)
    {
        string q = "SELECT id, name FROM public.employee;";

        PostGres postGresCon = new PostGres
        {
                //ConnStr = "Server=tek-mmmi-db0a.tek.c.sdu.dk;User Id=si3_2018_group_7; " + "Password=hens234:ISBN;Database=db_name;"
                ConnStr = "Server=127.0.0.1;User Id=ja;" + "Password=postgres;Database=public.employee;"
        };

        postGresCon.HandleDB(q);
    }

}


