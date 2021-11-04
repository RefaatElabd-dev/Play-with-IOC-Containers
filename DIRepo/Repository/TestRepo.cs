using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRepo
{
    public class TestRepo : IReposatory
    {
        public string GetData()
        {
            return "Data Tested";
        }
    }
}
