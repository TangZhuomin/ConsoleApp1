using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class TestService
    {
        private DataServive dataServive;
        public TestService(DataServive dataServive)
        {
            this.dataServive = dataServive;
        }
        public string Hello()
        {
            return "hello"+this.dataServive.GetCount();
        }
    }
}
