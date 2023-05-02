using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Static.Models
{
    public static class ConnectionHelpers //All members of static class should be static too
    {
        // static field
        public static string SqlConnection = "database=testDb;uid=sa;pwd=123;server=.;";

        // static readonly field -> this is equivalent of 'private set' in props, so we can get the field but can't set.
        public static readonly string ExcelConnection = "database=testDb;uid=sa;pwd=123;server=.;";

        // static readonly property
        public static string MySqlConnection { get => "mysqlconnection string "; }

        public static string MongoConnection = "database=testDb;uid=sa;pwd=123;server=.;";
        public static string PostqureConnection = "database=testDb;uid=sa;pwd=123;server=.;";
        public static string OracleConnection = "database=testDb;uid=sa;pwd=123;server=.;";

        // const -> kendiliğinden static ve sadece okunabilir olma özelliği vardır. işaretlemenize gerek yoktur :)
        public const string constConnectionString = "const";
    }
}