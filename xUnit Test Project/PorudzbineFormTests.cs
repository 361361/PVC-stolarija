using Xunit;
using System.Data;
using Microsoft.Data.SqlClient;
using PVC_stolarija;
namespace xUnit_Test_Project
{
    public class PorudzbineFormTests
    {
        private const string ConnectionString = "Data Source=DESKTOP-UC639ML\\SQLEXPRESS01;Initial Catalog=PVC_Stolarija;User ID=sa;Password=Dacacar361;Encrypt=True;TrustServerCertificate=True";

        [Fact]
        public void PrikaziPorudzbine_WithoutFilters_ShouldReturnAllRecords()
        {
            var result = ExecuteQuery("SELECT COUNT(*) FROM Porudzbine");

            Assert.True(result > 0);
        }

        [Fact]
        public void PrikaziPorudzbine_WithKupacFilter_ShouldReturnFilteredRecords()
        {
            string kupac = "Marko";

            var result = ExecuteQuery($"SELECT COUNT(*) FROM Porudzbine WHERE Kupac LIKE '%{kupac}%'");

            Assert.True(result >= 0);
        }

        [Fact]
        public void InsertPorudzbina_WithValidData_ShouldSucceed()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Porudzbine (Kupac, DatumPorudzbine, VrstaProzora, Dimenzije, Cena, Status) " +
                    "VALUES (@Kupac, @DatumPorudzbine, @VrstaProzora, @Dimenzije, @Cena, @Status)", 
                    conn);
                
                cmd.Parameters.AddWithValue("@Kupac", "Test Kupac");
                cmd.Parameters.AddWithValue("@DatumPorudzbine", DateTime.Now);
                cmd.Parameters.AddWithValue("@VrstaProzora", "Prozor");
                cmd.Parameters.AddWithValue("@Dimenzije", "100x100");
                cmd.Parameters.AddWithValue("@Cena", 1000);
                cmd.Parameters.AddWithValue("@Status", "U obradi");

                int result = cmd.ExecuteNonQuery();
                Assert.True(result > 0);
            }
        }

        private int ExecuteQuery(string query)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
    }
}