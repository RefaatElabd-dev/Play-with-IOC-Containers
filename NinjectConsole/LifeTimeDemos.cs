using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SharedServices;

namespace NinjectConsole
{
    public static class LifeTimeDemos
    {
        public static void NewInstance()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>();
                var firstServicesNewInstance = kernel.Get<IFirstService>();
                firstServicesNewInstance.increamentAndReturnCount();

                // Resolve Again
                firstServicesNewInstance = kernel.Get<IFirstService>();
                firstServicesNewInstance.increamentAndReturnCount();

                Console.WriteLine(firstServicesNewInstance.Count);
            }
        }

        public static void SingleTonInstance()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>()
                    .InSingletonScope();
                var firstServicesNewInstance = kernel.Get<IFirstService>();
                firstServicesNewInstance.increamentAndReturnCount();

                // Resolve Again
                firstServicesNewInstance = kernel.Get<IFirstService>();
                firstServicesNewInstance.increamentAndReturnCount();

                Console.WriteLine(firstServicesNewInstance.Count);
            }
        }

        public static void SecondServices()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>()
                    .InSingletonScope();
                kernel.Bind<ISecondService>().To<SecondService>();

                IFirstService firstServiceNewInstance = kernel.Get<IFirstService>();
                Console.WriteLine(firstServiceNewInstance.increamentAndReturnCount());

                firstServiceNewInstance = kernel.Get<IFirstService>();
                Console.WriteLine(firstServiceNewInstance.increamentAndReturnCount());

                firstServiceNewInstance.increamentAndReturnCount();

                var SecondServiceNewInstance = kernel.Get<ISecondService>();
                Console.WriteLine(SecondServiceNewInstance.GetCount());
            }
        }
        public static void ThirdServices()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>()
                    .InSingletonScope();
                kernel.Bind<ISecondService>().To<ThirdService>();

                IFirstService firstServiceNewInstance = kernel.Get<IFirstService>();
                Console.WriteLine(firstServiceNewInstance.increamentAndReturnCount());

                firstServiceNewInstance = kernel.Get<IFirstService>();
                Console.WriteLine(firstServiceNewInstance.increamentAndReturnCount());

                firstServiceNewInstance.increamentAndReturnCount();

                var SecondServiceNewInstance = kernel.Get<ISecondService>();
                Console.WriteLine(SecondServiceNewInstance.GetCount());
            }
        }
    }
}
