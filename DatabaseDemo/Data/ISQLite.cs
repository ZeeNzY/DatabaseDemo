using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DatabaseDemo.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
