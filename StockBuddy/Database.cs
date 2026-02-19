using System;
using System.Data.SQLite;
using System.IO;

namespace StockBuddy.Data
{
    public static class Database
    {
        public static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StockBuddy.db");

        public static readonly string ConnString =
            $"Data Source={DbPath};Version=3;";

        public static void Initialize()
        {
            // Create the DB file if it doesn't exist
            if (!File.Exists(DbPath))
                SQLiteConnection.CreateFile(DbPath);

            using (var conn = new SQLiteConnection(ConnString))
            {
                conn.Open();

                // Products table
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Products (
    ProductId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    SKU TEXT,
    Barcode INTEGER NOT NULL UNIQUE,
    Price REAL NOT NULL,
    Cost REAL,
    QuantityOnHand INTEGER NOT NULL DEFAULT 0,
    ReorderLevel INTEGER NOT NULL DEFAULT 0,
    IsActive INTEGER NOT NULL DEFAULT 1
);
";
                    cmd.ExecuteNonQuery();
                }

                // Sales table
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Sales (
    SaleId INTEGER PRIMARY KEY AUTOINCREMENT,
    CreatedAt TEXT NOT NULL,
    Subtotal REAL NOT NULL,
    Tax REAL NOT NULL,
    Total REAL NOT NULL
);
";
                    cmd.ExecuteNonQuery();
                }

                // SaleItems table
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS SaleItems (
    SaleItemId INTEGER PRIMARY KEY AUTOINCREMENT,
    SaleId INTEGER NOT NULL,
    ProductId INTEGER NOT NULL,
    Quantity INTEGER NOT NULL,
    UnitPrice REAL NOT NULL,
    LineTotal REAL NOT NULL,
    FOREIGN KEY (SaleId) REFERENCES Sales(SaleId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);
";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
