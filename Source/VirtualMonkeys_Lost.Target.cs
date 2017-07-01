// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class VirtualMonkeys_LostTarget : TargetRules
{
	public VirtualMonkeys_LostTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "VirtualMonkeys_Lost" } );
	}
}
