namespace Plugin.Maui.Accessibility;

partial class AccessibilityInfoImplementation : IAccessibilityInfo
{
	public PossiblyUnknownBool UseReducedMotion => PossiblyUnknownBool.Unknown;

	public double TextScaleFactor => AccessibilityInfo.DefaultTextScaleFactor;
}
