using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServices
{
    public class SecondService : ISecondService
    {
        private readonly IFirstService _firstService;

        public SecondService(IFirstService firstService)
        {
            _firstService = firstService;
        }

        public int GetCount()
        {
            return _firstService.Count;
        }
    }
}
