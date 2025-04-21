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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomerModel customerModel)
        {
            throw new NotImplementedException();
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
