using UnrealBuildTool;

public class TGS_2026_2Target : TargetRules
{
	public TGS_2026_2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;

		bEnableShadowVariableWarnings = false;
		bUndefinedIdentifierWarningsAsErrors = false;
		ExtraModuleNames.Add("TGS_2026_2");
	}
}
