// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information


namespace Eco.Gameplay.Items
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Core.Utils;

    // Only accepts items with tag crushed ore, crushed rock
    public class OreSiloRestriction : InventoryRestriction
    {
        private readonly List<string> allowedTags = new List<string>(new string[] { "CrushedOre", "OreSilo", "CrushedRock" });
        public override LocString Message => Localizer.DoStr("Ore Silos only accept crushed rock or ore.");
        public override int MaxAccepted(Item item, int currentQuantity) => item.Tags().Any(x => this.allowedTags.Contains(x.Name)) ? -1 : 0;
    }
}
