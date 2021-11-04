using System;

namespace SharedServices
{
    public class FirstService : IFirstService
    {
        public FirstService()
        {
            Count = 0;
        }
        public int Count { get; set; }

        public int increamentAndReturnCount()
        {
            return ++Count;
        }
    }
}
