﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    class BlockManager
    {
        // Register all blocks
        public static void register()
        {
           

            // Tell the player what we're doing here
            Classes.Utilities.WriteLog("Starting To Register Blocks");

            // And register!
            Types.Blocks.WildBerryBush wildBerryBush                    = new Types.Blocks.WildBerryBush("wildberrybush");
            Types.Blocks.Sugarcane sugarcane                            = new Types.Blocks.Sugarcane("sugarcane");
            Types.Blocks.VegetablePatch vegetablepatch = new Types.Blocks.VegetablePatch("vegetablepatch");

            // logs
            Types.Blocks.LogCube logcube = new Types.Blocks.LogCube("logcube");
            Types.Blocks.LogCubeTemperate logcubetemperate = new Types.Blocks.LogCubeTemperate("logcubetemperate");
            Types.Blocks.LogCubeTaiga logcubetaiga = new Types.Blocks.LogCubeTaiga("logcubetaiga");
            Types.Blocks.LogCubeRotated logcuberotated = new Types.Blocks.LogCubeRotated("logcuberotated");
            Types.Blocks.LogCubeTemperateRotated logcubetemperaterotated = new Types.Blocks.LogCubeTemperateRotated("logcubetemperaterotated");
            Types.Blocks.LogCubeTemperateRotatedX logcubetemperaterotatedx = new Types.Blocks.LogCubeTemperateRotatedX("logcubetemperaterotatedx");
            Types.Blocks.LogCubeTemperateRotatedZ logcubetemperaterotatedz = new Types.Blocks.LogCubeTemperateRotatedZ("logcubetemperaterotatedz");
            Types.Blocks.LogCubeTaigaRotated logcubetaigarotated = new Types.Blocks.LogCubeTaigaRotated("logcubetaigarotated");
            Types.Blocks.LogCubeTaigaRotatedX logcubetaigarotatedx = new Types.Blocks.LogCubeTaigaRotatedX("logcubetaigarotatedx");
            Types.Blocks.LogCubeTaigaRotatedZ logcubetaigarotatedz = new Types.Blocks.LogCubeTaigaRotatedZ("logcubetaigarotatedz");

            // interactive Items
            //Types.blocks.ChickenCoop chickencoop = new Types.blocks.ChickenCoop("chickencoop");

            // Decorative blocks

            // clay block orientations
            DecorativeTypeManager.TypeOption[] clayblocktypes = new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block,
                DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner,
                DecorativeTypeManager.TypeOption.Slope, DecorativeTypeManager.TypeOption.SlopeCorner, DecorativeTypeManager.TypeOption.SlopeInsideCorner,
                DecorativeTypeManager.TypeOption.UpsideDownSlope, DecorativeTypeManager.TypeOption.UpsideDownSlopeCorner, DecorativeTypeManager.TypeOption.UpsideDownSlopInsideCorner,
                DecorativeTypeManager.TypeOption.TwoStairs, DecorativeTypeManager.TypeOption.FourStairs };

            Classes.Managers.DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockblack = new DecorativeTypeManager("clayblockblack", "clayblockblack", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockblue = new DecorativeTypeManager("clayblockblue", "clayblockblue", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockbrown = new DecorativeTypeManager("clayblockbrown", "clayblockbrown", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockcyan = new DecorativeTypeManager("clayblockcyan", "clayblockcyan", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockgray = new DecorativeTypeManager("clayblockgray", "clayblockgray", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockgreen = new DecorativeTypeManager("clayblockgreen", "clayblockgreen", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocklightblue = new DecorativeTypeManager("clayblocklightblue", "clayblocklightblue", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocklime = new DecorativeTypeManager("clayblocklime", "clayblocklime", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockmagenta = new DecorativeTypeManager("clayblockmagenta", "clayblockmagenta", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockorange = new DecorativeTypeManager("clayblockorange", "clayblockorange", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockpink = new DecorativeTypeManager("clayblockpink", "clayblockpink", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockpurple = new DecorativeTypeManager("clayblockpurple", "clayblockpurple", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockred = new DecorativeTypeManager("clayblockred", "clayblockred", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocksilver = new DecorativeTypeManager("clayblocksilver", "clayblocksilver", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockwhite = new DecorativeTypeManager("clayblockwhite", "clayblockwhite", "clay", "smelting", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockyellow = new DecorativeTypeManager("clayblockyellow", "clayblockyellow", "clay", "smelting", clayblocktypes);


        }
    }
}
