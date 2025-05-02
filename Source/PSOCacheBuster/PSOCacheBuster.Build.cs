using UnrealBuildTool;

public class PSOCacheBuster : ModuleRules
{
	public PSOCacheBuster(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		PrivateDependencyModuleNames.Add("Core");

		// re-add macro, because it's private in core!
		PrivateDefinitions.Add("IS_CLIENT_TARGET=" + (Target.Type == TargetRules.TargetType.Client ? "1" : "0"));
	}
}
