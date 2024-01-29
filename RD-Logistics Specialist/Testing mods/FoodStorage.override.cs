﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Storage;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Shared.Math;
    using Eco.Shared.SharedTypes;

	[RequireComponent(typeof(PublicStorageComponent))]
	[RequireComponent(typeof(LinkComponent))]
    public partial class IceboxObject : WorldObject
    {
        protected override void PostInitialize()
        {
            base.PostInitialize();
            this.GetComponent<PublicStorageComponent>().Storage.AddInvRestriction(new FoodStorageRestriction());
			this.GetComponent<LinkComponent>().Initialize(24);
        }
    }
	
	[RequireComponent(typeof(LinkComponent))]
    public partial class RefrigeratorObject : WorldObject
    {
        protected override void PostInitialize()
        {
            base.PostInitialize();
            this.GetComponent<PublicStorageComponent>().Storage.AddInvRestriction(new FoodStorageRestriction());
			this.GetComponent<LinkComponent>().Initialize(24);
        }
    }

	[RequireComponent(typeof(LinkComponent))]
    public partial class IndustrialRefrigeratorObject : WorldObject
    {
        protected override void PostInitialize()
        {
            base.PostInitialize();
            this.GetComponent<PublicStorageComponent>().Storage.AddInvRestriction(new FoodStorageRestriction());
			this.GetComponent<LinkComponent>().Initialize(24);
        }
    }
}
