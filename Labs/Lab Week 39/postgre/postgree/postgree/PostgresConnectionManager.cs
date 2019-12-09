using Npgsql;
using System;
using System.Data;

namespace postgree.DBManager
{
    class PostgresConnectionManager
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand sqlQuery;
        private NpgsqlDataReader dataReader;

        public string ConnStr { get; set; }

        public PostgresConnectionManager()
        {
            connection = null;
            sqlQuery = null;
            dataReader = null;
        }

        /// <summary>
        /// Opens the connection to Postgres database
        /// 
        /// Throws Exception if error occurs in the connection
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                connection = new NpgsqlConnection(ConnStr);
                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("Error occured" + ex.Message);
                throw;
            }


        }

        /// <summary>
        /// Prepares a SQL query for execution
        /// </summary>
        public void QuerySetup(string query)
        {
            try
            {
                sqlQuery = new NpgsqlCommand(query, connection);
            }
            catch (NpgsqlException ex)
            {

                Console.WriteLine("Error occured" + ex.Message);
                throw;
            }


        }
        public void ReadData()
        {
            try
            {
                dataReader = sqlQuery.ExecuteReader();
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("Error occured" + ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Updates the coloumns based on a specific row ID
        /// </summary>
        public void UpdateData(int row)
        {
            // Implement update method that updates the coloumns in the database
            throw new NotImplementedException();
        }

        public void InsertData(int row)
        {
            // Insert data based on which row and coloumn that the data needs to be insert onto.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Print data
        /// </summary>
        public void PrintData()
        {
            while (dataReader.Read())
            {
                Console.Write("{0}\t{1} \n", dataReader[0], dataReader[1]);
            }
        }
        /// <summary>
        /// Close the connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
