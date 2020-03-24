using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMohan.BD
{
    public interface ISQLite
    {
        SqliteConnection GetConnection();
    }
}
