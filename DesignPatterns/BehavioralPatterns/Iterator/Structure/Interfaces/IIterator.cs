﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Structure.Interfaces
{
    interface IIterator
    {
        string GetNext();
        bool HasMore();
    }
}
