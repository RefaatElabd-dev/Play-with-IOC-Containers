using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIOCAutoFac.Repositories
{
    public class DataRepositry: IDataRepository
    {
        public DataRepositry()
        {
            Count = 0;
        }

        public int Count { get; set; }

        public string GetData()
        {
            Count++;
            return "data";
        }
    }
}