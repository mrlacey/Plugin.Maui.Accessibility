namespace Plugin.Maui.Accessibility;

partial class AccessibilityInfoImplementation : IAccessibilityInfo
{
	public PossiblyUnknownBool UseReducedMotion
	{
		get
		{
			try
			{
				var uiSettings = new Windows.UI.ViewManagement.UISettings();

				// Not that UseReducedMotion is the opposite of using animation (or having it enabled)
				return uiSettings.AnimationsEnabled
					? PossiblyUnknownBool.False
					: PossiblyUnknownBool.True;
			}
			catch (Exception)
			{
				return PossiblyUnknownBool.Unknown;
			}
		}
	}

	public double TextScaleFactor
	{
		get
		{
			try
			{
				var uiSettings = new Windows.UI.ViewManagement.UISettings();

				return uiSettings.TextScaleFactor;
			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc);
				return AccessibilityInfo.DefaultTextScaleFactor;
			}
		}
	}
}
