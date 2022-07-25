using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}