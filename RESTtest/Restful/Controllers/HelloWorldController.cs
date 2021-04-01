using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{

    /// <summary>
    /// This is where we go to the DB and get the data to return.
    /// </summary>
    public class HelloWorldController : ApiController
    {
        // GET: api/Default
        /// <summary>Test Get Method.</summary>
        /// <example>/api/HelloWorld</example>
        /// <returns></returns>
        public IEnumerable<Models.HelloWorldInfo> Get()
        {
            return Get(10);
        }
        
        // GET: http://localhost:59141/api/HelloWorld/5
        public IEnumerable<Models.HelloWorldInfo> Get(int id)
        {
            List<Models.HelloWorldInfo> list = new List<Models.HelloWorldInfo>();

            for (int i = 0; i < id; i++)
            {
                list.Add(new Models.HelloWorldInfo() {
                    Ordinal = i, Name = "Steve", time = DateTime.Now.AddMonths(i),
                    RandomStr = $"{Guid.NewGuid()}", dataTable = Models.HelloWorldInfo.createDummyDataTable() });
            }
            return list;
        }

        // POST: api/Default
        public IEnumerable<Models.HelloWorldInfo> Post([FromBody]string value)
        {
            return Post(10, value);
        }

        // PUT: api/Default/5
        public IEnumerable<Models.HelloWorldInfo> Post(int id, [FromBody]string value)
        {
            List<Models.HelloWorldInfo> list = new List<Models.HelloWorldInfo>();

            for (int i = 0; i < id; i++)
            {
                list.Add(new Models.HelloWorldInfo() { Ordinal = i, Name = $"{value}",
                    time = DateTime.Now.AddMonths(i), RandomStr = $"{Guid.NewGuid()}",
                    dataTable = Models.HelloWorldInfo.createDummyDataTable()
                });
            }
            return list;
        }

    }
}
