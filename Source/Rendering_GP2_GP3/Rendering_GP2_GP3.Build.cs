// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Rendering_GP2_GP3 : ModuleRules
{
	public Rendering_GP2_GP3(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Rendering_GP2_GP3",
			"Rendering_GP2_GP3/Variant_Platforming",
			"Rendering_GP2_GP3/Variant_Platforming/Animation",
			"Rendering_GP2_GP3/Variant_Combat",
			"Rendering_GP2_GP3/Variant_Combat/AI",
			"Rendering_GP2_GP3/Variant_Combat/Animation",
			"Rendering_GP2_GP3/Variant_Combat/Gameplay",
			"Rendering_GP2_GP3/Variant_Combat/Interfaces",
			"Rendering_GP2_GP3/Variant_Combat/UI",
			"Rendering_GP2_GP3/Variant_SideScrolling",
			"Rendering_GP2_GP3/Variant_SideScrolling/AI",
			"Rendering_GP2_GP3/Variant_SideScrolling/Gameplay",
			"Rendering_GP2_GP3/Variant_SideScrolling/Interfaces",
			"Rendering_GP2_GP3/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
