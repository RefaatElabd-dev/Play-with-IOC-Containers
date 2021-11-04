using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRepo
{
    public class ServiceAProperty
    {
        public IReposatory Reposatory { get; set; }

        public void GetResults()
        {
            Console.WriteLine(Reposatory.GetData());
        }
    }
}
