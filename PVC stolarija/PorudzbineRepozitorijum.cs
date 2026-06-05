using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;

namespace PVC_stolarija
{
    public class PorudzbineRepozitorijum
    {
        private readonly string _connectionString;

        public PorudzbineRepozitorijum()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["PVCConnection"]
                .ConnectionString;
        }

        public DataTable GetPorudzbine(
            string kupac = "",
            string status = "",
            DateTime? datumOd = null,
            DateTime? datumDo = null)
        {
            var query = new StringBuilder("SELECT * FROM Porudzbine WHERE 1=1");
            var cmd = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(kupac))
            {
                query.Append(" AND Kupac LIKE @Kupac");
                cmd.Parameters.AddWithValue("@Kupac", $"%{kupac}%");
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                query.Append(" AND Status = @Status");
                cmd.Parameters.AddWithValue("@Status", status);
            }
            if (datumOd.HasValue)
            {
                query.Append(" AND DatumPorudzbine >= @DatumOd");
                cmd.Parameters.AddWithValue("@DatumOd", datumOd.Value);
            }
            if (datumDo.HasValue)
            {
                query.Append(" AND DatumPorudzbine <= @DatumDo");
                cmd.Parameters.AddWithValue("@DatumDo", datumDo.Value);
            }

            cmd.CommandText = query.ToString();

            using (var conn = new SqlConnection(_connectionString))
            {
                cmd.Connection = conn;
                var adapter = new SqlDataAdapter(cmd);
                var tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
        }

        public DataRow GetPorudzbina(int id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Porudzbine WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                var adapter = new SqlDataAdapter(cmd);
                var tabela = new DataTable();
                adapter.Fill(tabela);

                return tabela.Rows.Count > 0 ? tabela.Rows[0] : null;
            }
        }

    }
}
