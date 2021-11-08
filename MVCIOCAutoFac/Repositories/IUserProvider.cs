using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIOCAutoFac.Repositories
{
    public interface IUserProvider
    {
        string UserName { get; }
    }
}