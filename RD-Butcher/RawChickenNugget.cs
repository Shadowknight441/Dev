// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from RecipeTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;


    /// <summary>
    /// <para>Server side recipe definition for "ButcherMediumAnimal".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class RawChickenNuggetRecipe : RecipeFamily
    {
        public RawChickenNuggetRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PrepRawChickenNugget",  //noloc
                displayName: Localizer.DoStr("Prep Raw Chicken Nugget"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawChickenNuggetItem>(6),
                    new CraftingElement<EggItem>(0.5f),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawChickenNuggetRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Butcher Medium Animal"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Raw Chicken Nugget"), recipeType: typeof(RawChickenNuggetRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

}   

    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Raw Chicken Nugget")] // Defines the localized name of the item.
    [Weight(100)] // Defines how heavy the RawMeat is.
    [Ecopedia("Food", "Raw Chicken Nugget", createAsSubPage: true)]
    [LocDescription("Fresh raw meat from the hunt. It should probably be cooked before being consumed.")] //The tooltip description for the food item.
    public partial class RawChickenNuggetItem : FoodItem
    {

        /// <summary>The plural localization name for the food item.</summary>
        public override LocString DisplayNamePlural     => Localizer.DoStr("Raw Chicken Nugget");

        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories                  => 250;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 8, Protein = 4, Vitamins = 0};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(96);
    }
