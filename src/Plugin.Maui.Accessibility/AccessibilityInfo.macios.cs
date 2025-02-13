namespace Plugin.Maui.Accessibility;

partial class AccessibilityInfoImplementation : IAccessibilityInfo
{
	// TODO Implement your macOS/iOS specific code
	public PossiblyUnknownBool UseReducedMotion
	{
		get
		{
			try
			{

			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc);
			}

			return PossiblyUnknownBool.Unknown;
		}
	}

	public double TextScaleFactor
	{
		get
		{
			try
			{

			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc);
			}

			return AccessibilityInfo.DefaultTextScaleFactor;
		}
	}
}
