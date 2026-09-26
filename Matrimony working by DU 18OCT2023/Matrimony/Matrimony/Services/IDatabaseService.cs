using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Matrimony.Services
{
    public interface IDatabaseService
    {
        SQLiteConnection GetSQLiteConnection();
        SQLiteConnectionWithLock GetQLiteConnectionWithLock();
        SQLiteAsyncConnection GetSQLiteAsyncConnection();
    }
}
