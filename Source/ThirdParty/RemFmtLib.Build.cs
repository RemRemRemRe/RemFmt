// Copyright RemRemRemRe. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class RemFmtLib : ModuleRules
{
	public RemFmtLib(ReadOnlyTargetRules target) : base(target)
	{
		Type = ModuleType.External;

		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "fmt/include"));
		PublicDefinitions.Add("FMT_HEADER_ONLY");
	}
}
