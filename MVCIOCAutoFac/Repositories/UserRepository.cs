﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIOCAutoFac.Repositories
{
    public class UserRepository:IUserRepository
    {
        public string GetData() {
            return "UserData";
        }
    }
}