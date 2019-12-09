using postgree.DBManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace postgree
{
    class TestClass
    {
        static void Main(string[] args)
        {
            string query = "SELECT id, name FROM public.employee;";

            PostgresConnectionManager postgresConnection = new PostgresConnectionManager
            {

                //ConnStr = "Server=tek-mmmi-db0a.tek.c.sdu.dk;User Id=si3_2018_group_7; " + "Password=hens234:ISBN;Database=db_name;"
                ConnStr = "Server=127.0.0.1;User Id=ja;" + "Password=postgres;Database=public.employee;"
            };

            postgresConnection.OpenConnection();
            postgresConnection.QuerySetup(query);
            postgresConnection.ReadData();
            postgresConnection.PrintData();
            string query2 = "INSERT into employee values(9, NEWNAME);";
            postgresConnection.QuerySetup(query2);
            postgresConnection.ReadData();
            postgresConnection.PrintData();
            postgresConnection.CloseConnection();
        }


    }
}


