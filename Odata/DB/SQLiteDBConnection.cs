using System.Data.SQLite;

namespace Odata.DB;
public static class SQLiteDBConnection {

    private static SQLiteConnection sqliteConnection;

    static SQLiteDBConnection() {
        if (sqliteConnection == null) {
            sqliteConnection = connect();
            sqliteConnection.Open();
        }
    }

    private static SQLiteConnection connect() {
        return new SQLiteConnection("Data Source=../Odata//SQLITE_Pessoas_DB; Version=3;");
    }

    public static SQLiteConnection getConnection() {
        return sqliteConnection;
    }
}

