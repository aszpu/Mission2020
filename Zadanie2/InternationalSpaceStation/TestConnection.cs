using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    public class TestTableRow
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class TestConnection
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Zadanie2\InternationalSpaceStation\IssLog.mdf;Integrated Security=True";

        public void PerformTest()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                ClearTestTable(conn);
                FillTestTable(conn);

                var sql = "SELECT TOP 1 Id FROM TestTable2 WHERE Id > @Id";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", 10));
                var id = (int)cmd.ExecuteScalar();

                var rows = new List<TestTableRow>();
                var sql2 = "SELECT Id, Text FROM TestTable2 WHERE Id > @Id";
                var cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.Add(new SqlParameter("@Id", 10));
                using (var reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new TestTableRow();
                        row.Id = (int)reader["Id"];
                        row.Text = (string)reader["Text"];
                        rows.Add(row);
                    }
                }

            }
        }

        public static void ClearTestTable(SqlConnection conn)
        {
            var sql = "TRUNCATE TABLE TestTable2";
            var cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void FillTestTable(SqlConnection conn)
        {
            for (var i = 0; i < 30; ++i)
            {
                var sql = "INSERT INTO TestTable2 (Text) VALUES (@Text)";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Text", "txt" + i));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
