using Dapper;
using publishers_models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace publishers_dal
{
    public class TitlesRepository : BaseRepository, ITitlesRepository
    {
        public IEnumerable<Title> OphalenTitlesPublisher(string publisher = "", string title = "")
        {
            var sql = @"SELECT T.*, '' AS SplitCol, P.*
                        FROM Titles T
                        JOIN Publishers P ON T.pub_id = P.pub_id
                        WHERE P.pub_name LIKE '%' + @publisher + '%'
                            AND T.title_name LIKE '%' + @title + '%'
                        ORDER BY T.pubdate";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Title, Publisher, Title>(
                    sql,
                    (title, publisher) =>
                    {
                        title.Publisher = publisher;
                        return title;
                    },
                    new { publisher = publisher, title = title },
                    splitOn: "SplitCol"
                );
            }
        }
    }
}