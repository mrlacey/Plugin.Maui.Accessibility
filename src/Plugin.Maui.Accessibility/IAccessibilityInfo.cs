namespace Plugin.Maui.Accessibility;

public interface IAccessibilityInfo
{
	/// <summary>
	/// Is the device configured for reduced motion and/or not showing animations.
	/// </summary>
	PossiblyUnknownBool UseReducedMotion { get; }

	/// <summary>
	/// The scale factor for text on the device.
	/// </summary>
	double TextScaleFactor { get; }
}
