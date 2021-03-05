using Supermarket.Data.Repositories.Interfases;
using Supermarket.Entites;
using SupermarketDomainDtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Supermarket.Data.Repositories.AdoNetRepositories
{
    public class DepartmentAdoNetRepository : IDepartmentRepository
    {
        private const string CONNECTION_STRING = "Data Source=DESKTOP-3VNPT3A;Initial Catalog=Supermarket;Integrated Security=True";

       
        public Department Create(Department model)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = "INSERT INTO Department(Name) OUTPUT INSERTED.id VALUES(@Name)";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Name", model.Name);


                connection.Open();

                var departmentId = command.ExecuteScalar();

                var departmentIdInt = Convert.ToInt32(departmentId);
                model.Id = departmentIdInt;

                return model;
            }
        }
        public IEnumerable<Department> GetAll()
        {
            var result = new List<Department>();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = "SELECT * FROM Department";
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Department
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                reader.Close();

                return result;
            }
        }
        public DepartmentEntity AddDepartment(Department domain)
        {
            if (domain == null) throw new ArgumentNullException(nameof(domain));


            return null;
        }

    }
}
