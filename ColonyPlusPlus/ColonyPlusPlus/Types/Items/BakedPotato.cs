﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class BakedPotato : Classes.Type
    {
        public BakedPotato(string name) : base(name)
        {
            this.NutritionalValue = 1.0f;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("potatostage1", 2),
                    RecipeManager.Item("cheese", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bakedpotato", 1)
                },
                0.0f);
        }
    }
}
