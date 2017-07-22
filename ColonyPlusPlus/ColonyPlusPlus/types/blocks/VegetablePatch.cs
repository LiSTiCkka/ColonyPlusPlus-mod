﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.blocks
{
    class VegetablePatch : classes.Type
    {
        public VegetablePatch(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("carrotstage1", 3, 0.5f),
                new classes.ItemHelper.OnRemove("potatostage1", 2, 0.5f),
                new classes.ItemHelper.OnRemove("lettucestage1", 2, 0.5f),
                new classes.ItemHelper.OnRemove("onionstage1", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";

            this.Register();
        }
    }
}
