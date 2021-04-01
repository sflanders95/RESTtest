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

    }
}
