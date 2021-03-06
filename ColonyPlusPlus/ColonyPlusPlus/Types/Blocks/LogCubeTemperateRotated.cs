﻿using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTemperateRotated : Classes.Type
    {
        public LogCubeTemperateRotated(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("logcubetemperaterotated",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcuberotated";


            this.RotatableXMinus = "logcubetemperaterotatedx";
            this.RotatableXPlus = "logcubetemperaterotatedx";
            this.RotatableZMinus = "logcubetemperaterotatedz";
            this.RotatableZPlus = "logcubetemperaterotatedz";
            this.IsAutoRotatable = true;
            this.IsPlaceable = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperaterotated", 1)
                },
                0.0f);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperate", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperaterotated", 1)
                },
                0.0f);
        }
    }
}
