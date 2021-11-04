using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRepo
{
    /// <summary>
    /// Reposatory Interface for Seprate DAL From Actual Services
    /// 
    /// Author: Refatt Elabd
    /// </summary>
    
    public interface IReposatory
    {
        /// <summary>
        /// Get Data List From Registerd DB 
        /// </summary>
        /// <returns>
        ///  All Data As String
        /// </returns>
        public string GetData();
    }
}
