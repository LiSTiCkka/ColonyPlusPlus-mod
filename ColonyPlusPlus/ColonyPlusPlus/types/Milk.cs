﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types
{
    class Milk : classes.Type
    {
        public Milk(string name) : base(name)
        {
            this.Register();
        }
    }
}
