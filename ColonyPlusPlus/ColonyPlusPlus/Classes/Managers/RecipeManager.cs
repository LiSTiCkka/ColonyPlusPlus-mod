﻿using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class RecipeManager
    {

        // list of classes.recipe objects
        public static List<CPPRecipe> recipeList = new List<CPPRecipe>();

        // List of all item classes, registered by the callback
        public static List<Classes.Type> TypesThatHaveRecipes = new List<Classes.Type>();

        // Keep a count of all added recipes (just to output to the user later)
        public static int recipesAdded = 0;

        // Add a new recipe object to the list, this is called by the type's AddRecipes() function
        public static bool AddRecipe(string type, List<InventoryItem> reqs, List<InventoryItem> result, float fuelAmount = 0.0f, bool npcCraft = false)
        {
            // Pass the variables
            CPPRecipe r = new CPPRecipe(type, reqs, result, fuelAmount, npcCraft);

            // Add it to the list
            recipeList.Add(r);
            return true;
        }

        /// <summary>
        /// Build the recipe list using the callback registered class list
        /// </summary>
        public static void BuildRecipeList()
        {
            // Loop through
            foreach (Type t in TypesThatHaveRecipes)
            { 
                // Add it :)
                t.AddRecipes();
            }
        }

        /// <summary>
        /// Process all these added recipes
        /// </summary>
        public static void ProcessRecipes()
        {
            // Go through each registered recipe class
            foreach (CPPRecipe RecipeInstance in recipeList)
            {
                // Switch depending on the "type" registered in the recipe class
                switch (RecipeInstance.Type.ToLower())
                {
                    case "crafting":
                        RecipeCraftingStatic.AllRecipes.Add(new RecipeCrafting(RecipeInstance.NPCCraftable, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "smelting":
                        RecipeSmelting.AllRecipes.Add(new RecipeFueled(0.0f, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "minting":
                        RecipeMinting.AllRecipes.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "grinding":
                        RecipeGrinding.AllRecipes.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "shopping":
                        RecipeShopping.AllRecipes.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "baking":
                        RecipeBaking.AllRecipes.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    default:
                        // if the type isn't registered (or is something random) then just say "nah ain't happenin' man"
                        Utilities.WriteLog("Unable to create recipe of type " + RecipeInstance.Type + " - invalid type");

                        break;
                }

                
            }

            // Log the number of added recipes
            Utilities.WriteLog("Added " + recipesAdded + " recipes");

        }

        /// <summary>
        /// Just a function that performs the item lookup nicely
        /// </summary>
        /// <param name="name">Item name (as it is registered)</param>
        /// <param name="num">The number the inventory should contain</param>
        /// <returns></returns>
        public static InventoryItem Item(string name, int num)
        {
            return new InventoryItem(ItemTypes.IndexLookup.GetIndex(name), num);
        }


        /// <summary>
        /// Register all base game recipes (yes - we added them all here...)
        /// </summary>
        public static void AddBaseRecipes()
        {
            // instantiate the BaseRecipes class
            BaseRecipes br = new BaseRecipes();

            // I'm sure you can figure this out ;)
            br.AddCraftingRecipes();
            br.AddBakingRecipes();
            br.AddGrindingRecipes();
            br.AddMintingRecipes();
            br.AddShoppingRecipes();
            br.AddSmeltingRecipes();
        }
    }
}
