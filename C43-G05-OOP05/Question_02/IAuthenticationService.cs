﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP05.Question_02
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password);
        public bool AuthorizeUser(string username, string role);
    }
}
