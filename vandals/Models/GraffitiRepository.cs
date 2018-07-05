using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace vandals.Models
{
    public class GraffitiRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<Graffiti> GetGraffitis()
        {
            List<Graffiti> graffitis = new List<Graffiti>();
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                graffitis = dbConnection.Query<Graffiti>("SELECT * FROM graffiti").ToList();
            }

            return graffitis;
        }
    }
}