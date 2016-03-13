using System.Data.SqlClient;

namespace SmartHome
{
    public class SQLProcess
    {
        public SqlConnection conn;

        public SQLProcess() {
            SqlConnection kur = new SqlConnection(@"Data Source=SLCK\OGUZ;initial Catalog=smarthome;user=porsuk;password=qwe123");
            this.conn = kur;
        }

        public SqlConnection connect() {
            SqlConnection conn = new SqlConnection(@"Data Source=SLCK\OGUZ;initial Catalog=smarthome;user=porsuk;password=qwe123");
            try { conn.Open(); }
            catch {}
            return conn;
        }

    }
}
