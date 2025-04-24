// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PlayerAction_Project : ModuleRules
{
	public PlayerAction_Project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
