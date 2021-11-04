namespace DIRepo
{
    /// <summary>
    ///  Implement IReposatory To Use Mongo DB 
    ///  Author: Refaat Elabd
    /// </summary>
    class MongoDB : IReposatory
    {

        /// <summary>
        ///  Gets Data From MongoDB
        /// </summary>
        /// <returns>
        ///  Actual Data as string
        /// </returns>
        /// <Code>
        ///   return "MongoDB";
        /// </Code>
        /// <param>
        ///  no Parameters
        /// </param>
        public string GetData()
        {
            return "MongoDB";
        }
    }
}
