using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace C969
{
    internal class Search
    {
        public static DataTable SearchAll(string SearchQuery)
        {
            DataTable searchQueryTable = dbConnection.dgvHelper(SearchQuery);
            return searchQueryTable;
        }

    }
}
