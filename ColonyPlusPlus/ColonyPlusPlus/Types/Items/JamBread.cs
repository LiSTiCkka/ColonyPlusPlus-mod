﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class JamBread : Classes.Type
    {
        public JamBread(string name) : base(name)
        {
            this.NutritionalValue = 4.5f;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("berry", 2),
                    RecipeManager.Item("bread", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("jambread", 1)
                },
                0.0f);
        }
    }
}
