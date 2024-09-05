using System;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class DataAcces
    {
        private readonly string _connString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=StoreManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void FetchProducts()
        {
            Console.WriteLine("Fetch Methods works");
           SqlConnection conn = new SqlConnection(_connString);
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM products";
                SqlCommand cmd = new SqlCommand(query, conn);


                         SqlDataReader reader = cmd.ExecuteReader();
                       
                            while (reader.Read())
                            {
                                
                                Console.WriteLine($"Product ID: {reader["Id"]}, Product Name: {reader["Name"]}, Product Price: {reader["Price"]}, ProductType: {reader["ProductType"]}");
                            }
                        
                    
                }
                catch (SqlException ex)
                {
                   
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
}
