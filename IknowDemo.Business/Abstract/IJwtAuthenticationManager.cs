﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IknowDemo.Business.Abstract
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
