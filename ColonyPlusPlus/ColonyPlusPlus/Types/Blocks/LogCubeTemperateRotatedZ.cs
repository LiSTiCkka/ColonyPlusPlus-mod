﻿using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTemperateRotatedZ : Classes.Type
    {
        public LogCubeTemperateRotatedZ(string name) : base(name)
        {
            
            this.ParentType = "logcubetemperaterotated";

            this.SideAll = "cpplogtemperate";
            this.SideZPlus = "cpplogtemperatetop";
            this.SideZMinus = "cpplogtemperatetop";

           
            this.Register();
        }

        
    }
}
