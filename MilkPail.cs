



//Replace MilkCow Recipe with this
[RequiresSkill(typeof(RancherSkill), 2)]
[Ecopedia("Items", "Products", createAsSubPage: true)]
public partial class MilkTheCowRecipe : RecipeFamily
{
    public MilkTheCowRecipe()
    {
        var recipe = new Recipe();
        recipe.Init(
            name: "Milking A Cow",
            displayName: Localizer.DoStr("Milking A Cow"),
            ingredients: new List<IngredientElement>
            {
                new IngredientElement(typeof(DairyCowItem), 1, true),
                new IngredientElement(typeof(BucketItem), 3, true),
            },
            items: new List<CraftingElement>
            {
                new CraftingElement<MilkPail>(3)
            });
        this.Recipes = new List<Recipe> { recipe };
        this.ExperienceOnCraft = 5;
        this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
        this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MilkTheCowRecipe), start: 5, skillType: typeof(RancherSkill));
        this.ModsPreInitialize();
        this.Initialize(displayText: Localizer.DoStr("Milking A Cow"), recipeType: typeof(MilkTheCowRecipe));
        this.ModsPostInitialize();
        CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
    }
    partial void ModsPreInitialize();
    partial void ModsPostInitialize();


    //Replace MilkCowItem with this
    [Serialized] 
    [LocDisplayName("Pail Of Milk")] 
    [Weight(250)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [Tag("Milk")]
    [LocDescription("A Pail of Rich & Creamy Milk, From a Dairy Cow")] 
    public partial class MilkPail : Item
    {
    }