using System;
using SQLite;

namespace SQLiteTableCar;

public static class Constants
{
    private const string DBFileName = "SQLiteTable.db3";

    public const SQLiteOpenFlags Flags = 
                        SQLiteOpenFlags.ReadWrite |
                        SQLiteOpenFlags.Create | 
                        SQLiteOpenFlags.SharedCache;

    public static string DatabasePath {
        get{
            return Path.Combine(FileSystem.AppDataDirectory , DBFileName);
        }
    }
}
