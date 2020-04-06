using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SQLiteQueryBuilder.QuerySelect
{
    public class Query
    {
        private string queryMode = "SELECT";
        private JObject queryContainer;

        public Query()
        {
            
        }

        public Query(string mode)
        {
            if (new string[] {"SELECT", "INSERT", "UPDATE", "DELETE"}.Contains(mode.ToUpper()))
                queryMode = mode.ToUpper();
        }


        private JObject InitialiseQueryContainer(string mode)
        {
            var container = new JObject();

            switch (mode.ToUpper())
            {
                case "SELECT":

                    break;
                case "INSERT":
                    break;
                case "UPDATE":
                    break;
                case "DELETE":
                    break;
                default:
                    throw new NotImplementedException();
            }

            return container;
        }
    }
}
