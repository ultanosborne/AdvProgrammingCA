﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgrammingCA.DataHandling
{
    class Login
    {
        public bool check(string u, string p)
        {
            if (u == "username" && p == "pass")
                return true;
            return false;
        }
    }
}
