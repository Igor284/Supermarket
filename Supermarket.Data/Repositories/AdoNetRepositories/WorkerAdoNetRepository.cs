using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Models;
using Supermarket.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Data.Repositories.AdoNetRepositories
{
    public class WorkerAdoNetRepository : IWorkerRepository
    {
        private const string CONNECTION_STRING = "Data Source=DESKTOP-3VNPT3A;Initial Catalog=Supermarket;Integrated Security=True";

        public Worker Create(Worker model)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = "INSERT INTO Worker(Name,BreedId) OUTPUT INSERTED.id VALUES(@Name)";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Name", model.Name);


                connection.Open();

                var workerId = command.ExecuteScalar();

                var workerIdInt = Convert.ToInt32(workerId);
                model.Id = workerIdInt;

                return model;
            }
        }
        public IEnumerable<Worker> GetAll()
        {
            var result = new List<Worker>();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = "SELECT * FROM Worker";
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Worker
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                reader.Close();

                return result;
            }
        }
        public WorkerEntity AddWorker(Worker domain)
        {
            if (domain == null) throw new ArgumentNullException(nameof(domain));

            //to DB

            return null;
        }
    }
}
