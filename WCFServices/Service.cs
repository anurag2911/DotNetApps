﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServices
{
    public class Service : IService
    {
        public string HelloWorld(string text)
        {
            return text;
        }
    }
}
