using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Matrimony.Droid.Dependency;
using Matrimony.Services;
using SQLite;

[assembly:Xamarin.Forms.Dependency(typeof(Matrimony.Droid.Dependency.DatabaseService))]
namespace Matrimony.Droid.Dependency
{
    public class DatabaseService : IDatabaseService
    {
        string databasename = "Matrimony.db3";
        public SQLiteConnectionWithLock GetQLiteConnectionWithLock()
        {
            var databasepath = System.Environment.GetFolderPath( System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(databasepath, databasename);
            return new SQLiteConnectionWithLock(new SQLiteConnectionString(path));
        }

        public SQLiteAsyncConnection GetSQLiteAsyncConnection()
        {
            var databasepath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(databasepath, databasename);
            return new SQLiteAsyncConnection(path);
        }

        public SQLiteConnection GetSQLiteConnection()
        {
            var databasepath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(databasepath, databasename);
            return new SQLiteConnection(path);
        }
    }
}