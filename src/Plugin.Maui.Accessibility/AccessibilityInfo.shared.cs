namespace Plugin.Maui.Accessibility;

public static class AccessibilityInfo
{
	static IAccessibilityInfo? defaultImplementation;

	public const double DefaultTextScaleFactor = 1.0;

	/// <summary>
	/// Provides the default implementation for static usage of this API.
	/// </summary>
	public static IAccessibilityInfo Default =>
		defaultImplementation ??= new AccessibilityInfoImplementation();

	internal static void SetDefault(IAccessibilityInfo? implementation) =>
		defaultImplementation = implementation;
}
