using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PVC_stolarija
{
    public class Porudzbina
    {
        public int?     Id              { get; set; }   
        public string   Kupac           { get; set; } = "";
        public DateTime DatumPorudzbine { get; set; } = DateTime.Now;
        public string   VrstaProzora    { get; set; } = "";
        public string   Dimenzije       { get; set; } = "";
        public decimal  Cena            { get; set; }
        public string   Status          { get; set; } = "";

        private static string ConStr =>
            ConfigurationManager.ConnectionStrings["PVCConnection"].ConnectionString;

        public void Sacuvaj()
        {
            if (Id == null)
                Insert();
            else
                Update();
        }

        private void Insert()
        {
            const string sql = @"
                INSERT INTO Porudzbine
                    (Kupac, DatumPorudzbine, VrstaProzora, Dimenzije, Cena, Status)
                OUTPUT INSERTED.ID
                VALUES
                    (@Kupac, @DatumPorudzbine, @VrstaProzora, @Dimenzije, @Cena, @Status)";

            using (var conn = new SqlConnection(ConStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    PopuniParametre(cmd);
                    Id = (int)cmd.ExecuteScalar();
                }
            }
        }

        private void Update()
        {
            const string sql = @"
                UPDATE Porudzbine SET
                    Kupac           = @Kupac,
                    DatumPorudzbine = @DatumPorudzbine,
                    VrstaProzora    = @VrstaProzora,
                    Dimenzije       = @Dimenzije,
                    Cena            = @Cena,
                    Status          = @Status
                WHERE ID = @ID";

            using (var conn = new SqlConnection(ConStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", Id!.Value);
                    PopuniParametre(cmd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Obrisi()
        {
            if (Id == null) return;

            using (var conn = new SqlConnection(ConStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "DELETE FROM Porudzbine WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", Id.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Porudzbina Ucitaj(int id)
        {
            using (var conn = new SqlConnection(ConStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT * FROM Porudzbine WHERE ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception($"Porudžbina sa ID={id} nije pronađena.");

                        return new Porudzbina
                        {
                            Id              = reader.GetInt32(reader.GetOrdinal("ID")),
                            Kupac           = reader["Kupac"]?.ToString()        ?? "",
                            DatumPorudzbine = reader["DatumPorudzbine"] != DBNull.Value
                                                 ? Convert.ToDateTime(reader["DatumPorudzbine"])
                                                 : DateTime.Now,
                            VrstaProzora    = reader["VrstaProzora"]?.ToString() ?? "",
                            Dimenzije       = reader["Dimenzije"]?.ToString()    ?? "",
                            Cena            = reader["Cena"] != DBNull.Value
                                                 ? Convert.ToDecimal(reader["Cena"]) : 0,
                            Status          = reader["Status"]?.ToString()       ?? "",
                        };
                    }
                }
            }
        }

        private void PopuniParametre(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Kupac",           Kupac);
            cmd.Parameters.AddWithValue("@DatumPorudzbine", DatumPorudzbine);
            cmd.Parameters.AddWithValue("@VrstaProzora",    VrstaProzora);
            cmd.Parameters.AddWithValue("@Dimenzije",       Dimenzije);
            cmd.Parameters.AddWithValue("@Cena",            Cena);
            cmd.Parameters.AddWithValue("@Status",          Status);
        }
    }
}
