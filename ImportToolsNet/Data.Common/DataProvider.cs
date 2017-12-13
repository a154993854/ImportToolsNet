using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TransToolsNet.Data.Common;

namespace ImportToolsNet.Data.Common
{
    public class DataProvider
    {
        public DataSet SelectDataColunm(string tableName)
        {
            string sql = @"select name from syscolumns where id=object_id('"+ tableName + "')";
            return SqlHelper.ExecuteDataset(CommandType.Text, sql, null);
        }
    }
}
