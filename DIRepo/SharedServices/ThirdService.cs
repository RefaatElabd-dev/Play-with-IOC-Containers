using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace SharedServices
{
    public class ThirdService : ISecondService
    {
        [Inject]
        public IFirstService firstService { get; set; }

        public int GetCount()
        {
            return firstService.Count + 1;
        }
    }
}
