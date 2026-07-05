// Copyright RemRemRemRe. 2026. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class RemFmt : ModuleRules
{
	public RemFmt(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(
		[
			"Core",

			"RemFmtLib",
		]);
	}
}
