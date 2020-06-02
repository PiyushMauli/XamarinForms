using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteApp
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    
    }
}
