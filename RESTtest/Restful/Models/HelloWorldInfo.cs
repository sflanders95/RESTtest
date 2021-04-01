using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Restful.Models
{
    [DataContract]
    public class HelloWorldInfo
    {

        [DataMember(Name = "ordinal")]
        public int Ordinal { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "CurrentTime")]
        public DateTime time { get; set; }

        [DataMember(Name = "randomString")]
        public string RandomStr { get; set; }
        
        [DataMember(Name = "data")]
        public System.Data.DataTable { get; set; }

        
        public static System.Data.DataTable createDummyDataTable(string tableName = "theTable", int numRows = 5)
        {
            System.Data.DataTable dt = new System.Data.DataTable(tableName);

            dt.Columns.AddRange(new System.Data.DataColumn[] {
                new System.Data.DataColumn("Column1") { DefaultValue = "Col1 Data" },
                new System.Data.DataColumn("Column2") { DefaultValue = "Col2 Data" },
                new System.Data.DataColumn("Column3") { DefaultValue = "Col3 Data" },
                new System.Data.DataColumn("Column4") { DefaultValue = "Col4 Data" },
                });
            for (int i=1; i<=numRows; i++)
                dt.Rows.Add(dt.NewRow());

            return dt;
        }
    }
}
