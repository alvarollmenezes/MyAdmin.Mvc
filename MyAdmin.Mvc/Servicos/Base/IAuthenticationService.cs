﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAdmin.Mvc.Servicos.Base
{
    public interface IAuthenticationService
    {
        bool Login(string username, string password);
    }
}