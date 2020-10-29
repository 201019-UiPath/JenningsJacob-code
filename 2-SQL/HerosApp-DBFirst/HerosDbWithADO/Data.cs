using System;
using Npgsql;
using System.Data;

namespace HerosDbWithADO
{
    public class Data
    {
        string conStr = "Host=lallah.db.elephantsql.com;Port=5432;Database=mcrgbvzm;Username=mcrgbvzm;Password=pcdbvW2gjad0lDKxvgOV16An-xsUDZuy;";
        // Create a connection
        NpgsqlConnection connection;
        // Fire the query
        NpgsqlCommand command;
        NpgsqlDataAdapter dataAdapter;
        // Get the results
        NpgsqlDataReader reader; // reads in connected fasion in forward only direction
        DataSet dataSet; // local storage to store output of dataAdapter class in disconnected fashion

        string query = "select * from Superpeople";

        public void GetSuperPersonConnected(){
            try {
                // var configuration = new ConfigurationBuilder()
                // .SetBasePath(Directory.GetCurrentDirectory())
                // .AddJsonFile("appsettings.json")
                // .Build();

                // var connectionString = configuration.GetConnectionString("HerosDB");

                // connection = new NpgsqlConnection(connectionString);
                connection = new NpgsqlConnection(conStr);
                connection.Open();
                command = new NpgsqlCommand(connection:connection, cmdText:query);
                // ExecuteReader reads value, used with select queries
                // ExecuteNonQuery used with Insert, delete, and update
                reader = command.ExecuteReader();

                while (reader.Read()){
                    Console.WriteLine($"{reader[0]} {reader[1]}");
                }

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                // Log the exception {Serilog, nLog}
            } finally {
                connection.Close();
            }
        }
        public void GetSuperPersonDisconnected(){
            connection = new NpgsqlConnection(conStr);
            // dataAdapter fires query, gets results when connection is available
            dataAdapter = new NpgsqlDataAdapter(query, connection);
            dataSet = new DataSet(); // creating an in-memory database

            int tables = dataAdapter.Fill(dataSet);
            if(tables != 0) {
                foreach(DataRow rows in dataSet.Tables[0].Rows){
                    Console.WriteLine($"{rows["id"]} {rows["workname"]} {rows["hideout"]}");
                }
            }
        }
    }
}
