namespace DIRepo
{
    /// <summary>
    ///  Implement IReposatory To Use SQlServer DB
    ///  Author: Refaat Elabd
    /// </summary>
    public class SqlServer : IReposatory
    {
        public string GetData()
        {
            return "SQLServerDB";
        }
    }
}
