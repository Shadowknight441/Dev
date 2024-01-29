namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Storage;
    using Eco.Gameplay.Objects;
    using Eco.Shared.Math;
    using Eco.Shared.SharedTypes;


    public partial class WoodenShelvingUnitObject : WorldObject
    {
        protected override void PostInitialize()
        {
            base.PostInitialize();
			this.GetComponent<LinkComponent>().Initialize(24);
        }
    }
}