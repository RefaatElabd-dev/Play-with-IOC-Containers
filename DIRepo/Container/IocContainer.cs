using DIRepo;

namespace DIRepo
{
    public class IocContainer
    {
        public static void ConstructorInjection()
        {
            IReposatory repoOne;
            if (true)
            {
                repoOne = new MongoDB();
            }
            else
            {
                repoOne = new SqlServer();
            }

            ServiceAConstructor serviceA = new ServiceAConstructor(repoOne);
            serviceA.GetData();
        }

        public static void PropertyAInjection()
        {
            IReposatory RepoOne;
            ServiceAProperty serviceAProperty = new();
            if (false)
            {
                RepoOne = new MongoDB();
            }
            else
            {
                RepoOne = new TestRepo();
            }

            serviceAProperty.Reposatory = RepoOne;
            serviceAProperty.GetResults();
        }

        public static void FunctionAInjection()
        {
            IReposatory RepoOne;
            ServiceAFunction serviceAFunction = new();
            if (true)
            {
                RepoOne = new MongoDB();
            }
            else
            {
                RepoOne = new SqlServer();
            }

            serviceAFunction.GetResults(RepoOne);
        }
    }
}
