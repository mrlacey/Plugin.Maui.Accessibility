namespace Plugin.Maui.Accessibility;

public enum PossiblyUnknownBool
{
	Unknown,
	False,
	True,
}

public static class BoolExtensions
{
	public static PossiblyUnknownBool ToPossiblyUnknownBool(this bool value)
	{
		return value ? PossiblyUnknownBool.True : PossiblyUnknownBool.False;
	}
}
