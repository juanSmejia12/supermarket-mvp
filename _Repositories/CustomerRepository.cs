using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;


namespace Supermarket_mvp._Repositories
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers (document_number, first_name, last_name, address, birthday, phone_number, email) VALUES (@document_number, @first_name, @last_name, @address, @birthday, @phone_number, @email)";
                command.Parameters.Add("@document_number", SqlDbType.Char).Value = customerModel.DocumentNumber;
                command.Parameters.Add("@first_name", SqlDbType.Char).Value = customerModel.FirstName;
                command.Parameters.Add("@last_name", SqlDbType.Char).Value = customerModel.LastName;
                command.Parameters.Add("@address", SqlDbType.Char).Value = customerModel.Address ?? (object)DBNull.Value;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customerModel.Birthday ?? (object)DBNull.Value;
                command.Parameters.Add("@phone_number", SqlDbType.Char).Value = customerModel.PhoneNumber ?? (object)DBNull.Value;
                command.Parameters.Add("@email", SqlDbType.Char).Value = customerModel.Email ?? (object)DBNull.Value;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE customer_id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                    SET document_number = @document_number,
                                        first_name = @first_name,
                                        last_name = @last_name,
                                        address = @address,
                                        birthday = @birthday,
                                        phone_number = @phone_number,
                                        email = @email
                                    WHERE customer_id = @id";
                command.Parameters.Add("@document_number", SqlDbType.Char).Value = customerModel.DocumentNumber;
                command.Parameters.Add("@first_name", SqlDbType.Char).Value = customerModel.FirstName;
                command.Parameters.Add("@last_name", SqlDbType.Char).Value = customerModel.LastName;
                command.Parameters.Add("@address", SqlDbType.Char).Value = customerModel.Address ?? (object)DBNull.Value;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customerModel.Birthday ?? (object)DBNull.Value;
                command.Parameters.Add("@phone_number", SqlDbType.Char).Value = customerModel.PhoneNumber ?? (object)DBNull.Value;
                command.Parameters.Add("@email", SqlDbType.Char).Value = customerModel.Email ?? (object)DBNull.Value;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY customer_id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel
                        {
                            Id = (int)reader["customer_id"],
                            DocumentNumber = reader["document_number"].ToString(),
                            FirstName = reader["first_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Address = reader["address"] as string,
                            Birthday = (DateTime)(reader["birthday"] as DateTime?),
                            PhoneNumber = reader["phone_number"] as string,
                            Email = reader["email"] as string
                        };
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                                    WHERE customer_id = @id OR document_number LIKE @value + '%'
                                    OR first_name LIKE @value + '%' OR last_name LIKE @value + '%'
                                    ORDER BY customer_id DESC";
                int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@value", SqlDbType.Char).Value = value;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel
                        {
                            Id = (int)reader["customer_id"],
                            DocumentNumber = reader["document_number"].ToString(),
                            FirstName = reader["first_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Address = reader["address"] as string,
                            Birthday = (DateTime)(reader["birthday"] as DateTime?),
                            PhoneNumber = reader["phone_number"] as string,
                            Email = reader["email"] as string
                        };
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
            ;
        }
    }
}
