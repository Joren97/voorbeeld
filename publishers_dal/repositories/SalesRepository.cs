using Dapper;
using publishers_models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace publishers_dal
{
    public class SalesRepository : BaseRepository, ISalesRepository
    {
        public IEnumerable<Sale> OphalenSalesVoorPublisher(string publisherId)
        {
            var sql = @"SELECT Sa.*, '' AS SplitCol, St.*, '' AS SplitCol, T.*
                        FROM Sales Sa
                        JOIN Stores St ON Sa.stor_id = St.stor_id
                        JOIN Titles T ON Sa.title_id = T.title_id
                        WHERE T.pub_id = @publisherId
                        ORDER BY Sa.ord_date";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Sale, Store, Title, Sale>(
                    sql,
                    (sale, store, title) =>
                    {
                        sale.Store = store;
                        sale.Title = title;
                        return sale;
                    },
                    new { publisherId = publisherId },
                    splitOn: "SplitCol"
                );
            }
        }

        public IEnumerable<Sale> OphalenSalesVoorTitle(string titleId)
        {
            var sql = @"SELECT Sa.*, '' AS SplitCol, St.*, '' AS SplitCol, T.*
                        FROM Sales Sa
                        JOIN Stores St ON Sa.stor_id = St.stor_id
                        JOIN Titles T ON Sa.title_id = T.title_id
                        WHERE T.title_id = @titleId
                        ORDER BY Sa.ord_date";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Sale, Store, Title, Sale>(
                    sql,
                    (sale, store, title) =>
                    {
                        sale.Store = store;
                        sale.Title = title;
                        return sale;
                    },
                    new { titleId = titleId },
                    splitOn: "SplitCol"
                );
            }
        }
    }
}