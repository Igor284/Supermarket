using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Data.Repositories.DapperRepositories
{
    public class WorkerDapperRepository 
    {
       /* private const string CONNECTION_STRING = "Data Source=.;Initial Catalog=Zoo;Integrated Security=True";

        public Worker Create(Worker model)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = $"INSERT INTO Animals(Name,BreedId) OUTPUT INSERTED.id VALUES(\'{model.Name})";

                var insertedId = connection.ExecuteScalar(queryString);
                var insertedIdInt = Convert.ToInt32(insertedId);
                model.Id = insertedIdInt;

                return model;
            }
        }

        public IEnumerable<Worker> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.Query<Worker>("SELECT * FROM Animals");
            }
        }*/
    }
}
