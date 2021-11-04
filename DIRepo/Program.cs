using System;

namespace DIRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            IocContainer.ConstructorInjection();
            Console.WriteLine("---------------------------------");
            IocContainer.PropertyAInjection();
            Console.WriteLine("---------------------------------");
            IocContainer.FunctionAInjection();
        }
    }
}
