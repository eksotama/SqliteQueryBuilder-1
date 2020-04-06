using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteQueryBuilder.QuerySelect
{
    public class Query
    {
        private string queryMode = "SELECT";

        public Query()
        {
            
        }

        public Query(string mode)
        {
            if (new string[] {"SELECT", "INSERT", "UPDATE", "DELETE"}.Contains(mode.ToUpper()))
                queryMode = mode.ToUpper();
        }
    }
}
