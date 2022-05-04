using Dapper;
using publishers_models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace publishers_dal
{
    public class PublishersRepository : BaseRepository, IPublishersRepository
    {
        public IEnumerable<Publisher> OphalenPublishers(string publisher = "")
        {
            var sql = @"SELECT *
                        FROM Publishers P
                        WHERE P.pub_name LIKE '%' + @publisher + '%'
                        ORDER BY P.pub_name";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Publisher>(sql, new { publisher = publisher });
            }
        }
    }
}