using System.Data.SqlClient;

namespace oop_m2
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object Mutex = new object();

        public SqlConnection Connection { get; }

        private DatabaseConnection()
        {
            Connection = new SqlConnection("Server=localhost;User Id=sa;Database=CloverPass");
            Connection.Open();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (Mutex) return _instance ?? (_instance = new DatabaseConnection());
            }
        }
    }
}
