using SQLite;

public static class Constants
{
    private const string DBFileName = "SQLite.db3";

    //Las flags indican las operaciones que vamos a realizar en la base de datos
    public const SQLiteOpenFlags Flags =
         SQLiteOpenFlags.ReadWrite |
         SQLiteOpenFlags.Create |
         SQLiteOpenFlags.SharedCache;

    public static string DatabasePath
    {
        get
        {
            return Path
                 .Combine(FileSystem.AppDataDirectory, DBFileName);
        }
    }
}