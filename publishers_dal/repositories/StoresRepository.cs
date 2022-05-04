using Dapper;
using publishers_models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace publishers_dal
{
    public class StoresRepository : BaseRepository, IStoresRepository
    {
        public List<Store> OphalenStoresViaState(string state)
        {
            string sql = "SELECT * FROM Stores WHERE state=@state ORDER BY stor_name";

            var parameters = new { @state = state };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }

        public List<Store> OphalenStoresViaStorName(string naam)
        {
            string sql = "SELECT * FROM Stores";
            sql += " WHERE stor_name like '%'+ @naam +'%'";
            sql += " ORDER BY stor_name";

            var parameters = new { @naam = naam };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }

        public List<Store> OphalenStoresViaStorNameEnState(string naam, string state)
        {
            string sql = "SELECT * FROM Stores";
            sql += " WHERE stor_name like '%'+ @naam +'%'";
            sql += " AND state=@state";
            sql += " ORDER BY stor_name";

            var parameters = new { @naam = naam, @state = state };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }

        public Store OphalenStoreViaPK(string stor_id)
        {
            string sql = "SELECT * FROM Stores WHERE stor_id=@stor_id";

            var parameters = new { stor_id = stor_id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).SingleOrDefault();
            }
        }

        public List<Store> OphalenStoresVerkoopTitle(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}