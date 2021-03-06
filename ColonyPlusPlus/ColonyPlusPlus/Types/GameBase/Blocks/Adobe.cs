﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Adobe : Classes.Type
    {
        public Adobe(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.MaxStackSize = 200;
            this.NPCLimit = 20;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
