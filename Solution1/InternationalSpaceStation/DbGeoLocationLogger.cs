using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    public class TableRow
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class DbGeoLocationLogger : IGeoLocationLogger
    {
        private const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Zadanie2\InternationalSpaceStation\IssLog.mdf;Integrated Security = True";

        public void CleanUp()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                ClearLogTable(conn);
            }
        }

        public void LogLocation(Coordinates coordinates)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                FillLogTable(conn, coordinates);
                
            }
        }

        public void ClearLogTable(SqlConnection conn)
        {
            var sql = "TRUNCATE TABLE LogTable";
            var cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void FillLogTable(SqlConnection conn, Coordinates coordinates)
        {
            var sql = "INSERT INTO LogTable (Latitude, Longitude) VALUES (@Latitude, @Longitude)";
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@Latitude", coordinates.Latitude));
            cmd.Parameters.Add(new SqlParameter("@Longitude", coordinates.Longitude));
            cmd.ExecuteNonQuery();
        }
    }
}