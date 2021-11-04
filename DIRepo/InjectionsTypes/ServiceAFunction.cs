using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRepo
{
    public class ServiceAFunction
    {
        public void GetResults(IReposatory reposatory)
        {
            Console.WriteLine( reposatory.GetData() );
        }
    }
}
