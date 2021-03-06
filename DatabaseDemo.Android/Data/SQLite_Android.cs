﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DatabaseDemo.Data;
using DatabaseDemo.Droid.Data;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]

namespace DatabaseDemo.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
            public SQLite_Android() { }
            public SQLite.SQLiteConnection GetConnection() 
            {
            var sqliteFileName = "TestDB.db";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
             }
    }
}