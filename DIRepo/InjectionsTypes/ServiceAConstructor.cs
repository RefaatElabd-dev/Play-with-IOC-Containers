using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRepo
{
    /// <summary>
    /// Service Layer For Entity A To Access Data Access Layer.
    /// 
    /// Author: Refaat
    /// </summary>
    class ServiceAConstructor
    {
        private readonly IReposatory _reposatory;
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        public ServiceAConstructor(IReposatory reposatory)
        {
            _reposatory = reposatory;
        }

        /// <summary>
        ///  Get Data Depending On <see cref="Repository{T}"/>
        /// </summary>
        /// <returns>
        ///  All Data As String
        /// </returns>
        public void GetData()
        {
            Console.WriteLine(_reposatory.GetData()); 
        }
    }
}
